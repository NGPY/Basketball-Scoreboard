using System.Diagnostics;
using System.IO.Pipes;

namespace Scoreboard
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        Stopwatch psw = new Stopwatch();
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
            TimerDisplay.Text = $"{sw.ElapsedMilliseconds / 60000:00}:{(sw.ElapsedMilliseconds / 1000) - 60 * (sw.ElapsedMilliseconds / 60000):00}";
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
            AwayScore.Text = (Convert.ToInt16(HomeScore.Text) + 1).ToString();
        }

        private void AwayPlus2_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(HomeScore.Text) + 2).ToString();
        }

        private void AwayPlus3_Click(object sender, EventArgs e)
        {
            AwayScore.Text = (Convert.ToInt16(HomeScore.Text) + 3).ToString();
        }
    }
}