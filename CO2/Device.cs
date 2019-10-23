using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices.Client;

namespace CO2
{
    public class Device
    {
        private string myConString;
        private DeviceClient myDev;




        public Device ()
        {
            ResetConString();
            myDev = DeviceClient.CreateFromConnectionString(myConString);
        }

        public Device (string conString)
        {
            SetConString(conString);
            try
            {
                myDev = DeviceClient.CreateFromConnectionString(myConString);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Fehler:\n" + ex.Message, "Fehler",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

        }

        public void ResetConString()
        {
            myConString = "HostName=CO2-SensorData-Dukes.azure-devices.net;DeviceId=CO2SimulatorDukes;SharedAccessKey=jtBS7Ef1Msuj01bsisaovhknHPNy7Q48XPHMbj+OTzM=";
        }
        
        public void SetConString(string conString)
        {
            myConString = conString;
        }

        public string GetConString()
        {
            return myConString;            
        }

        public string getDeviceName()
        {
            IotHubConnectionStringBuilder myDeviceID = IotHubConnectionStringBuilder.Create(myConString);
            return myDeviceID.DeviceId;
        }

        public void SendMessageToAzureIoTHub(string message)
        {
            if (myDev != null)
            {
                try
                {
                    var myMessage = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(message));
                    myDev.SendEventAsync(myMessage); // send message
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Fehler:/n" + ex.Message, "Fehlder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RecievMessageFromAzureIoTHub()
        {
            if (myDev != null)
            {
                Task.Run(async () =>
                {
                    while (true)
                    {
                        Microsoft.Azure.Devices.Client.Message myReceivedMessage = null;
                        try
                        {
                            myReceivedMessage = await myDev.ReceiveAsync();
                            if (myReceivedMessage != null)
                            {
                                byte[] data = myReceivedMessage.GetBytes();
                                MessageBox.Show(Encoding.UTF8.GetString(data, 0, data.Length) + "\r\n", "Eine neue Nachricht", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await myDev.CompleteAsync(myReceivedMessage);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error while receiving message: \n" + ex.Message);
                        }
                    }
                }
                );
            }
        }

    }
}
