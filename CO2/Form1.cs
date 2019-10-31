using System;
using System.Windows.Forms;


namespace CO2
{
    public partial class Form1 : Form
    {
        Device myDevice = new Device();
        public int period;
        public bool myFlag = true;
        int CO2Wert = 0;

        public Form1()
        {
            InitializeComponent();
            label10.Hide();
            txtboxEinstellungConnectionString.Text = myDevice.GetConString();
            period = Convert.ToInt32(value: comboBox1.Text);

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (myFlag)
            {
                RaumGroesse.Enabled = trkInitialWert.Enabled = myFlag =
                    tabEinstellung.Enabled = InitialWert.Enabled = false;
                btnSend.Text = "Stop";

                label10.Show();
                this.timer1.Start();
            }
            else
            {
                RaumGroesse.Enabled = trkInitialWert.Enabled = myFlag =
                    tabEinstellung.Enabled = InitialWert.Enabled = true;
                btnSend.Text = "Start";
                label10.Hide();
                this.timer1.Stop();
            }
        }


        private void BtnEinstellungDefault_Click(object sender, EventArgs e)
        {
            myDevice.ResetConString();
            txtboxEinstellungConnectionString.Text = myDevice.GetConString();
        }

        private void TrkInitialWert_Scroll(object sender, EventArgs e)
        {
            InitialWert.Text = "" + trkInitialWert.Value;
        }

        private void BtnEinstellungAktualisieren_Click(object sender, EventArgs e)
        {
            period = Convert.ToInt32(value: comboBox1.Text); // update Periode
            myDevice = new Device(txtboxEinstellungConnectionString.Text);
            MessageBox.Show("Die Einstellungen werden aktualisiert.", "Aktualisiert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (progressBar1.Value != 100)
                this.progressBar1.Increment(50 / period);
            else
            {
                string msg = Convert.ToString(CalcCO2()) + "ppm CO2 pro Stunde \tum " + now.ToString("HH:mm:ss") + "\tvom Gerät: " + myDevice.getDeviceName();
                myDevice.SendMessageToAzureIoTHub(msg);
                myDevice.RecievMessageFromAzureIoTHub();
                progressBar1.Value = 0;
            }
        }

        private void TxtInitialWert_Leave(object sender, EventArgs e)
        {
            int myWert = Convert.ToInt32(InitialWert.Text);
            if (myWert >= 800 && myWert <= 1000)
                trkInitialWert.Value = Convert.ToInt32(InitialWert.Text);
            else
                MessageBox.Show("Der CO2 Initialwert muss zwischen 800 und 1000 sein!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private int CalcCO2()
        {
            CO2Wert = (Convert.ToInt32(RaumGroesse.Text)) * (Convert.ToInt32(InitialWert.Text));
            CO2Wert += (250 * Convert.ToInt32(Personen.Text)) - (10 * Convert.ToInt32(Fenster.Text));

            return CO2Wert;
        }

    }
}
