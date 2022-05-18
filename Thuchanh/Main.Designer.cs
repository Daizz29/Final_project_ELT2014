namespace Thuchanh
{
    partial class Main
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
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.buttonBar = new System.Windows.Forms.Button();
            this.buttonQR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonFilter.Location = new System.Drawing.Point(152, 26);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(359, 69);
            this.buttonFilter.TabIndex = 0;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonCrop
            // 
            this.buttonCrop.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrop.Location = new System.Drawing.Point(152, 125);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(359, 79);
            this.buttonCrop.TabIndex = 1;
            this.buttonCrop.Text = "Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // buttonBar
            // 
            this.buttonBar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBar.Location = new System.Drawing.Point(152, 237);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.Size = new System.Drawing.Size(359, 73);
            this.buttonBar.TabIndex = 2;
            this.buttonBar.Text = "Bar Code";
            this.buttonBar.UseVisualStyleBackColor = true;
            this.buttonBar.Click += new System.EventHandler(this.buttonBarCode_Click);
            // 
            // buttonQR
            // 
            this.buttonQR.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQR.Location = new System.Drawing.Point(152, 340);
            this.buttonQR.Name = "buttonQR";
            this.buttonQR.Size = new System.Drawing.Size(359, 83);
            this.buttonQR.TabIndex = 3;
            this.buttonQR.Text = "QR Code";
            this.buttonQR.UseVisualStyleBackColor = true;
            this.buttonQR.Click += new System.EventHandler(this.buttonQRCode_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(152, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 77);
            this.button1.TabIndex = 4;
            this.button1.Text = "Histogram";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonHistogram_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonQR);
            this.Controls.Add(this.buttonBar);
            this.Controls.Add(this.buttonCrop);
            this.Controls.Add(this.buttonFilter);
            this.Name = "Main";
            this.Text = "Filter";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonFilter;
        private Button buttonCrop;
        private Button buttonBar;
        private Button buttonQR;
        private Button button1;
    }
}