using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices.Client;  //importieren von Azure Bibliotheken

namespace CO2
{
    public class Device
    {
        //Klassenvariablen
        private string myConString;
        private DeviceClient myDev;




        public Device () //Konstruktor ohne Connection String
        {
            ResetConString();
            myDev = DeviceClient.CreateFromConnectionString(myConString);
        }

        public Device (string conString) //Konstruktor mit Connection String als Rückgabewert
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

        public void ResetConString() //Connection String wird initialisiert
        {
            myConString = "HostName=CO2-SensorData-Dukes.azure-devices.net;DeviceId=CO2SimulatorDukes;SharedAccessKey=jtBS7Ef1Msuj01bsisaovhknHPNy7Q48XPHMbj+OTzM=";
        }
        
        public void SetConString(string conString)//Setter-Methode des Connection String
        {
            myConString = conString;
        }

        public string GetConString() //Getter-Methode des Connections String
        {
            return myConString;            
        }

        public string getDeviceName() //Getter-Methode des Device Name
        {
            IotHubConnectionStringBuilder myDeviceID = IotHubConnectionStringBuilder.Create(myConString);
            return myDeviceID.DeviceId; //für DeviceID braucht man ein Objekt von der Klasse "IoTHubConnectionStringBuilder"
        }

        public void SendMessageToAzureIoTHub(string message)// Nachricht wird an IoTHub zurückgegeben
        {
            if (myDev != null)
            {
                try
                {
                    var myMessage = new Microsoft.Azure.Devices.Client.Message(Encoding.UTF8.GetBytes(message)); //ein Objekt für Message wird deklariert
                    myDev.SendEventAsync(myMessage); // send message
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Fehler:/n" + ex.Message, "Fehlder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void RecievMessageFromAzureIoTHub()//Empfangen der Nachricht von IoTHub
        {
            if (myDev != null) //If-Anweisung wird ausgelöst, sobald ein Device bereit zu initialisieren ist
            {
                Task.Run(async () =>   //asynchrone Ausführung
                {
                    while (true)
                    {
                        Microsoft.Azure.Devices.Client.Message myReceivedMessage = null;
                        try
                        {
                            myReceivedMessage = await myDev.ReceiveAsync(); //Warten auf empfangen einer Nachricht
                            if (myReceivedMessage != null)
                            {
                                byte[] data = myReceivedMessage.GetBytes();  //Bytes werden in einem Array gespeichert
                                MessageBox.Show(Encoding.UTF8.GetString(data, 0, data.Length) + "\r\n", "Eine neue Nachricht", MessageBoxButtons.OK, MessageBoxIcon.Information); //Konvertieren zu einem String
                                await myDev.CompleteAsync(myReceivedMessage); //asynchrone Ausführung wird beendet
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
