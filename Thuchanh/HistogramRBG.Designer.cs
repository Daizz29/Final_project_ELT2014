namespace Thuchanh
{
    partial class HistogramRBG
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RBGHistogram = new ZedGraph.ZedGraphControl();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(32, 105);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(139, 68);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "Open file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 44);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "C:\\Users\\ADMIN\\Desktop\\lemon.jpg";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RBGHistogram
            // 
            this.RBGHistogram.IsAntiAlias = true;
            this.RBGHistogram.Location = new System.Drawing.Point(480, 28);
            this.RBGHistogram.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.RBGHistogram.Name = "RBGHistogram";
            this.RBGHistogram.ScrollGrace = 0D;
            this.RBGHistogram.ScrollMaxX = 0D;
            this.RBGHistogram.ScrollMaxY = 0D;
            this.RBGHistogram.ScrollMaxY2 = 0D;
            this.RBGHistogram.ScrollMinX = 0D;
            this.RBGHistogram.ScrollMinY = 0D;
            this.RBGHistogram.ScrollMinY2 = 0D;
            this.RBGHistogram.Size = new System.Drawing.Size(769, 665);
            this.RBGHistogram.TabIndex = 39;
            this.RBGHistogram.UseExtendedPrintDialog = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(32, 235);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(428, 337);
            this.pictureBox.TabIndex = 40;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 626);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 67);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete Image";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(321, 105);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(139, 68);
            this.btnShow.TabIndex = 41;
            this.btnShow.Text = "Show Image";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // HistogramRBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1275, 727);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.RBGHistogram);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.textBox1);
            this.Name = "HistogramRBG";
            this.Text = "HistogramRBG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpen;
        private TextBox textBox1;
        private ZedGraph.ZedGraphControl RBGHistogram;
        private PictureBox pictureBox;
        private Button btnDelete;
        private Button btnShow;
    }
}