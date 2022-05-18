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
using ZedGraph;


namespace Thuchanh
{
    public partial class HistogramGray : Form
    {
        public HistogramGray()
        {
            InitializeComponent();
        }

        Mat img = new Mat(), img_gray = new Mat();
       
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            pictureBox1.Image = null;

        }

        double[] histogram;
        void HistogramCal(Mat img_gray)
        {
            double[] histogr = new double[256];
            for (int i = 0; i < img_gray.Width; i++)
            {
                for (int j = 0; j < img_gray.Height; j++)
                {
                    Color color = img_gray.ToBitmap().GetPixel(i, j);
                    byte gray = color.R;
                    histogr[gray]++;
                }
            }
            histogram = histogr;
        }
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);
            pictureBox1.Image = img_gray.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;   
            
            HistogramCal(img_gray);
            PointPairList points = ConvertHistogram(histogram);
            zGHistogram.GraphPane = HistogramGraph(points);
            zGHistogram.Refresh();
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

        private void buttonShow_Click(object sender, EventArgs e)
        {
            img = Cv2.ImRead(textBox1.Text);
            pictureBox.Image = img.ToBitmap();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        
        PointPairList ConvertHistogram(double[] histogram)
        {
            PointPairList points = new PointPairList(); 
            for(int i = 0; i < histogram.Length; i++)
            {
                points.Add(i, histogram[i]);
            }
            return points;
        }
        public GraphPane HistogramGraph(PointPairList histogram)
        {
            GraphPane graphPane = new GraphPane();
            graphPane.Title.Text = @"Biểu đồ Histogram";
            graphPane.Rect = new Rectangle(0, 0, 700, 500);

            //Truc ngang
            graphPane.XAxis.Title.Text = @"Giá trị mức xám của các điểm ảnh";
            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = 255;
            graphPane.XAxis.Scale.MajorStep = 5;
            graphPane.XAxis.Scale.MinorStep = 1;

            //Truc dung
            graphPane.YAxis.Title.Text = @"Số điểm ảnh có cùng mức xám";
            graphPane.YAxis.Scale.Min = 0;
            graphPane.YAxis.Scale.Max = 15000;
            graphPane.YAxis.Scale.MajorStep = 5;
            graphPane.YAxis.Scale.MinorStep = 1;

            graphPane.AddBar("Histogram", histogram, Color.OrangeRed);
            return graphPane;
        }
    }
}