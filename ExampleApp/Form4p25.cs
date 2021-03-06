namespace ExampleApp
{
    // p25&26:在EmguCV 3.3中使用SVN进行数字识别
    public partial class Form4p25 : Form
    {
        static string ProjectPath = $"{Application.StartupPath}Digits";
        string TrainDataPath = $"{ProjectPath}\\mytrain.csv";
        string TestDataPath = $"{ProjectPath}\\mytest.csv";

        Matrix<float> TrainData;
        Matrix<float> TestData;
        Matrix<int> TrainLabel;
        Matrix<int> TestLabel;

        SVM svm;
        int Counter = 0;
        bool IsDisplayImage = false;

        public Form4p25()
        {
            InitializeComponent();
        }

        private void Form4p25_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrainData?.Dispose();
            TestData?.Dispose();
            TrainLabel?.Dispose();
            TestLabel?.Dispose();
            svm?.Dispose();
        }

        private void menuItemLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTrainData();
                LoadTestData();
                MessageBox.Show("数据加载成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemTrainSVM_Click(object sender, EventArgs e)
        {
            if (TrainData == null)
            {
                return;
            }

            try
            {
                if (File.Exists("svm.txt"))
                {
                    svm = new();
                    using FileStorage fileStorage = new("svm.txt", FileStorage.Mode.Read);
                    svm.Read(fileStorage.GetNode("opencv_ml_svm"));
                }
                else
                {
                    svm = new();
                    svm.C = 100;
                    svm.Type = SVM.SvmType.CSvc;
                    svm.Gamma = 0.005;
                    svm.TermCriteria = new(1000, 1e-6);
                    svm.Train(TrainData, Emgu.CV.ML.MlEnum.DataLayoutType.RowSample, TrainLabel);
                    svm.Save("svm.txt");
                }
                MessageBox.Show("SVM已训练！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void menuItemTestSVM_Click(object sender, EventArgs e)
        {
            if (TestData == null)
            {
                return;
            }

            if (svm == null)
            {
                return;
            }

            try
            {
                int counter = 0;
                for (int i = 0; i < TestData.Rows; i++)
                {
                    using Matrix<float> row = TestData.GetRow(i);
                    float predict = svm.Predict(row);
                    lblTest.Text = $"输入标签：{TestLabel[i, 0]}"; ;
                    lblOutputLabel.Text = $"预测标签：{predict}";
                    if (predict == TestData[i, 0])
                    {
                        counter++;
                    }

                    if (IsDisplayImage)
                    {
                        using var imgout = TestData.GetRow(Counter).Mat.Reshape(0, 29).ToImage<Gray, byte>();
                        pictureBox1.Image = imgout.AsBitmap();
                        await Task.Delay(10);
                    }
                    else
                    {
                        await Task.Delay(1);
                    }
                }

                lblAccuracy.Text = $"准确率：{(counter / (float)(TestData.Rows))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTrainData()
        {
            List<float[]> trainDatas = new();
            List<int> trainLabels = new();


            if (!File.Exists(TrainDataPath))
            {
                MessageBox.Show("找不到训练数据文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StreamReader reader = new(TrainDataPath);
            string line = "";
            while ((line = reader.ReadLine()!) != null)
            {
                int firstIndex = line.IndexOf(',');
                int currentLabel = Convert.ToInt32(line.Substring(0, firstIndex));
                string currentData = line.Substring(firstIndex + 1);
                float[] data = currentData.Split(',').Select(x => float.Parse(x)).ToArray();

                trainDatas.Add(data);
                trainLabels.Add(currentLabel);
            }

            TrainData = new(To2D<float>(trainDatas.ToArray()));
            TrainLabel = new(trainLabels.ToArray());
        }

        private void LoadTestData()
        {
            List<float[]> TestDatas = new();
            List<int> TestLabels = new();


            if (!File.Exists(TestDataPath))
            {
                MessageBox.Show("找不到测试数据文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StreamReader reader = new(TestDataPath);
            string line = "";
            while ((line = reader.ReadLine()!) != null)
            {
                int firstIndex = line.IndexOf(',');
                int currentLabel = Convert.ToInt32(line.Substring(0, firstIndex));
                string currentData = line.Substring(firstIndex + 1);
                float[] data = currentData.Split(',').Select(x => float.Parse(x)).ToArray();

                TestDatas.Add(data);
                TestLabels.Add(currentLabel);
            }

            TestData = new(To2D<float>(TestDatas.ToArray()));
            TestLabel = new(TestLabels.ToArray());
        }

        private T[,] To2D<T>(T[][] source)
        {
            try
            {
                int FirstDim = source.Length;
                int SecondDim = source.GroupBy(row => row.Length).Single().Key;

                var result = new T[FirstDim, SecondDim];
                for (int i = 0; i < FirstDim; i++)
                {
                    for (int j = 0; j < SecondDim; j++)
                    {
                        result[i, j] = source[i][j];
                    }
                }

                return result;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("给定的锯齿状数组不是矩形");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TrainData == null)
            {
                return;
            }

            if (Counter >= 0)
            {
                using Image<Gray, byte> imgout = TrainData.GetRow(Counter).Mat.Reshape(0, 29).ToImage<Gray, byte>().ThresholdBinary(new Gray(30), new Gray(255));
                pictureBox1.Image = imgout.AsBitmap();
                Counter--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TrainData == null)
            {
                return;
            }

            if (Counter < TrainData.Rows - 1)
            {
                Counter++;

                using Image<Gray, byte> imgout = TrainData.GetRow(Counter).Mat.Reshape(0, 29).ToImage<Gray, byte>().ThresholdBinary(new Gray(30), new Gray(255));
                pictureBox1.Image = imgout.AsBitmap();
            }
        }

        private void cbShowData_CheckedChanged(object sender, EventArgs e)
        {
            IsDisplayImage = cbShowData.Checked;
        }
    }
}
