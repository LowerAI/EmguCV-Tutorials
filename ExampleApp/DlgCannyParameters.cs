namespace ExampleApp
{
    // P4中被调用
    public partial class DlgCannyParameters : Form
    {
        public DlgCannyParameters()
        {
            InitializeComponent();
        }

        public DlgCannyParameters((double thresh, double threshLinking) paras) : this()
        {
            numericThreshold.Value = (decimal)paras.thresh;
            numericThresholdLink.Value = (decimal)paras.threshLinking;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var result = ((double)numericThreshold.Value, (double)numericThresholdLink.Value);
            this.Tag = result;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
