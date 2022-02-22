namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int counter = 30;

        private void btnStart_Click(object sender, EventArgs e)
        {
            aTimer.Interval = 1000; // 1 sekund
            aTimer.Start();
            label1.Text = counter.ToString();
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                aTimer.Stop();
            }
            label1.Text = counter.ToString();
        }
    }
}