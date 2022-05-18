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
    public partial class QRcode : Form
    {
        public QRcode()
        {
            InitializeComponent();
        }
        Mat img2 = new Mat();


        private void btnDecode_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    QRdecodeImg.Image = Image.FromFile(ofd.FileName);
                    MessagingToolkit.QRCode.Codec.QRCodeDecoder decoder = new MessagingToolkit.QRCode.Codec.QRCodeDecoder();
                    textBox3.Text = decoder.Decode(new MessagingToolkit.QRCode.Codec.Data.QRCodeBitmapImage(QRdecodeImg.Image as Bitmap));
                }
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encoder.QRCodeScale = 8;
            Bitmap bmp = encoder.Encode(textBox4.Text);
            QRImage.Image = bmp;
        }
        private void SaveQR_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "JPEG|*.jpg";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                QRImage.Image.Save(savefile.FileName);
            }
        }
    }  
}
