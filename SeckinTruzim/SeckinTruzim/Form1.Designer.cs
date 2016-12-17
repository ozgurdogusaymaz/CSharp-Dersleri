namespace SeckinTruzim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelOtobuSec = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.panelTravego = new System.Windows.Forms.Panel();
            this.panelNeoplan = new System.Windows.Forms.Panel();
            this.GBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.labelOtobusTuru = new System.Windows.Forms.Label();
            this.labelKoltukNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GboxCinsiyet = new System.Windows.Forms.GroupBox();
            this.CBoxErkek = new System.Windows.Forms.CheckBox();
            this.CBoxKadin = new System.Windows.Forms.CheckBox();
            this.TxtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.labelAdSoyad = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBoxMusteriBilgileri.SuspendLayout();
            this.GboxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOtobuSec
            // 
            this.labelOtobuSec.AutoSize = true;
            this.labelOtobuSec.Location = new System.Drawing.Point(123, 203);
            this.labelOtobuSec.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOtobuSec.Name = "labelOtobuSec";
            this.labelOtobuSec.Size = new System.Drawing.Size(133, 19);
            this.labelOtobuSec.TabIndex = 0;
            this.labelOtobuSec.Text = "Otobüs  Seçiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Neoplan"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(91, 244);
            this.CBoxOtobusTuru.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(199, 27);
            this.CBoxOtobusTuru.TabIndex = 3;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // panelTravego
            // 
            this.panelTravego.Location = new System.Drawing.Point(394, 12);
            this.panelTravego.Name = "panelTravego";
            this.panelTravego.Size = new System.Drawing.Size(262, 508);
            this.panelTravego.TabIndex = 4;
            // 
            // panelNeoplan
            // 
            this.panelNeoplan.Location = new System.Drawing.Point(391, 12);
            this.panelNeoplan.Name = "panelNeoplan";
            this.panelNeoplan.Size = new System.Drawing.Size(265, 622);
            this.panelNeoplan.TabIndex = 5;
            // 
            // GBoxMusteriBilgileri
            // 
            this.GBoxMusteriBilgileri.Controls.Add(this.BtnKaydet);
            this.GBoxMusteriBilgileri.Controls.Add(this.labelOtobusTuru);
            this.GBoxMusteriBilgileri.Controls.Add(this.labelKoltukNo);
            this.GBoxMusteriBilgileri.Controls.Add(this.label2);
            this.GBoxMusteriBilgileri.Controls.Add(this.label1);
            this.GBoxMusteriBilgileri.Controls.Add(this.GboxCinsiyet);
            this.GBoxMusteriBilgileri.Controls.Add(this.TxtMusteriAdSoyad);
            this.GBoxMusteriBilgileri.Controls.Add(this.labelAdSoyad);
            this.GBoxMusteriBilgileri.Location = new System.Drawing.Point(698, 13);
            this.GBoxMusteriBilgileri.Name = "GBoxMusteriBilgileri";
            this.GBoxMusteriBilgileri.Size = new System.Drawing.Size(345, 323);
            this.GBoxMusteriBilgileri.TabIndex = 6;
            this.GBoxMusteriBilgileri.TabStop = false;
            this.GBoxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // labelOtobusTuru
            // 
            this.labelOtobusTuru.AutoSize = true;
            this.labelOtobusTuru.Location = new System.Drawing.Point(144, 222);
            this.labelOtobusTuru.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelOtobusTuru.Name = "labelOtobusTuru";
            this.labelOtobusTuru.Size = new System.Drawing.Size(19, 19);
            this.labelOtobusTuru.TabIndex = 10;
            this.labelOtobusTuru.Text = "0";
            // 
            // labelKoltukNo
            // 
            this.labelKoltukNo.AutoSize = true;
            this.labelKoltukNo.Location = new System.Drawing.Point(144, 190);
            this.labelKoltukNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelKoltukNo.Name = "labelKoltukNo";
            this.labelKoltukNo.Size = new System.Drawing.Size(19, 19);
            this.labelKoltukNo.TabIndex = 9;
            this.labelKoltukNo.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Otobüs Türü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Koltuk No:";
            // 
            // GboxCinsiyet
            // 
            this.GboxCinsiyet.Controls.Add(this.CBoxErkek);
            this.GboxCinsiyet.Controls.Add(this.CBoxKadin);
            this.GboxCinsiyet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GboxCinsiyet.Location = new System.Drawing.Point(12, 73);
            this.GboxCinsiyet.Name = "GboxCinsiyet";
            this.GboxCinsiyet.Size = new System.Drawing.Size(294, 100);
            this.GboxCinsiyet.TabIndex = 3;
            this.GboxCinsiyet.TabStop = false;
            this.GboxCinsiyet.Text = "Cinsiyet";
            // 
            // CBoxErkek
            // 
            this.CBoxErkek.AutoSize = true;
            this.CBoxErkek.Location = new System.Drawing.Point(166, 46);
            this.CBoxErkek.Name = "CBoxErkek";
            this.CBoxErkek.Size = new System.Drawing.Size(75, 23);
            this.CBoxErkek.TabIndex = 1;
            this.CBoxErkek.Text = "Erkek";
            this.CBoxErkek.UseVisualStyleBackColor = true;
            // 
            // CBoxKadin
            // 
            this.CBoxKadin.AutoSize = true;
            this.CBoxKadin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBoxKadin.Location = new System.Drawing.Point(26, 46);
            this.CBoxKadin.Name = "CBoxKadin";
            this.CBoxKadin.Size = new System.Drawing.Size(74, 23);
            this.CBoxKadin.TabIndex = 0;
            this.CBoxKadin.Text = "Kadın";
            this.CBoxKadin.UseVisualStyleBackColor = true;
            // 
            // TxtMusteriAdSoyad
            // 
            this.TxtMusteriAdSoyad.Location = new System.Drawing.Point(117, 31);
            this.TxtMusteriAdSoyad.Name = "TxtMusteriAdSoyad";
            this.TxtMusteriAdSoyad.Size = new System.Drawing.Size(189, 27);
            this.TxtMusteriAdSoyad.TabIndex = 2;
            // 
            // labelAdSoyad
            // 
            this.labelAdSoyad.AutoSize = true;
            this.labelAdSoyad.Location = new System.Drawing.Point(8, 34);
            this.labelAdSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAdSoyad.Name = "labelAdSoyad";
            this.labelAdSoyad.Size = new System.Drawing.Size(101, 19);
            this.labelAdSoyad.TabIndex = 1;
            this.labelAdSoyad.Text = "Adı Soyadı:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.White;
            this.BtnKaydet.Location = new System.Drawing.Point(117, 266);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(128, 51);
            this.BtnKaydet.TabIndex = 11;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 670);
            this.Controls.Add(this.panelNeoplan);
            this.Controls.Add(this.GBoxMusteriBilgileri);
            this.Controls.Add(this.panelTravego);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelOtobuSec);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBoxMusteriBilgileri.ResumeLayout(false);
            this.GBoxMusteriBilgileri.PerformLayout();
            this.GboxCinsiyet.ResumeLayout(false);
            this.GboxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOtobuSec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Panel panelTravego;
        private System.Windows.Forms.Panel panelNeoplan;
        private System.Windows.Forms.GroupBox GBoxMusteriBilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GboxCinsiyet;
        private System.Windows.Forms.TextBox TxtMusteriAdSoyad;
        private System.Windows.Forms.Label labelAdSoyad;
        private System.Windows.Forms.Label labelOtobusTuru;
        private System.Windows.Forms.Label labelKoltukNo;
        private System.Windows.Forms.CheckBox CBoxErkek;
        private System.Windows.Forms.CheckBox CBoxKadin;
        private System.Windows.Forms.Button BtnKaydet;
    }
}

