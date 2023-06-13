namespace Scoreboard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TimerDisplay = new Label();
            StartTimer = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            PosessionTimer = new Label();
            ResetPosession = new Button();
            HomeScore = new Label();
            AwayScore = new Label();
            HomePlus1 = new Button();
            HomePlus2 = new Button();
            HomePlus3 = new Button();
            AwayPlus1 = new Button();
            AwayPlus2 = new Button();
            AwayPlus3 = new Button();
            SuspendLayout();
            // 
            // TimerDisplay
            // 
            TimerDisplay.AutoSize = true;
            TimerDisplay.ForeColor = Color.Red;
            TimerDisplay.Location = new Point(242, 52);
            TimerDisplay.Name = "TimerDisplay";
            TimerDisplay.Size = new Size(37, 15);
            TimerDisplay.TabIndex = 0;
            TimerDisplay.Text = "Timer";
            // 
            // StartTimer
            // 
            StartTimer.Location = new Point(285, 66);
            StartTimer.Name = "StartTimer";
            StartTimer.Size = new Size(75, 23);
            StartTimer.TabIndex = 1;
            StartTimer.Text = "Start/Stop";
            StartTimer.UseVisualStyleBackColor = true;
            StartTimer.Click += StartTimer_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PosessionTimer
            // 
            PosessionTimer.AutoSize = true;
            PosessionTimer.ForeColor = Color.Goldenrod;
            PosessionTimer.Location = new Point(446, 52);
            PosessionTimer.Name = "PosessionTimer";
            PosessionTimer.Size = new Size(95, 15);
            PosessionTimer.TabIndex = 2;
            PosessionTimer.Text = " Posession Timer";
            // 
            // ResetPosession
            // 
            ResetPosession.Location = new Point(366, 66);
            ResetPosession.Name = "ResetPosession";
            ResetPosession.Size = new Size(109, 23);
            ResetPosession.TabIndex = 3;
            ResetPosession.Text = "Reset Possession";
            ResetPosession.UseVisualStyleBackColor = true;
            ResetPosession.Click += ResetPosession_Click;
            // 
            // HomeScore
            // 
            HomeScore.AutoSize = true;
            HomeScore.Location = new Point(266, 149);
            HomeScore.Name = "HomeScore";
            HomeScore.Size = new Size(13, 15);
            HomeScore.TabIndex = 4;
            HomeScore.Text = "0";
            // 
            // AwayScore
            // 
            AwayScore.AutoSize = true;
            AwayScore.Location = new Point(478, 149);
            AwayScore.Name = "AwayScore";
            AwayScore.Size = new Size(13, 15);
            AwayScore.TabIndex = 5;
            AwayScore.Text = "0";
            // 
            // HomePlus1
            // 
            HomePlus1.Location = new Point(239, 176);
            HomePlus1.Name = "HomePlus1";
            HomePlus1.Size = new Size(75, 23);
            HomePlus1.TabIndex = 6;
            HomePlus1.Text = "+1";
            HomePlus1.UseVisualStyleBackColor = true;
            HomePlus1.Click += HomePlus1_Click;
            // 
            // HomePlus2
            // 
            HomePlus2.Location = new Point(239, 205);
            HomePlus2.Name = "HomePlus2";
            HomePlus2.Size = new Size(75, 23);
            HomePlus2.TabIndex = 7;
            HomePlus2.Text = "+2";
            HomePlus2.UseVisualStyleBackColor = true;
            HomePlus2.Click += HomePlus2_Click;
            // 
            // HomePlus3
            // 
            HomePlus3.Location = new Point(239, 234);
            HomePlus3.Name = "HomePlus3";
            HomePlus3.Size = new Size(75, 23);
            HomePlus3.TabIndex = 8;
            HomePlus3.Text = "+3";
            HomePlus3.UseVisualStyleBackColor = true;
            HomePlus3.Click += HomePlus3_Click;
            // 
            // AwayPlus1
            // 
            AwayPlus1.Location = new Point(446, 176);
            AwayPlus1.Name = "AwayPlus1";
            AwayPlus1.Size = new Size(75, 23);
            AwayPlus1.TabIndex = 9;
            AwayPlus1.Text = "+1";
            AwayPlus1.UseVisualStyleBackColor = true;
            AwayPlus1.Click += AwayPlus1_Click;
            // 
            // AwayPlus2
            // 
            AwayPlus2.Location = new Point(446, 205);
            AwayPlus2.Name = "AwayPlus2";
            AwayPlus2.Size = new Size(75, 23);
            AwayPlus2.TabIndex = 10;
            AwayPlus2.Text = "+2";
            AwayPlus2.UseVisualStyleBackColor = true;
            AwayPlus2.Click += AwayPlus2_Click;
            // 
            // AwayPlus3
            // 
            AwayPlus3.Location = new Point(446, 234);
            AwayPlus3.Name = "AwayPlus3";
            AwayPlus3.Size = new Size(75, 23);
            AwayPlus3.TabIndex = 11;
            AwayPlus3.Text = "+3";
            AwayPlus3.UseVisualStyleBackColor = true;
            AwayPlus3.Click += AwayPlus3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 64, 99);
            ClientSize = new Size(800, 450);
            Controls.Add(AwayPlus3);
            Controls.Add(AwayPlus2);
            Controls.Add(AwayPlus1);
            Controls.Add(HomePlus3);
            Controls.Add(HomePlus2);
            Controls.Add(HomePlus1);
            Controls.Add(AwayScore);
            Controls.Add(HomeScore);
            Controls.Add(ResetPosession);
            Controls.Add(PosessionTimer);
            Controls.Add(StartTimer);
            Controls.Add(TimerDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimerDisplay;
        private Button StartTimer;
        private System.Windows.Forms.Timer timer1;
        private Label PosessionTimer;
        private Button ResetPosession;
        private Label HomeScore;
        private Label AwayScore;
        private Button HomePlus1;
        private Button HomePlus2;
        private Button HomePlus3;
        private Button AwayPlus1;
        private Button AwayPlus2;
        private Button AwayPlus3;
    }
}