namespace ExampleApp
{
    public partial class DlgParameters : Form
    {
        private readonly Action<int, int> _action;

        public DlgParameters()
        {
            InitializeComponent();
        }

        public DlgParameters(Action<int, int> action) : this()
        {
            _action = action;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            _action?.Invoke(trackBarMin.Value, trackBarMax.Value);
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            // 确保最小值追踪栏的当前值小于等于最大值追踪栏的当前值
            trackBarMin.Maximum = trackBarMax.Value; // 最小值追踪栏的最大值档位始终等于最大值追踪栏的当前值
            trackBarMax.Minimum = trackBarMin.Value; // 最大值追踪栏的最小值档位始终等于最大值追踪栏的当前值
        }
    }
}
