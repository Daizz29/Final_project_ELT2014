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
    public partial class HistogramRBG : Form
    {
       
        public HistogramRBG()
        {
            InitializeComponent();           
        }
        public static Bitmap MatToBitmap(Mat image)
        {
            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(image);
        }

        Mat img = new Mat();
        Bitmap bmp;
        public double[,] HistogramCal(Bitmap bmp)
        {
            //3 kenh mau: R,G,B
            bmp = MatToBitmap(img);
            double[,] histogr = new double[3, 256];          
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    byte r = color.R;
                    byte g = color.G;
                    byte b = color.B;
                    histogr[0, r]++; //histogram cua kenh mau R
                    histogr[1, g]++; //histogram cua kenh mau G
                    histogr[2, b]++; //histogram cua kenh mau B
                }
            }
            return histogr;
        }
       
        private void pictureBox_Click(object sender, EventArgs e)
        {

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
            double[,] histogram = HistogramCal(bmp);
            List<PointPairList> points = ConvertHistogram(histogram);
            RBGHistogram.GraphPane = HistogramGraph(points);
            RBGHistogram.Refresh();

        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;

        }

        List<PointPairList> ConvertHistogram(double[,] histogram)
        {
            List<PointPairList> points = new List<PointPairList>();
            PointPairList redPoints = new PointPairList();
            PointPairList greenPoints = new PointPairList();
            PointPairList bluePoints = new PointPairList();
            for (int i = 0; i < 256; i++)
            {
                redPoints.Add(i, histogram[0, i]);
                greenPoints.Add(i, histogram[1, i]);
                bluePoints.Add(i, histogram[2, i]);
            }
            points.Add(redPoints);
            points.Add(greenPoints);
            points.Add(bluePoints);
            return points;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public GraphPane HistogramGraph(List<PointPairList> histogram)
        {
            GraphPane graphPane = new GraphPane();
            graphPane.Title.Text = @"Biểu đồ Histogram";
            graphPane.Rect = new Rectangle(0, 0, 700, 500);

            //Truc ngang
            graphPane.XAxis.Title.Text = @"Giá trị màu của các điểm ảnh";
            graphPane.XAxis.Scale.Min = 0;
            graphPane.XAxis.Scale.Max = 255;
            graphPane.XAxis.Scale.MajorStep = 5;
            graphPane.XAxis.Scale.MinorStep = 1;

            //Truc dung
            graphPane.YAxis.Title.Text = @"Số điểm ảnh có cùng giá trị màu";
            graphPane.YAxis.Scale.Min = 0;
            graphPane.YAxis.Scale.Max = 15000;
            graphPane.YAxis.Scale.MajorStep = 5;
            graphPane.YAxis.Scale.MinorStep = 1;

            graphPane.AddBar("Histogram's Red", histogram[0], Color.Red);
            graphPane.AddBar("Histogram's Blue", histogram[2], Color.Blue);
            graphPane.AddBar("Histogram's Green", histogram[1], Color.Green);
            

            return graphPane;
        }
    } 
}
