namespace RastgeleSayi
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
            this.sayiTxt = new System.Windows.Forms.Label();
            this.sayiuretBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sayiTxt
            // 
            this.sayiTxt.AutoSize = true;
            this.sayiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayiTxt.Location = new System.Drawing.Point(193, 99);
            this.sayiTxt.Name = "sayiTxt";
            this.sayiTxt.Size = new System.Drawing.Size(32, 24);
            this.sayiTxt.TabIndex = 0;
            this.sayiTxt.Text = "00";
            // 
            // sayiuretBtn
            // 
            this.sayiuretBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sayiuretBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayiuretBtn.Location = new System.Drawing.Point(137, 195);
            this.sayiuretBtn.Name = "sayiuretBtn";
            this.sayiuretBtn.Size = new System.Drawing.Size(133, 60);
            this.sayiuretBtn.TabIndex = 1;
            this.sayiuretBtn.Text = "Sayı Üret";
            this.sayiuretBtn.UseVisualStyleBackColor = false;
            this.sayiuretBtn.Click += new System.EventHandler(this.sayiuretBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(402, 359);
            this.Controls.Add(this.sayiuretBtn);
            this.Controls.Add(this.sayiTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayiTxt;
        private System.Windows.Forms.Button sayiuretBtn;
    }
}

