using System.Diagnostics;

namespace Scoreboard
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        Stopwatch psw = new Stopwatch();
        Stopwatch timeoutSW = new Stopwatch();
        int withdraw = 1;
        int currentPosLength = 24;
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
            if (psw.ElapsedMilliseconds / 1000 == currentPosLength)
            {
                timer1.Stop();
                sw.Stop();
                psw.Stop();
                psw.Reset();
                currentPosLength = 24;
            }
            PosessionTimer.Text = $"{(currentPosLength - psw.ElapsedMilliseconds / 1000.0):00.0}";
        }

        private void ResetPosession_Click(object sender, EventArgs e)
        {
            psw.Reset();
            currentPosLength = 24;
            PosessionTimer.Text = $"{(currentPosLength - psw.ElapsedMilliseconds / 1000.0):00.0}";
            if (timer1.Enabled)
            {
                psw.Start();
            }

        }

        private void HomePlus1_Click(object sender, EventArgs e)
        {
            HomeScore.Text = (Convert.ToInt16(HomeScore.Text) + withdraw * 1).ToString();
        }

        private void HomePlus2_Click(object sender, EventArgs e)
        {
            HomeScore.Text = (Convert.ToInt16(HomeScore.Text) + withdraw * 2).ToString();
        }

        private void HomePlus3_Click(object sender, EventArgs e)
        {
            HomeScore.Text = (Convert.ToInt16(HomeScore.Text) + withdraw * 3).ToString();
        }

        private void AwayPlus1_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(AwayScore.Text) + withdraw * 1).ToString();
        }

        private void AwayPlus2_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(AwayScore.Text) + withdraw * 2).ToString();
        }

        private void AwayPlus3_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(AwayScore.Text) + withdraw * 3).ToString();
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
                PosessionTimer.Text = $"{(currentPosLength - psw.ElapsedMilliseconds / 1000.0):00.0}";
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this program?", "Cancel close", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            psw.Reset();
            currentPosLength = 14;
            PosessionTimer.Text = $"{(currentPosLength - psw.ElapsedMilliseconds / 1000.0):00.0}";
            if (timer1.Enabled)
            {
                psw.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdraw *= -1;
        }

        private void AwayFoul_Click(object sender, EventArgs e)
        {
            AwayFouls.Text = Convert.ToString(Convert.ToInt16(AwayFouls.Text) + 1);
            sw.Stop();
            psw.Stop(); psw.Reset();
            PosessionTimer.Text = $"{(currentPosLength - psw.ElapsedMilliseconds / 1000.0):00.0}";
        }

        private void HomeFoul_Click(object sender, EventArgs e)
        {
            HomeFouls.Text = Convert.ToString(Convert.ToInt16(HomeFouls.Text) + 1);
            sw.Stop();
            psw.Stop(); psw.Reset();
            PosessionTimer.Text = $"{(currentPosLength - psw.ElapsedMilliseconds / 1000.0):00.0}";
        }

        private void HomeTimeout_Click(object sender, EventArgs e)
        {
            sw.Stop();
            psw.Stop();
            HomeTimeouts.Text = Convert.ToString(Convert.ToInt16(HomeTimeouts.Text) - 1);
            TimeoutTimer.Visible = true;
            timeoutSW.Start();
            TimeoutTick.Start();
            TimeoutTimer.Text = $"{timeoutSW.ElapsedMilliseconds:00}";
        }

        private void TimeoutTick_Tick(object sender, EventArgs e)
        {
            if (60000 - timeoutSW.ElapsedMilliseconds < 0)
            {
                TimeoutTimer.Visible = false;
                timeoutSW.Stop();
                TimeoutTick.Stop();
            }
            else
            {
                TimeoutTimer.Text = $"{(60000 - timeoutSW.ElapsedMilliseconds) / 1000:00}";
            }

        }

        private void AwayTimeout_Click(object sender, EventArgs e)
        {
            sw.Stop();
            psw.Stop();
            AwayTimeouts.Text = Convert.ToString(Convert.ToInt16(AwayTimeouts.Text) - 1);
            TimeoutTimer.Visible = true;
            timeoutSW.Start();
            TimeoutTick.Start();
            TimeoutTimer.Text = $"{timeoutSW.ElapsedMilliseconds:00}";
        }
    }
}