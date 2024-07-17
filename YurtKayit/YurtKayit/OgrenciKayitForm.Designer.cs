namespace YurtKayit
{
    partial class OgrenciKayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciKayitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskDogumTrh = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbBolum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbOdaNo = new System.Windows.Forms.ComboBox();
            this.TxtVeliAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MskVeliTel = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RtxVeli = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtAd.Location = new System.Drawing.Point(159, 26);
            this.TxtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(220, 28);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtSoyad.Location = new System.Drawing.Point(159, 60);
            this.TxtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(220, 28);
            this.TxtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tc Kimlik No:";
            // 
            // MskTc
            // 
            this.MskTc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MskTc.Location = new System.Drawing.Point(159, 94);
            this.MskTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(220, 28);
            this.MskTc.TabIndex = 5;
            this.MskTc.ValidatingType = typeof(int);
            this.MskTc.Click += new System.EventHandler(this.MskTc_Click);
            // 
            // MskTel
            // 
            this.MskTel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MskTel.Location = new System.Drawing.Point(159, 128);
            this.MskTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskTel.Mask = "0000000000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(220, 28);
            this.MskTel.TabIndex = 7;
            this.MskTel.ValidatingType = typeof(int);
            this.MskTel.Click += new System.EventHandler(this.MskTel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(69, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefon:";
            // 
            // MskDogumTrh
            // 
            this.MskDogumTrh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskDogumTrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MskDogumTrh.Location = new System.Drawing.Point(159, 162);
            this.MskDogumTrh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskDogumTrh.Mask = "00/00/0000";
            this.MskDogumTrh.Name = "MskDogumTrh";
            this.MskDogumTrh.Size = new System.Drawing.Size(220, 28);
            this.MskDogumTrh.TabIndex = 9;
            this.MskDogumTrh.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(80, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bölüm:";
            // 
            // CmbBolum
            // 
            this.CmbBolum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmbBolum.FormattingEnabled = true;
            this.CmbBolum.Location = new System.Drawing.Point(159, 196);
            this.CmbBolum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbBolum.Name = "CmbBolum";
            this.CmbBolum.Size = new System.Drawing.Size(220, 30);
            this.CmbBolum.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(80, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-mail:";
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtMail.Location = new System.Drawing.Point(159, 230);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(220, 28);
            this.TxtMail.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(68, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Oda No:";
            // 
            // CmbOdaNo
            // 
            this.CmbOdaNo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CmbOdaNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmbOdaNo.FormattingEnabled = true;
            this.CmbOdaNo.Location = new System.Drawing.Point(159, 264);
            this.CmbOdaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbOdaNo.Name = "CmbOdaNo";
            this.CmbOdaNo.Size = new System.Drawing.Size(220, 30);
            this.CmbOdaNo.TabIndex = 15;
            // 
            // TxtVeliAdSoyad
            // 
            this.TxtVeliAdSoyad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtVeliAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtVeliAdSoyad.Location = new System.Drawing.Point(159, 298);
            this.TxtVeliAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtVeliAdSoyad.Name = "TxtVeliAdSoyad";
            this.TxtVeliAdSoyad.Size = new System.Drawing.Size(220, 28);
            this.TxtVeliAdSoyad.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label10.Location = new System.Drawing.Point(15, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Veli Ad Soyad:";
            // 
            // MskVeliTel
            // 
            this.MskVeliTel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MskVeliTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MskVeliTel.Location = new System.Drawing.Point(159, 332);
            this.MskVeliTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MskVeliTel.Mask = "0000000000";
            this.MskVeliTel.Name = "MskVeliTel";
            this.MskVeliTel.Size = new System.Drawing.Size(220, 28);
            this.MskVeliTel.TabIndex = 19;
            this.MskVeliTel.ValidatingType = typeof(int);
            this.MskVeliTel.Click += new System.EventHandler(this.MskVeliTel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(32, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label11.Location = new System.Drawing.Point(47, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Veli Adres:";
            // 
            // RtxVeli
            // 
            this.RtxVeli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RtxVeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RtxVeli.Location = new System.Drawing.Point(159, 366);
            this.RtxVeli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RtxVeli.Name = "RtxVeli";
            this.RtxVeli.Size = new System.Drawing.Size(220, 96);
            this.RtxVeli.TabIndex = 21;
            this.RtxVeli.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn1.Image = global::YurtKayit.Properties.Resources.icons8_save_button_48;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1.Location = new System.Drawing.Point(195, 476);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(135, 59);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "Kaydet";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // OgrenciKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(488, 546);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.RtxVeli);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MskVeliTel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtVeliAdSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskDogumTrh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OgrenciKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskDogumTrh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbBolum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbOdaNo;
        private System.Windows.Forms.TextBox TxtVeliAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskVeliTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox RtxVeli;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label12;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

