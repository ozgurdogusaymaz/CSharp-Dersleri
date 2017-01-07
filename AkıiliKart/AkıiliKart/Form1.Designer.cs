namespace AkıiliKart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnTam = new System.Windows.Forms.RadioButton();
            this.radioBtnOgrenci = new System.Windows.Forms.RadioButton();
            this.radioBtnOgretmen = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.labelBakiye = new System.Windows.Forms.Label();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.GBoxOkuladi = new System.Windows.Forms.GroupBox();
            this.TxtOkulAdi = new System.Windows.Forms.TextBox();
            this.lstBoxYolcular = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.GBoxOkuladi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBoxYolcular);
            this.groupBox1.Controls.Add(this.GBoxOkuladi);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.TxtBakiye);
            this.groupBox1.Controls.Add(this.radioBtnOgretmen);
            this.groupBox1.Controls.Add(this.labelBakiye);
            this.groupBox1.Controls.Add(this.radioBtnOgrenci);
            this.groupBox1.Controls.Add(this.radioBtnTam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(79, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluştur";
            // 
            // radioBtnTam
            // 
            this.radioBtnTam.AutoSize = true;
            this.radioBtnTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnTam.Location = new System.Drawing.Point(29, 42);
            this.radioBtnTam.Name = "radioBtnTam";
            this.radioBtnTam.Size = new System.Drawing.Size(57, 20);
            this.radioBtnTam.TabIndex = 1;
            this.radioBtnTam.TabStop = true;
            this.radioBtnTam.Text = "Tam";
            this.radioBtnTam.UseVisualStyleBackColor = true;
            // 
            // radioBtnOgrenci
            // 
            this.radioBtnOgrenci.AutoSize = true;
            this.radioBtnOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnOgrenci.Location = new System.Drawing.Point(29, 68);
            this.radioBtnOgrenci.Name = "radioBtnOgrenci";
            this.radioBtnOgrenci.Size = new System.Drawing.Size(80, 20);
            this.radioBtnOgrenci.TabIndex = 2;
            this.radioBtnOgrenci.TabStop = true;
            this.radioBtnOgrenci.Text = "Ögrenci";
            this.radioBtnOgrenci.UseVisualStyleBackColor = true;
            // 
            // radioBtnOgretmen
            // 
            this.radioBtnOgretmen.AutoSize = true;
            this.radioBtnOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnOgretmen.Location = new System.Drawing.Point(29, 94);
            this.radioBtnOgretmen.Name = "radioBtnOgretmen";
            this.radioBtnOgretmen.Size = new System.Drawing.Size(93, 20);
            this.radioBtnOgretmen.TabIndex = 3;
            this.radioBtnOgretmen.TabStop = true;
            this.radioBtnOgretmen.Text = "Ögretmen";
            this.radioBtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(29, 140);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // labelBakiye
            // 
            this.labelBakiye.AutoSize = true;
            this.labelBakiye.Location = new System.Drawing.Point(199, 18);
            this.labelBakiye.Name = "labelBakiye";
            this.labelBakiye.Size = new System.Drawing.Size(56, 16);
            this.labelBakiye.TabIndex = 0;
            this.labelBakiye.Text = "Bakiye";
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(190, 37);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(113, 22);
            this.TxtBakiye.TabIndex = 1;
            // 
            // GBoxOkuladi
            // 
            this.GBoxOkuladi.Controls.Add(this.TxtOkulAdi);
            this.GBoxOkuladi.Location = new System.Drawing.Point(190, 70);
            this.GBoxOkuladi.Name = "GBoxOkuladi";
            this.GBoxOkuladi.Size = new System.Drawing.Size(200, 100);
            this.GBoxOkuladi.TabIndex = 5;
            this.GBoxOkuladi.TabStop = false;
            this.GBoxOkuladi.Text = "Oku Adı";
            // 
            // TxtOkulAdi
            // 
            this.TxtOkulAdi.Location = new System.Drawing.Point(12, 36);
            this.TxtOkulAdi.Name = "TxtOkulAdi";
            this.TxtOkulAdi.Size = new System.Drawing.Size(170, 22);
            this.TxtOkulAdi.TabIndex = 6;
            // 
            // lstBoxYolcular
            // 
            this.lstBoxYolcular.FormattingEnabled = true;
            this.lstBoxYolcular.ItemHeight = 16;
            this.lstBoxYolcular.Location = new System.Drawing.Point(29, 190);
            this.lstBoxYolcular.Name = "lstBoxYolcular";
            this.lstBoxYolcular.Size = new System.Drawing.Size(375, 196);
            this.lstBoxYolcular.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 564);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBoxOkuladi.ResumeLayout(false);
            this.GBoxOkuladi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBoxYolcular;
        private System.Windows.Forms.GroupBox GBoxOkuladi;
        private System.Windows.Forms.TextBox TxtOkulAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox TxtBakiye;
        private System.Windows.Forms.RadioButton radioBtnOgretmen;
        private System.Windows.Forms.Label labelBakiye;
        private System.Windows.Forms.RadioButton radioBtnOgrenci;
        private System.Windows.Forms.RadioButton radioBtnTam;
    }
}

