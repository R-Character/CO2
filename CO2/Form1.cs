using Microsoft.Azure.Devices.Client; // API für: 
using System;
using System.Diagnostics; // für error
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 1. Verbindung zwischen IoT-Hub und Gerät
// 2. Nachricht zu schicken
// 3. Nachricht zu bekommen


namespace CO2
{
    public partial class Form1 : Form
    {

        public string myConString = "";
        int period = 10;
        bool myFlag = true;

        public Form1()
        {
            InitializeComponent();
            ResetConString();
            period = System.Convert.ToInt32(comboBox1.Text);
        }

        public class Device
        {
            DeviceClient myDev; // whats this

            public Device(string ConnectionString)
            {
                myDev = DeviceClient.CreateFromConnectionString(ConnectionString);


                if (myDev != null)
                {
                    Task.Run(async () =>
                    {
                        while (true)
                        {
                            Microsoft.Azure.Devices.Client.Message ReceivedMessage = null;
                            try
                            {
                                ReceivedMessage = await myDev.ReceiveAsync();
                                if (ReceivedMessage != null)
                                {
                                    byte[] data = ReceivedMessage.GetBytes();
                                    Debug.WriteLine(Encoding.UTF8.GetString(data, 0, data.Length) + "\r\n");
                                    Debug.WriteLine("message recieved.");
                                    await myDev.CompleteAsync(ReceivedMessage);
                                    Debug.WriteLine("message completed");
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine("Error while sending message: \n" + ex.Message);
                                throw;
                            }
                        }
                    }
                    );
                }


            }

            public void SendMessageToAzureIoTHub(string message)
            {
                if (myDev != null)
                {
                    try
                    {
                        var EventMessage = new Microsoft.Azure.Devices.Client.Message(System.Text.Encoding.UTF8.GetBytes(message));
                        myDev.SendEventAsync(EventMessage); // send message
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Error:/n" + ex.Message);
                    }
                }
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (myFlag)
            {
                this.timer1.Start();
                btnSend.Text = "Stop";
                myFlag = false;
            }
            else
            {
                this.timer1.Stop();
                btnSend.Text = "Start";
                myFlag = true;
            }
        }


        private void btnEinstellungDefault_Click(object sender, EventArgs e)
        {
            ResetConString();
        }

        private void trkInitialWert_Scroll(object sender, EventArgs e)
        {
            txtInitialWert.Text = "" + trkInitialWert.Value;
        }

        public void ResetConString()
        {
            txtboxEinstellungConnectionString.Text = "HostName=my-IoT-Hub26.azure-devices.net;DeviceId=MyDotnetDevice;SharedAccessKey=VPLcTwLo0TvOMQphFd1Wf7s0HXj7fbcOGyYaIsTKrQc=";
            myConString = txtboxEinstellungConnectionString.Text; // in update click
        }

        private void btnEinstellungAktualisieren_Click(object sender, EventArgs e)
        {
            period = System.Convert.ToInt32(comboBox1.Text);
        }

        // increase and reset progressbar
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
                this.progressBar1.Increment(50 / period);
            else
            {
                Device myIoTHubClient = new Device(myConString); // overflow
                myIoTHubClient.SendMessageToAzureIoTHub("Test");
                progressBar1.Value = 0;
            }


        }
    }
}
