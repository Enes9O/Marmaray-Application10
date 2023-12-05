namespace Marmaray_Applicatiion_7
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer4 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(886, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Marmaray_Applicatiion_7.Properties.Resources.ok_hareketli_resim_0061;
            this.pictureBox1.Location = new System.Drawing.Point(526, 264);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(268, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(267, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 32);
            this.label5.TabIndex = 29;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InfoText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(908, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 71);
            this.button1.TabIndex = 28;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(695, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(276, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 38);
            this.label3.TabIndex = 26;
            this.label3.Text = "label3";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "GEBZE",
            "DARICA",
            "OSMANGAZİ",
            "FATİH",
            "ÇAYIROVA",
            "TUZLA",
            "İÇMELER",
            "AYDINTEPE",
            "GÜZELYALI",
            "TERSANE",
            "KAYNARCA",
            "PENDİK",
            "YUNUS",
            "KARTAL",
            "BAŞAK",
            "ATALAR",
            "CEVİZLİ ",
            "MALTEPE",
            "SÜREYYAPLAJI",
            "İDEALTEPE",
            "KÜÇÜKYALI",
            "BOSTANCI",
            "SUADİYE",
            "ERENKÖY",
            "GÖZTEPE",
            "FENERYOLU",
            "SÖĞÜTLÜÇEŞME",
            "AYRILIK ÇEŞMESİ",
            "ÜSKÜDAR",
            "",
            "SİRKECİ",
            "YENİKAPI",
            "KAZLIÇEŞME",
            "ZEYTİNBURNU",
            "YENİMAHALLE",
            "BAKIRKÖY",
            "ATAKÖY",
            "YEŞİLYURT",
            "YEŞİLKÖY",
            "FLORYA AKVARYUM",
            "FLORYA",
            "KÜÇÜKÇEKMECE",
            "MUSTAFA KEMAL",
            "HALKALI"});
            this.comboBox2.Location = new System.Drawing.Point(529, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 24);
            this.comboBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GEBZE",
            "DARICA",
            "OSMANGAZİ",
            "FATİH",
            "ÇAYIROVA",
            "TUZLA",
            "İÇMELER",
            "AYDINTEPE",
            "GÜZELYALI",
            "TERSANE",
            "KAYNARCA",
            "PENDİK",
            "YUNUS",
            "KARTAL",
            "BAŞAK",
            "ATALAR",
            "CEVİZLİ ",
            "MALTEPE",
            "SÜREYYAPLAJI",
            "İDEALTEPE",
            "KÜÇÜKYALI",
            "BOSTANCI",
            "SUADİYE",
            "ERENKÖY",
            "GÖZTEPE",
            "FENERYOLU",
            "SÖĞÜTLÜÇEŞME",
            "AYRILIK ÇEŞMESİ",
            "ÜSKÜDAR",
            "",
            "SİRKECİ",
            "YENİKAPI",
            "KAZLIÇEŞME",
            "ZEYTİNBURNU",
            "YENİMAHALLE",
            "BAKIRKÖY",
            "ATAKÖY",
            "YEŞİLYURT",
            "YEŞİLKÖY",
            "FLORYA AKVARYUM",
            "FLORYA",
            "KÜÇÜKÇEKMECE",
            "MUSTAFA KEMAL",
            "HALKALI"});
            this.comboBox1.Location = new System.Drawing.Point(529, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(275, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(110, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 38);
            this.label2.TabIndex = 23;
            this.label2.Text = "VARIŞ NOKTASI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(110, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "KALKIŞ NOKTASI:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(984, 590);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 34;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(269, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 32);
            this.label8.TabIndex = 35;
            this.label8.Text = "label8";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(908, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 71);
            this.button2.TabIndex = 36;
            this.button2.Text = "BİLET AL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(1598, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 38);
            this.label7.TabIndex = 37;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1199, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 38;
            this.label9.Text = "label9";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(1108, 590);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer2.TabIndex = 39;
            this.axWindowsMediaPlayer2.Enter += new System.EventHandler(this.axWindowsMediaPlayer2_Enter);
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(1222, 590);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer3.TabIndex = 40;
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // axWindowsMediaPlayer4
            // 
            this.axWindowsMediaPlayer4.Enabled = true;
            this.axWindowsMediaPlayer4.Location = new System.Drawing.Point(886, 590);
            this.axWindowsMediaPlayer4.Name = "axWindowsMediaPlayer4";
            this.axWindowsMediaPlayer4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer4.OcxState")));
            this.axWindowsMediaPlayer4.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer4.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1760, 693);
            this.Controls.Add(this.axWindowsMediaPlayer4);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "e";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.Timer timer4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer4;
    }
}

