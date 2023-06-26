using System.Diagnostics;

namespace Scoreboard
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        Stopwatch psw = new Stopwatch();
        int period = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                sw.Start();
                psw.Start();
            }
            else
            {
                timer1.Stop();
                sw.Stop();
                psw.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            long time = 600000 - sw.ElapsedMilliseconds;
            TimerDisplay.Text = $"{time / 60000:00}:{(time / 1000) - 60 * (time / 60000):00}";
            if (psw.ElapsedMilliseconds / 1000 == 24)
            {
                timer1.Stop();
                sw.Stop();
                psw.Stop();
                psw.Reset();
            }
            PosessionTimer.Text = $"{(24 - psw.ElapsedMilliseconds / 1000.0):00.0}";
        }

        private void ResetPosession_Click(object sender, EventArgs e)
        {
            psw.Reset();
            PosessionTimer.Text = $"{(24 - psw.ElapsedMilliseconds / 1000.0):00.0}";
            if (timer1.Enabled)
            {
                psw.Start();
            }

        }

        private void HomePlus1_Click(object sender, EventArgs e)
        {
            HomeScore.Text = (Convert.ToInt16(HomeScore.Text) + 1).ToString();
        }

        private void HomePlus2_Click(object sender, EventArgs e)
        {
            HomeScore.Text = (Convert.ToInt16(HomeScore.Text) + 2).ToString();
        }

        private void HomePlus3_Click(object sender, EventArgs e)
        {
            HomeScore.Text = (Convert.ToInt16(HomeScore.Text) + 3).ToString();
        }

        private void AwayPlus1_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(AwayScore.Text) + 1).ToString();
        }

        private void AwayPlus2_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(AwayScore.Text) + 2).ToString();
        }

        private void AwayPlus3_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(AwayScore.Text) + 3).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (period < 4)
            {

                period++;
                label1.Text = $"Period: {period}";
                sw.Stop(); sw.Reset();
                psw.Stop(); psw.Reset();
                long time = 600000 - sw.ElapsedMilliseconds;
                TimerDisplay.Text = $"{time / 60000:00}:{(time / 1000) - 60 * (time / 60000):00}";
                PosessionTimer.Text = $"{(24 - psw.ElapsedMilliseconds / 1000.0):00.0}";
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this program?", "Cancel close", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}