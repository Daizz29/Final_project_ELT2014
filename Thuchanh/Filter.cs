using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Windows.Compatibility;

namespace Thuchanh
{
    public partial class Filter : Form
    {
        private System.Windows.Forms.TrackBar? trackBar = null;
        public Filter()
        {
            InitializeComponent();
            radioButtonR.Enabled = false;
            radioButtonG.Enabled = false;
            radioButtonB.Enabled = false;
            radioButtonRGB.Enabled = false;
        }
        float gma = 0;
        Mat b = new Mat(), g = new Mat(), r = new Mat(), img = new Mat();
        Mat img_gray = new Mat();

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            float value1 = 0.4f;
            gma = value1 * trackBar1.Value / 10;
            if (gma == 0)
                gma = 0.1f;
            Bitmap bm = img.ToBitmap();
            Graphics g = Graphics.FromImage(bm);
            ImageAttributes ia = new ImageAttributes();
            ia.SetGamma(gma);
            Bitmap newBitmap = img.ToBitmap();
            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            ia.Dispose();
            pictureBox.Image = bm;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void radioButtonG_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = g.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void radioButtonR_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = r.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = b.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void radioButtonRGB_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = img.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Mat img_adjust = new Mat();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox.Image = img.ToBitmap();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);
            pictureBox1.Image = img_gray.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox1.Image = null;

        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            Mat[] img_splt = new Mat[3];
            img_splt = Cv2.Split(img);
            b = img_splt[0];
            g = img_splt[1];
            r = img_splt[2];
            radioButtonR.Enabled = true;
            radioButtonB.Enabled = true;
            radioButtonG.Enabled = true;
            radioButtonRGB.Enabled = true;
            MessageBox.Show("Successful!");

        }

        private void buttonSobel_Click(object sender, EventArgs e)
        {
            Mat img_graySobel = new Mat();
            Cv2.CvtColor(img, img_graySobel, ColorConversionCodes.BGR2GRAY);
            Mat img_sobel = new Mat(), grad_x = new Mat(), grad_y = new Mat();
            Mat abs_grad_x = new Mat(), abs_grad_y = new Mat();
            Cv2.Sobel(img_graySobel, grad_x, MatType.CV_16U, 1, 0, 3);
            Cv2.ConvertScaleAbs(grad_x, abs_grad_x);
            Cv2.Sobel(img_graySobel, grad_y, MatType.CV_16U, 0, 1, 3);
            Cv2.ConvertScaleAbs(grad_y, abs_grad_y);
            Cv2.AddWeighted(abs_grad_x, 0.5, abs_grad_y, 0.5, 0, img_sobel);
            pictureBox1.Image = img_sobel.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }


        private void buttonGause_Click(object sender, EventArgs e)
        {
            Mat img_grayGauss = new Mat();
            Cv2.CvtColor(img, img_grayGauss, ColorConversionCodes.BGR2GRAY);
            Mat img_gauss = new Mat();
            Cv2.GaussianBlur(img_grayGauss, img_gauss, new OpenCvSharp.Size(3, 3), 1.5);
            pictureBox1.Image = img_gauss.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.FileName;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sf.FileName);
            }
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            Mat im_grayMedian = new Mat();
            Cv2.CvtColor(img, im_grayMedian, ColorConversionCodes.BGR2GRAY);
            Mat im_Median = new Mat();
            Cv2.MedianBlur(im_grayMedian, im_Median, 11);
            pictureBox1.Image = im_Median.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }


    }
}
