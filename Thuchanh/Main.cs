using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thuchanh
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter formFilter = new Filter();
            formFilter.Show();

        }
        private void buttonCrop_Click(object sender, EventArgs e)
        {
            CropImage formCropImage = new CropImage();
            formCropImage.Show();
        }

        private void buttonQRCode_Click(object sender, EventArgs e)
        {
            QRcode formQRcode = new QRcode();   
            formQRcode.Show();
        }

        private void buttonBarCode_Click(object sender, EventArgs e)
        {

        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            Histogram formHistogram = new Histogram();  
            formHistogram.Show();
        }
    }
}
