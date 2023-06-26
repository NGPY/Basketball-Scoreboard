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
            SuspendLayout();
            // 
            // TimerDisplay
            // 
            TimerDisplay.AutoSize = true;
            TimerDisplay.ForeColor = Color.Red;
            TimerDisplay.Location = new Point(277, 69);
            TimerDisplay.Name = "TimerDisplay";
            TimerDisplay.Size = new Size(47, 20);
            TimerDisplay.TabIndex = 0;
            TimerDisplay.Text = "Timer";
            // 
            // StartTimer
            // 
            StartTimer.Location = new Point(326, 88);
            StartTimer.Margin = new Padding(3, 4, 3, 4);
            StartTimer.Name = "StartTimer";
            StartTimer.Size = new Size(86, 31);
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
            PosessionTimer.Location = new Point(510, 69);
            PosessionTimer.Name = "PosessionTimer";
            PosessionTimer.Size = new Size(118, 20);
            PosessionTimer.TabIndex = 2;
            PosessionTimer.Text = " Posession Timer";
            // 
            // ResetPosession
            // 
            ResetPosession.Location = new Point(418, 88);
            ResetPosession.Margin = new Padding(3, 4, 3, 4);
            ResetPosession.Name = "ResetPosession";
            ResetPosession.Size = new Size(125, 31);
            ResetPosession.TabIndex = 3;
            ResetPosession.Text = "Reset Possession";
            ResetPosession.UseVisualStyleBackColor = true;
            ResetPosession.Click += ResetPosession_Click;
            // 
            // HomeScore
            // 
            HomeScore.AutoSize = true;
            HomeScore.Location = new Point(304, 199);
            HomeScore.Name = "HomeScore";
            HomeScore.Size = new Size(17, 20);
            HomeScore.TabIndex = 4;
            HomeScore.Text = "0";
            // 
            // AwayScore
            // 
            AwayScore.AutoSize = true;
            AwayScore.Location = new Point(546, 199);
            AwayScore.Name = "AwayScore";
            AwayScore.Size = new Size(17, 20);
            AwayScore.TabIndex = 5;
            AwayScore.Text = "0";
            // 
            // HomePlus1
            // 
            HomePlus1.Location = new Point(273, 235);
            HomePlus1.Margin = new Padding(3, 4, 3, 4);
            HomePlus1.Name = "HomePlus1";
            HomePlus1.Size = new Size(86, 31);
            HomePlus1.TabIndex = 6;
            HomePlus1.Text = "+1";
            HomePlus1.UseVisualStyleBackColor = true;
            HomePlus1.Click += HomePlus1_Click;
            // 
            // HomePlus2
            // 
            HomePlus2.Location = new Point(273, 273);
            HomePlus2.Margin = new Padding(3, 4, 3, 4);
            HomePlus2.Name = "HomePlus2";
            HomePlus2.Size = new Size(86, 31);
            HomePlus2.TabIndex = 7;
            HomePlus2.Text = "+2";
            HomePlus2.UseVisualStyleBackColor = true;
            HomePlus2.Click += HomePlus2_Click;
            // 
            // HomePlus3
            // 
            HomePlus3.Location = new Point(273, 312);
            HomePlus3.Margin = new Padding(3, 4, 3, 4);
            HomePlus3.Name = "HomePlus3";
            HomePlus3.Size = new Size(86, 31);
            HomePlus3.TabIndex = 8;
            HomePlus3.Text = "+3";
            HomePlus3.UseVisualStyleBackColor = true;
            HomePlus3.Click += HomePlus3_Click;
            // 
            // AwayPlus1
            // 
            AwayPlus1.Location = new Point(510, 235);
            AwayPlus1.Margin = new Padding(3, 4, 3, 4);
            AwayPlus1.Name = "AwayPlus1";
            AwayPlus1.Size = new Size(86, 31);
            AwayPlus1.TabIndex = 9;
            AwayPlus1.Text = "+1";
            AwayPlus1.UseVisualStyleBackColor = true;
            AwayPlus1.Click += AwayPlus1_Click;
            // 
            // AwayPlus2
            // 
            AwayPlus2.Location = new Point(510, 273);
            AwayPlus2.Margin = new Padding(3, 4, 3, 4);
            AwayPlus2.Name = "AwayPlus2";
            AwayPlus2.Size = new Size(86, 31);
            AwayPlus2.TabIndex = 10;
            AwayPlus2.Text = "+2";
            AwayPlus2.UseVisualStyleBackColor = true;
            AwayPlus2.Click += AwayPlus2_Click;
            // 
            // AwayPlus3
            // 
            AwayPlus3.Location = new Point(510, 312);
            AwayPlus3.Margin = new Padding(3, 4, 3, 4);
            AwayPlus3.Name = "AwayPlus3";
            AwayPlus3.Size = new Size(86, 31);
            AwayPlus3.TabIndex = 11;
            AwayPlus3.Text = "+3";
            AwayPlus3.UseVisualStyleBackColor = true;
            AwayPlus3.Click += AwayPlus3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(677, 151);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 12;
            button1.Text = "New period";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(704, 128);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 13;
            label1.Text = "Period: 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 64, 99);
            ClientSize = new Size(800, 450);
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
            Margin = new Padding(3, 4, 3, 4);
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
    }
}