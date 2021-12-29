namespace ExampleApp
{
    // p32:连接到带统计标签的组件
    public partial class Form4p32 : Form
    {
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> imgCC;

        CCStatsOp[] statop;
        MCvPoint2D64f[] centroidPoints;

        public struct CCStatsOp
        {
            public Rectangle Rectangle;
            public int Area;
        }

        public Form4p32()
        {
            InitializeComponent();
        }

        private void Form4p32_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
            imgCC?.Dispose();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog ofd = new();
                ofd.Filter = "图像(*.jpg,*.jpeg)|*.jpeg;*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new(ofd.FileName);
                    pictureBox1.Image = imgInput.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }

            try
            {
                var temp = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255)).Dilate(1).Erode(1);

                using var imgLabel = new Mat();
                using var stats = new Mat();
                using var centroids = new Mat();

                int labels = CvInvoke.ConnectedComponentsWithStats(temp, imgLabel, stats, centroids);

                imgCC = imgLabel.ToImage<Gray, byte>();

                centroidPoints = new MCvPoint2D64f[labels];
                centroids.CopyTo(centroidPoints);

                statop = new CCStatsOp[labels];
                stats.CopyTo(statop);

                pictureBox2.Image = temp.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (imgCC == null)
            {
                return;
            }

            try
            {
                if (e.X > imgCC.Cols || e.Y > imgCC.Rows)
                {
                    return;
                }
                int label = (int)imgCC[e.Y, e.X].Intensity;
                if (label != 0)
                {
                    var temp = imgCC.InRange(new Gray(label), new Gray(label));

                    int x = (int)centroidPoints[label].X;
                    int y = (int)centroidPoints[label].Y;

                    using var t = imgInput.Copy();
                    CvInvoke.PutText(t, "o", new Point(x, y), FontFace.HersheyPlain,0.8,new MCvScalar(0,0,255),2);

                    Rectangle rect = statop[label].Rectangle;
                    t.Draw(rect, new Bgr(0, 0, 255), 2);

                    label1.Text = statop[label].Area.ToString();

                    pictureBox1.Image = t.AsBitmap();
                    pictureBox2.Image = temp.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
