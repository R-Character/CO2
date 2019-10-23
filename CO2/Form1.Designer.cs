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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.Fenster = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trkInitialWert = new System.Windows.Forms.TrackBar();
            this.RaumGroesse = new System.Windows.Forms.TextBox();
            this.InitialWert = new System.Windows.Forms.TextBox();
            this.Personen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabEinstellung = new System.Windows.Forms.TabPage();
            this.btnEinstellungDefault = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEinstellungAktualisieren = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxEinstellungConnectionString = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkInitialWert)).BeginInit();
            this.tabEinstellung.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabEinstellung);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 472);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 7;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.Fenster);
            this.tabHome.Controls.Add(this.progressBar1);
            this.tabHome.Controls.Add(this.trkInitialWert);
            this.tabHome.Controls.Add(this.RaumGroesse);
            this.tabHome.Controls.Add(this.InitialWert);
            this.tabHome.Controls.Add(this.Personen);
            this.tabHome.Controls.Add(this.label3);
            this.tabHome.Controls.Add(this.label2);
            this.tabHome.Controls.Add(this.label9);
            this.tabHome.Controls.Add(this.label7);
            this.tabHome.Controls.Add(this.label8);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Controls.Add(this.btnSend);
            this.tabHome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabHome.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabHome.Location = new System.Drawing.Point(4, 26);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(495, 442);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // Fenster
            // 
            this.Fenster.FormattingEnabled = true;
            this.Fenster.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.Fenster.Location = new System.Drawing.Point(300, 67);
            this.Fenster.Name = "Fenster";
            this.Fenster.Size = new System.Drawing.Size(66, 25);
            this.Fenster.TabIndex = 1;
            this.Fenster.Text = "1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(105, 336);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // trkInitialWert
            // 
            this.trkInitialWert.BackColor = System.Drawing.Color.White;
            this.trkInitialWert.LargeChange = 50;
            this.trkInitialWert.Location = new System.Drawing.Point(95, 204);
            this.trkInitialWert.Maximum = 1000;
            this.trkInitialWert.Minimum = 800;
            this.trkInitialWert.Name = "trkInitialWert";
            this.trkInitialWert.Size = new System.Drawing.Size(278, 45);
            this.trkInitialWert.SmallChange = 10;
            this.trkInitialWert.TabIndex = 5;
            this.trkInitialWert.TickFrequency = 10;
            this.trkInitialWert.Value = 800;
            this.trkInitialWert.Scroll += new System.EventHandler(this.TrkInitialWert_Scroll);
            // 
            // RaumGroesse
            // 
            this.RaumGroesse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RaumGroesse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaumGroesse.Location = new System.Drawing.Point(300, 129);
            this.RaumGroesse.Name = "RaumGroesse";
            this.RaumGroesse.Size = new System.Drawing.Size(33, 27);
            this.RaumGroesse.TabIndex = 3;
            this.RaumGroesse.Text = "25";
            // 
            // InitialWert
            // 
            this.InitialWert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InitialWert.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialWert.Location = new System.Drawing.Point(300, 161);
            this.InitialWert.Name = "InitialWert";
            this.InitialWert.Size = new System.Drawing.Size(33, 27);
            this.InitialWert.TabIndex = 4;
            this.InitialWert.Text = "800";
            this.InitialWert.Leave += new System.EventHandler(this.TxtInitialWert_Leave);
            // 
            // Personen
            // 
            this.Personen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Personen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Personen.Location = new System.Drawing.Point(300, 97);
            this.Personen.Name = "Personen";
            this.Personen.Size = new System.Drawing.Size(66, 27);
            this.Personen.TabIndex = 2;
            this.Personen.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "CO2 Initialwert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Anzahl der Personen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "m³";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fenster";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Raumgröße";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(105, 293);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(261, 37);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Start";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tabEinstellung
            // 
            this.tabEinstellung.Controls.Add(this.btnEinstellungDefault);
            this.tabEinstellung.Controls.Add(this.comboBox1);
            this.tabEinstellung.Controls.Add(this.btnEinstellungAktualisieren);
            this.tabEinstellung.Controls.Add(this.label6);
            this.tabEinstellung.Controls.Add(this.label5);
            this.tabEinstellung.Controls.Add(this.label4);
            this.tabEinstellung.Controls.Add(this.txtboxEinstellungConnectionString);
            this.tabEinstellung.Location = new System.Drawing.Point(4, 26);
            this.tabEinstellung.Name = "tabEinstellung";
            this.tabEinstellung.Padding = new System.Windows.Forms.Padding(3);
            this.tabEinstellung.Size = new System.Drawing.Size(495, 442);
            this.tabEinstellung.TabIndex = 1;
            this.tabEinstellung.Text = "Einstellungen";
            this.tabEinstellung.UseVisualStyleBackColor = true;
            // 
            // btnEinstellungDefault
            // 
            this.btnEinstellungDefault.Location = new System.Drawing.Point(376, 56);
            this.btnEinstellungDefault.Name = "btnEinstellungDefault";
            this.btnEinstellungDefault.Size = new System.Drawing.Size(71, 24);
            this.btnEinstellungDefault.TabIndex = 8;
            this.btnEinstellungDefault.Text = "Default";
            this.btnEinstellungDefault.UseVisualStyleBackColor = true;
            this.btnEinstellungDefault.Click += new System.EventHandler(this.BtnEinstellungDefault_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(201, 186);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(55, 25);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "5";
            // 
            // btnEinstellungAktualisieren
            // 
            this.btnEinstellungAktualisieren.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEinstellungAktualisieren.Location = new System.Drawing.Point(110, 255);
            this.btnEinstellungAktualisieren.Name = "btnEinstellungAktualisieren";
            this.btnEinstellungAktualisieren.Size = new System.Drawing.Size(252, 47);
            this.btnEinstellungAktualisieren.TabIndex = 11;
            this.btnEinstellungAktualisieren.Text = "Einstellungen aktualisieren";
            this.btnEinstellungAktualisieren.UseVisualStyleBackColor = true;
            this.btnEinstellungAktualisieren.Click += new System.EventHandler(this.BtnEinstellungAktualisieren_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(262, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sekunde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Periode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Connection String";
            // 
            // txtboxEinstellungConnectionString
            // 
            this.txtboxEinstellungConnectionString.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxEinstellungConnectionString.Location = new System.Drawing.Point(49, 81);
            this.txtboxEinstellungConnectionString.Multiline = true;
            this.txtboxEinstellungConnectionString.Name = "txtboxEinstellungConnectionString";
            this.txtboxEinstellungConnectionString.Size = new System.Drawing.Size(399, 66);
            this.txtboxEinstellungConnectionString.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "ppm";
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
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkInitialWert)).EndInit();
            this.tabEinstellung.ResumeLayout(false);
            this.tabEinstellung.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabEinstellung;
        private System.Windows.Forms.TrackBar trkInitialWert;
        private System.Windows.Forms.TextBox RaumGroesse;
        private System.Windows.Forms.TextBox Personen;
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
        private System.Windows.Forms.TextBox InitialWert;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Fenster;
        private System.Windows.Forms.Label label9;
    }
}

