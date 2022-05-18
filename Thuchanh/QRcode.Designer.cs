namespace Thuchanh
{
    partial class QRcode
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
            this.QRdecodeImg = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.QRImage = new System.Windows.Forms.PictureBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.SaveQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QRdecodeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRImage)).BeginInit();
            this.SuspendLayout();
            // 
            // QRdecodeImg
            // 
            this.QRdecodeImg.BackColor = System.Drawing.Color.LightGray;
            this.QRdecodeImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRdecodeImg.Location = new System.Drawing.Point(499, 25);
            this.QRdecodeImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QRdecodeImg.Name = "QRdecodeImg";
            this.QRdecodeImg.Size = new System.Drawing.Size(416, 369);
            this.QRdecodeImg.TabIndex = 12;
            this.QRdecodeImg.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 533);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(671, 82);
            this.textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 428);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(671, 77);
            this.textBox3.TabIndex = 10;
            // 
            // QRImage
            // 
            this.QRImage.BackColor = System.Drawing.Color.LightGray;
            this.QRImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRImage.Location = new System.Drawing.Point(35, 25);
            this.QRImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QRImage.Name = "QRImage";
            this.QRImage.Size = new System.Drawing.Size(410, 369);
            this.QRImage.TabIndex = 9;
            this.QRImage.TabStop = false;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(36, 428);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(141, 80);
            this.btnDecode.TabIndex = 8;
            this.btnDecode.Text = "Decode QR Code";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(36, 533);
            this.btnGenerateQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(141, 88);
            this.btnGenerateQR.TabIndex = 7;
            this.btnGenerateQR.Text = "Generate QR Code";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // SaveQR
            // 
            this.SaveQR.Location = new System.Drawing.Point(388, 641);
            this.SaveQR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveQR.Name = "SaveQR";
            this.SaveQR.Size = new System.Drawing.Size(156, 73);
            this.SaveQR.TabIndex = 13;
            this.SaveQR.Text = "Save";
            this.SaveQR.UseVisualStyleBackColor = true;
            this.SaveQR.Click += new System.EventHandler(this.SaveQR_Click);
            // 
            // QRcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(955, 726);
            this.Controls.Add(this.SaveQR);
            this.Controls.Add(this.QRdecodeImg);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.QRImage);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnGenerateQR);
            this.Name = "QRcode";
            this.Text = "QRcode";
            ((System.ComponentModel.ISupportInitialize)(this.QRdecodeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox QRdecodeImg;
        private TextBox textBox4;
        private TextBox textBox3;
        private PictureBox QRImage;
        private Button btnDecode;
        private Button btnGenerateQR;
        private Button SaveQR;
    }
}