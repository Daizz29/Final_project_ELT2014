namespace Thuchanh
{
    partial class Filter
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMedian = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.radioButtonR = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonRGB = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnGause = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSobel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(68, 136);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(126, 63);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 61);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "C:\\Users\\ADMIN\\Desktop\\lemon.jpg";
            // 
            // btnMedian
            // 
            this.btnMedian.Location = new System.Drawing.Point(68, 531);
            this.btnMedian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(157, 87);
            this.btnMedian.TabIndex = 34;
            this.btnMedian.Text = "Median Filter";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Info;
            this.trackBar1.Location = new System.Drawing.Point(68, 54);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(424, 69);
            this.trackBar1.TabIndex = 33;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // radioButtonR
            // 
            this.radioButtonR.AutoSize = true;
            this.radioButtonR.Location = new System.Drawing.Point(95, 16);
            this.radioButtonR.Name = "radioButtonR";
            this.radioButtonR.Size = new System.Drawing.Size(48, 29);
            this.radioButtonR.TabIndex = 29;
            this.radioButtonR.TabStop = true;
            this.radioButtonR.Text = "R";
            this.radioButtonR.UseVisualStyleBackColor = true;
            this.radioButtonR.Click += new System.EventHandler(this.radioButtonR_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(529, 324);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(364, 263);
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(146, 16);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(49, 29);
            this.radioButtonG.TabIndex = 30;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "G";
            this.radioButtonG.UseVisualStyleBackColor = true;
            this.radioButtonG.Click += new System.EventHandler(this.radioButtonG_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(529, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 262);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(199, 16);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(47, 29);
            this.radioButtonB.TabIndex = 31;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.Click += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonRGB
            // 
            this.radioButtonRGB.AutoSize = true;
            this.radioButtonRGB.Location = new System.Drawing.Point(253, 16);
            this.radioButtonRGB.Name = "radioButtonRGB";
            this.radioButtonRGB.Size = new System.Drawing.Size(70, 29);
            this.radioButtonRGB.TabIndex = 32;
            this.radioButtonRGB.TabStop = true;
            this.radioButtonRGB.Text = "RGB";
            this.radioButtonRGB.UseVisualStyleBackColor = true;
            this.radioButtonRGB.Click += new System.EventHandler(this.radioButtonRGB_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(69, 218);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(156, 88);
            this.btnShow.TabIndex = 20;
            this.btnShow.Text = "Show Image";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // btnGause
            // 
            this.btnGause.Location = new System.Drawing.Point(252, 426);
            this.btnGause.Name = "btnGause";
            this.btnGause.Size = new System.Drawing.Size(163, 80);
            this.btnGause.TabIndex = 25;
            this.btnGause.Text = "Gauss Filter";
            this.btnGause.UseVisualStyleBackColor = true;
            this.btnGause.Click += new System.EventHandler(this.buttonGause_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(252, 218);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(161, 88);
            this.btnSplit.TabIndex = 22;
            this.btnSplit.Text = "Split Image";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(68, 426);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 80);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete Image";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(68, 324);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(157, 82);
            this.btnConvert.TabIndex = 21;
            this.btnConvert.Text = "Convert to Gray";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // btnSobel
            // 
            this.btnSobel.Location = new System.Drawing.Point(253, 324);
            this.btnSobel.Name = "btnSobel";
            this.btnSobel.Size = new System.Drawing.Size(161, 82);
            this.btnSobel.TabIndex = 23;
            this.btnSobel.Text = "Sobel";
            this.btnSobel.UseVisualStyleBackColor = true;
            this.btnSobel.Click += new System.EventHandler(this.buttonSobel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 531);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 82);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 635);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnMedian);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.radioButtonR);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.radioButtonG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonRGB);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnGause);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSobel);
            this.Name = "Filter";
            this.Text = "Filter";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpen;
        private TextBox textBox1;
        private Button btnMedian;
        private TrackBar trackBar1;
        private RadioButton radioButtonR;
        private PictureBox pictureBox;
        private RadioButton radioButtonG;
        private PictureBox pictureBox1;
        private RadioButton radioButtonB;
        private RadioButton radioButtonRGB;
        private Button btnShow;
        private Button btnGause;
        private Button btnSplit;
        private Button btnDelete;
        private Button btnConvert;
        private Button btnSobel;
        private Button btnSave;
    }
}