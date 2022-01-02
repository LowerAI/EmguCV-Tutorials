namespace ExampleApp
{
    public partial class DlgHCDParameters : Form
    {
        int Min, Max, Current;

        public delegate void DelegateHarris(int x);
        public event DelegateHarris OnApply;

        public DlgHCDParameters()
        {
            InitializeComponent();
        }

        public DlgHCDParameters(int min,int max,int current):this()
        {
            Min = min;
            Max = max;
            Current = current;
        }

        private void DlgHCDParameters_Load(object sender, EventArgs e)
        {
            lblMin.Text = Min.ToString();
            lblMax.Text = Max.ToString();
            lblCurrent.Text = Current.ToString();

            trackBar1.Minimum = Min;
            trackBar1.Maximum = Max;
            trackBar1.Value = Current;
            trackBar1.ValueChanged += (s, e) =>
            {
                Current = trackBar1.Value;
                lblCurrent.Text = Current.ToString();
            };
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //this.Tag = trackBar1.Value;
            OnApply?.Invoke(trackBar1.Value);
        }
    }
}
