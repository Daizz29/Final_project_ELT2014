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
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
        }

        private void btnHisGray_Click(object sender, EventArgs e)
        {
            HistogramGray histogramGray = new HistogramGray();
            histogramGray.Show();
        }

        private void btnHisRGB_Click(object sender, EventArgs e)
        {
            HistogramRBG histogramRBG = new HistogramRBG();
            histogramRBG.Show();
        }
    }
}
