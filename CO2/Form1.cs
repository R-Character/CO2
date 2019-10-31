using System;
using System.Windows.Forms;


namespace CO2
{
    public partial class Form1 : Form
    {
        Device myDevice = new Device();
        public int period;
        public bool myFlag = true;
        int CO2Wert = 0; //Anfangswert

        public Form1()
        {
            InitializeComponent();
            label10.Hide();
            txtboxEinstellungConnectionString.Text = myDevice.GetConString(); //Connection String wird in Textbox geschrieben
            period = Convert.ToInt32(value: comboBox1.Text); //Periode wird eingestellt

        }

        private void BtnSend_Click(object sender, EventArgs e) //Button Start oder Stop
        {
            if (myFlag)             //stoppen des Sendevorgangs
            {
                RaumGroesse.Enabled = trkInitialWert.Enabled = myFlag =
                    tabEinstellung.Enabled = InitialWert.Enabled = false; 
                btnSend.Text = "Stop";

                label10.Show(); //"Bereit Nachricht zu empfangen" wird angezeigt
                this.timer1.Start();
            }
            else
            {           //Start des Sendevorgangs
                RaumGroesse.Enabled = trkInitialWert.Enabled = myFlag =
                    tabEinstellung.Enabled = InitialWert.Enabled = true;
                btnSend.Text = "Start";
                label10.Hide(); //"Bereit Nachricht zu empfangen" wird nicht angezeigt
                this.timer1.Stop();
            }
        }

        //Connection String wird auf Default zurückgestellt
        private void BtnEinstellungDefault_Click(object sender, EventArgs e)  //Button "Deafault" in Reiter Einstellung
        {
            myDevice.ResetConString();                                                  
            txtboxEinstellungConnectionString.Text = myDevice.GetConString();
        }
        //Trackbar
        private void TrkInitialWert_Scroll(object sender, EventArgs e) //Scroll Balken für den inital Wert
        {
            InitialWert.Text = "" + trkInitialWert.Value;
        }

        private void BtnEinstellungAktualisieren_Click(object sender, EventArgs e)//Button für "Einstellungen aktualisieren"
        {
            period = Convert.ToInt32(value: comboBox1.Text); // update Periode

            //alter Conncection String wird für aktulles Objekt aktualisiert
            myDevice = new Device(txtboxEinstellungConnectionString.Text); //neuer Connection String wird übernommen
            MessageBox.Show("Die Einstellungen werden aktualisiert.", "Aktualisiert", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void Timer1_Tick(object sender, EventArgs e) //Timer einstellen
        {
            DateTime now = DateTime.Now; 
            if (progressBar1.Value != 100)
                this.progressBar1.Increment(50 / period);
            else
            {
                //Erstellt eine Nachricht und bereit Nachrichten von IoTHub zu empfangen sowie zu senden
                string msg = Convert.ToString(CalcCO2()) + "ppm CO2 pro Stunde \tum " + now.ToString("HH:mm:ss") + "\tvom Gerät: " + myDevice.getDeviceName(); //angezeigte Nachricht(Data)
                myDevice.SendMessageToAzureIoTHub(msg);  //senden von Nachricht an IoTHub
                myDevice.RecievMessageFromAzureIoTHub(); // empfangen von Message an IoTHub
                progressBar1.Value = 0;
            }
        }

        private void TxtInitialWert_Leave(object sender, EventArgs e) //initalWert Eingabe
        {
            int myWert = Convert.ToInt32(InitialWert.Text);
            if (myWert >= 800 && myWert <= 1000)        //Prüfung, ob der eingegebene inital Wert im Wertebereich liegt
                trkInitialWert.Value = Convert.ToInt32(InitialWert.Text);
            else //für den Fall, das der inital Wert nicht im Wertebereich liegt
                MessageBox.Show("Der CO2 Initialwert muss zwischen 800 und 1000 sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private int CalcCO2() //Berechnung des Co2 Wert
        {
            CO2Wert = (Convert.ToInt32(RaumGroesse.Text)) * (Convert.ToInt32(InitialWert.Text));
            CO2Wert += (250 * Convert.ToInt32(Personen.Text)) - (10 * Convert.ToInt32(Fenster.Text));

            return CO2Wert;
        }

    }
}
