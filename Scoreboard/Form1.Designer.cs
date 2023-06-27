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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            TimeoutTimer = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            HomeFouls = new Label();
            AwayFouls = new Label();
            HomeTimeouts = new Label();
            AwayTimeouts = new Label();
            HomeFoul = new Button();
            AwayFoul = new Button();
            HomeTimeout = new Button();
            AwayTimeout = new Button();
            TimeoutTick = new System.Windows.Forms.Timer(components);
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
            HomeScore.Location = new Point(266, 123);
            HomeScore.Name = "HomeScore";
            HomeScore.Size = new Size(13, 15);
            HomeScore.TabIndex = 4;
            HomeScore.Text = "0";
            // 
            // AwayScore
            // 
            AwayScore.AutoSize = true;
            AwayScore.Location = new Point(477, 123);
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
            // button1
            // 
            button1.Location = new Point(592, 37);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(93, 22);
            button1.TabIndex = 12;
            button1.Text = "New period";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(592, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 13;
            label1.Text = "Period: 1";
            // 
            // button2
            // 
            button2.Location = new Point(366, 95);
            button2.Name = "button2";
            button2.Size = new Size(134, 23);
            button2.TabIndex = 14;
            button2.Text = "Reset Possession to 14";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(340, 281);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 15;
            button3.Text = "Withdraw";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // TimeoutTimer
            // 
            TimeoutTimer.AutoSize = true;
            TimeoutTimer.Location = new Point(328, 9);
            TimeoutTimer.Name = "TimeoutTimer";
            TimeoutTimer.Size = new Size(19, 15);
            TimeoutTimer.TabIndex = 16;
            TimeoutTimer.Text = "00";
            TimeoutTimer.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 123);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 17;
            label3.Text = "Points";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 138);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 18;
            label4.Text = "Fouls";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 153);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 19;
            label5.Text = "Timeouts";
            // 
            // HomeFouls
            // 
            HomeFouls.AutoSize = true;
            HomeFouls.Location = new Point(266, 138);
            HomeFouls.Name = "HomeFouls";
            HomeFouls.Size = new Size(13, 15);
            HomeFouls.TabIndex = 20;
            HomeFouls.Text = "0";
            // 
            // AwayFouls
            // 
            AwayFouls.AutoSize = true;
            AwayFouls.Location = new Point(477, 138);
            AwayFouls.Name = "AwayFouls";
            AwayFouls.Size = new Size(13, 15);
            AwayFouls.TabIndex = 21;
            AwayFouls.Text = "0";
            // 
            // HomeTimeouts
            // 
            HomeTimeouts.AutoSize = true;
            HomeTimeouts.Location = new Point(266, 153);
            HomeTimeouts.Name = "HomeTimeouts";
            HomeTimeouts.Size = new Size(13, 15);
            HomeTimeouts.TabIndex = 22;
            HomeTimeouts.Text = "5";
            // 
            // AwayTimeouts
            // 
            AwayTimeouts.AutoSize = true;
            AwayTimeouts.Location = new Point(477, 153);
            AwayTimeouts.Name = "AwayTimeouts";
            AwayTimeouts.Size = new Size(13, 15);
            AwayTimeouts.TabIndex = 23;
            AwayTimeouts.Text = "5";
            // 
            // HomeFoul
            // 
            HomeFoul.Location = new Point(158, 176);
            HomeFoul.Name = "HomeFoul";
            HomeFoul.Size = new Size(75, 23);
            HomeFoul.TabIndex = 24;
            HomeFoul.Text = "Foul";
            HomeFoul.UseVisualStyleBackColor = true;
            HomeFoul.Click += HomeFoul_Click;
            // 
            // AwayFoul
            // 
            AwayFoul.Location = new Point(527, 176);
            AwayFoul.Name = "AwayFoul";
            AwayFoul.Size = new Size(75, 23);
            AwayFoul.TabIndex = 25;
            AwayFoul.Text = "Foul";
            AwayFoul.UseVisualStyleBackColor = true;
            AwayFoul.Click += AwayFoul_Click;
            // 
            // HomeTimeout
            // 
            HomeTimeout.Location = new Point(158, 205);
            HomeTimeout.Name = "HomeTimeout";
            HomeTimeout.Size = new Size(75, 23);
            HomeTimeout.TabIndex = 26;
            HomeTimeout.Text = "Timeout";
            HomeTimeout.UseVisualStyleBackColor = true;
            HomeTimeout.Click += HomeTimeout_Click;
            // 
            // AwayTimeout
            // 
            AwayTimeout.Location = new Point(527, 205);
            AwayTimeout.Name = "AwayTimeout";
            AwayTimeout.Size = new Size(75, 23);
            AwayTimeout.TabIndex = 27;
            AwayTimeout.Text = "Timeout";
            AwayTimeout.UseVisualStyleBackColor = true;
            AwayTimeout.Click += AwayTimeout_Click;
            // 
            // TimeoutTick
            // 
            TimeoutTick.Tick += TimeoutTick_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(AwayTimeout);
            Controls.Add(HomeTimeout);
            Controls.Add(AwayFoul);
            Controls.Add(HomeFoul);
            Controls.Add(AwayTimeouts);
            Controls.Add(HomeTimeouts);
            Controls.Add(AwayFouls);
            Controls.Add(HomeFouls);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TimeoutTimer);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
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
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label TimeoutTimer;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label HomeFouls;
        private Label AwayFouls;
        private Label HomeTimeouts;
        private Label AwayTimeouts;
        private Button HomeFoul;
        private Button AwayFoul;
        private Button HomeTimeout;
        private Button AwayTimeout;
        private System.Windows.Forms.Timer TimeoutTick;
    }
}