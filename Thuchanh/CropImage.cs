using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Windows.Compatibility;
using System.Windows.Forms;
namespace Thuchanh
{
    public partial class CropImage : Form
    {
        public CropImage()
        {
            InitializeComponent();
        }
        Mat img = new Mat();
        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox.Image = img.ToBitmap();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox1.Image = null;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
            pictureBox.MouseEnter += new EventHandler(pictureBox_MouseEnter);
            Controls.Add(pictureBox);

        }
        int crpX, crpY, rectW, rectH;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Pen crpPen = new Pen(Color.White);

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                crpX = e.X;
                crpY = e.Y;
            }
        }


        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }


        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox.Refresh();
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pictureBox.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }


        private void buttonCrop_Click(object sender, EventArgs e)
        {
            // label2.Text = "Dimensions :" + rectW + "," + rectH;
            Cursor = Cursors.Default;
            Bitmap bmp2 = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.DrawToBitmap(bmp2, pictureBox.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }
            pictureBox1.Image = (Image)crpImg;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

    }
}
