namespace CO2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trkInitialWert = new System.Windows.Forms.TrackBar();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtInitialWert = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.Einstellung = new System.Windows.Forms.TabPage();
            this.btnEinstellungDefault = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEinstellungAktualisieren = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxEinstellungConnectionString = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkInitialWert)).BeginInit();
            this.Einstellung.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Einstellung);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 472);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 7;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.progressBar1);
            this.Home.Controls.Add(this.trkInitialWert);
            this.Home.Controls.Add(this.textBox3);
            this.Home.Controls.Add(this.txtInitialWert);
            this.Home.Controls.Add(this.textBox2);
            this.Home.Controls.Add(this.label3);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.label7);
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.btnSend);
            this.Home.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Home.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Home.Location = new System.Drawing.Point(4, 26);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(495, 442);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(105, 339);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(238, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // trkInitialWert
            // 
            this.trkInitialWert.BackColor = System.Drawing.Color.White;
            this.trkInitialWert.LargeChange = 50;
            this.trkInitialWert.Location = new System.Drawing.Point(97, 164);
            this.trkInitialWert.Maximum = 1000;
            this.trkInitialWert.Minimum = 800;
            this.trkInitialWert.Name = "trkInitialWert";
            this.trkInitialWert.Size = new System.Drawing.Size(254, 45);
            this.trkInitialWert.SmallChange = 10;
            this.trkInitialWert.TabIndex = 14;
            this.trkInitialWert.TickFrequency = 10;
            this.trkInitialWert.Value = 800;
            this.trkInitialWert.Scroll += new System.EventHandler(this.trkInitialWert_Scroll);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(300, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 27);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "25";
            // 
            // txtInitialWert
            // 
            this.txtInitialWert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitialWert.Enabled = false;
            this.txtInitialWert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitialWert.Location = new System.Drawing.Point(300, 126);
            this.txtInitialWert.Name = "txtInitialWert";
            this.txtInitialWert.Size = new System.Drawing.Size(43, 27);
            this.txtInitialWert.TabIndex = 13;
            this.txtInitialWert.Text = "800";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(300, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 27);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "CO2 Initialwert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Anzahl der Personen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "m³";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Raumgröße";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(105, 296);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(238, 37);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Beginn zu senden";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Einstellung
            // 
            this.Einstellung.Controls.Add(this.btnEinstellungDefault);
            this.Einstellung.Controls.Add(this.comboBox1);
            this.Einstellung.Controls.Add(this.btnEinstellungAktualisieren);
            this.Einstellung.Controls.Add(this.label6);
            this.Einstellung.Controls.Add(this.label5);
            this.Einstellung.Controls.Add(this.label4);
            this.Einstellung.Controls.Add(this.txtboxEinstellungConnectionString);
            this.Einstellung.Location = new System.Drawing.Point(4, 26);
            this.Einstellung.Name = "Einstellung";
            this.Einstellung.Padding = new System.Windows.Forms.Padding(3);
            this.Einstellung.Size = new System.Drawing.Size(495, 442);
            this.Einstellung.TabIndex = 1;
            this.Einstellung.Text = "Einstellungen";
            this.Einstellung.UseVisualStyleBackColor = true;
            // 
            // btnEinstellungDefault
            // 
            this.btnEinstellungDefault.Location = new System.Drawing.Point(366, 43);
            this.btnEinstellungDefault.Name = "btnEinstellungDefault";
            this.btnEinstellungDefault.Size = new System.Drawing.Size(71, 24);
            this.btnEinstellungDefault.TabIndex = 21;
            this.btnEinstellungDefault.Text = "Default";
            this.btnEinstellungDefault.UseVisualStyleBackColor = true;
            this.btnEinstellungDefault.Click += new System.EventHandler(this.btnEinstellungDefault_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "30",
            "60",
            "120",
            "240"});
            this.comboBox1.Location = new System.Drawing.Point(38, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 25);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "5";
            // 
            // btnEinstellungAktualisieren
            // 
            this.btnEinstellungAktualisieren.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinstellungAktualisieren.Location = new System.Drawing.Point(38, 323);
            this.btnEinstellungAktualisieren.Name = "btnEinstellungAktualisieren";
            this.btnEinstellungAktualisieren.Size = new System.Drawing.Size(252, 31);
            this.btnEinstellungAktualisieren.TabIndex = 19;
            this.btnEinstellungAktualisieren.Text = "Einstellungen aktualisieren";
            this.btnEinstellungAktualisieren.UseVisualStyleBackColor = true;
            this.btnEinstellungAktualisieren.Click += new System.EventHandler(this.btnEinstellungAktualisieren_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sekunde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Periode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Connection String";
            // 
            // txtboxEinstellungConnectionString
            // 
            this.txtboxEinstellungConnectionString.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEinstellungConnectionString.Location = new System.Drawing.Point(38, 68);
            this.txtboxEinstellungConnectionString.Multiline = true;
            this.txtboxEinstellungConnectionString.Name = "txtboxEinstellungConnectionString";
            this.txtboxEinstellungConnectionString.Size = new System.Drawing.Size(399, 66);
            this.txtboxEinstellungConnectionString.TabIndex = 17;
            this.txtboxEinstellungConnectionString.Text = "HostName=my-IoT-Hub26.azure-devices.net;DeviceId=Dev.27;SharedAccessKey=h8WtYrwKQ" +
    "81E6Vbp6iiGBge1t8lOfRRJvnwHJGG3Jfk=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CO2";
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkInitialWert)).EndInit();
            this.Einstellung.ResumeLayout(false);
            this.Einstellung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Einstellung;
        private System.Windows.Forms.TrackBar trkInitialWert;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnEinstellungAktualisieren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxEinstellungConnectionString;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnEinstellungDefault;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInitialWert;
    }
}

