namespace Zar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zarBtn = new System.Windows.Forms.Button();
            this.zarPic1 = new System.Windows.Forms.PictureBox();
            this.zarPic2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zarPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarPic2)).BeginInit();
            this.SuspendLayout();
            // 
            // zarBtn
            // 
            this.zarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.zarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zarBtn.Location = new System.Drawing.Point(148, 304);
            this.zarBtn.Name = "zarBtn";
            this.zarBtn.Size = new System.Drawing.Size(166, 79);
            this.zarBtn.TabIndex = 0;
            this.zarBtn.Text = "Zar At";
            this.zarBtn.UseVisualStyleBackColor = false;
            this.zarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // zarPic1
            // 
            this.zarPic1.Location = new System.Drawing.Point(31, 87);
            this.zarPic1.Name = "zarPic1";
            this.zarPic1.Size = new System.Drawing.Size(156, 133);
            this.zarPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zarPic1.TabIndex = 1;
            this.zarPic1.TabStop = false;
            // 
            // zarPic2
            // 
            this.zarPic2.Location = new System.Drawing.Point(283, 87);
            this.zarPic2.Name = "zarPic2";
            this.zarPic2.Size = new System.Drawing.Size(146, 133);
            this.zarPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zarPic2.TabIndex = 2;
            this.zarPic2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "1.png");
            this.ımageList1.Images.SetKeyName(1, "2.png");
            this.ımageList1.Images.SetKeyName(2, "3.png");
            this.ımageList1.Images.SetKeyName(3, "4.png");
            this.ımageList1.Images.SetKeyName(4, "5.png");
            this.ımageList1.Images.SetKeyName(5, "6.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(497, 492);
            this.Controls.Add(this.zarPic2);
            this.Controls.Add(this.zarPic1);
            this.Controls.Add(this.zarBtn);
            this.Name = "Form1";
            this.Text = "Zar At";
            ((System.ComponentModel.ISupportInitialize)(this.zarPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zarPic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zarBtn;
        private System.Windows.Forms.PictureBox zarPic1;
        private System.Windows.Forms.PictureBox zarPic2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

