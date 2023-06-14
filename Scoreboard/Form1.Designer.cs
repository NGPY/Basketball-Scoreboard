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
            TimerDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TimerDisplay.AutoSize = true;
            TimerDisplay.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            TimerDisplay.ForeColor = Color.Red;
            TimerDisplay.Location = new Point(834, 100);
            TimerDisplay.Name = "TimerDisplay";
            TimerDisplay.Size = new Size(133, 45);
            TimerDisplay.TabIndex = 0;
            TimerDisplay.Text = "00:00";
            // 
            // StartTimer
            // 
            StartTimer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartTimer.Location = new Point(842, 193);
            StartTimer.Name = "StartTimer";
            StartTimer.Size = new Size(118, 37);
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
            PosessionTimer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PosessionTimer.AutoSize = true;
            PosessionTimer.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            PosessionTimer.ForeColor = Color.Goldenrod;
            PosessionTimer.Location = new Point(842, 145);
            PosessionTimer.Name = "PosessionTimer";
            PosessionTimer.Size = new Size(105, 45);
            PosessionTimer.TabIndex = 2;
            PosessionTimer.Text = "24.0";
            // 
            // ResetPosession
            // 
            ResetPosession.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ResetPosession.Location = new Point(833, 236);
            ResetPosession.Name = "ResetPosession";
            ResetPosession.Size = new Size(134, 59);
            ResetPosession.TabIndex = 3;
            ResetPosession.Text = "Reset Possession";
            ResetPosession.UseVisualStyleBackColor = true;
            ResetPosession.Click += ResetPosession_Click;
            // 
            // HomeScore
            // 
            HomeScore.AutoSize = true;
            HomeScore.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HomeScore.ForeColor = Color.Tomato;
            HomeScore.Location = new Point(751, 100);
            HomeScore.Name = "HomeScore";
            HomeScore.Size = new Size(44, 45);
            HomeScore.TabIndex = 4;
            HomeScore.Text = "0";
            // 
            // AwayScore
            // 
            AwayScore.AutoSize = true;
            AwayScore.Font = new Font("Verdana", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            AwayScore.ForeColor = Color.Tomato;
            AwayScore.Location = new Point(1007, 100);
            AwayScore.Name = "AwayScore";
            AwayScore.Size = new Size(44, 45);
            AwayScore.TabIndex = 5;
            AwayScore.Text = "0";
            // 
            // HomePlus1
            // 
            HomePlus1.BackColor = Color.White;
            HomePlus1.FlatAppearance.BorderSize = 0;
            HomePlus1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePlus1.Location = new Point(620, 75);
            HomePlus1.Name = "HomePlus1";
            HomePlus1.Size = new Size(95, 35);
            HomePlus1.TabIndex = 6;
            HomePlus1.Text = "+1";
            HomePlus1.UseVisualStyleBackColor = false;
            HomePlus1.Click += HomePlus1_Click;
            // 
            // HomePlus2
            // 
            HomePlus2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePlus2.Location = new Point(620, 129);
            HomePlus2.Name = "HomePlus2";
            HomePlus2.Size = new Size(95, 35);
            HomePlus2.TabIndex = 7;
            HomePlus2.Text = "+2";
            HomePlus2.UseVisualStyleBackColor = true;
            HomePlus2.Click += HomePlus2_Click;
            // 
            // HomePlus3
            // 
            HomePlus3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomePlus3.Location = new Point(620, 184);
            HomePlus3.Name = "HomePlus3";
            HomePlus3.Size = new Size(95, 35);
            HomePlus3.TabIndex = 8;
            HomePlus3.Text = "+3";
            HomePlus3.UseVisualStyleBackColor = true;
            HomePlus3.Click += HomePlus3_Click;
            // 
            // AwayPlus1
            // 
            AwayPlus1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AwayPlus1.Location = new Point(1094, 77);
            AwayPlus1.Name = "AwayPlus1";
            AwayPlus1.Size = new Size(95, 35);
            AwayPlus1.TabIndex = 9;
            AwayPlus1.Text = "+1";
            AwayPlus1.UseVisualStyleBackColor = true;
            AwayPlus1.Click += AwayPlus1_Click;
            // 
            // AwayPlus2
            // 
            AwayPlus2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AwayPlus2.Location = new Point(1094, 131);
            AwayPlus2.Name = "AwayPlus2";
            AwayPlus2.Size = new Size(95, 35);
            AwayPlus2.TabIndex = 10;
            AwayPlus2.Text = "+2";
            AwayPlus2.UseVisualStyleBackColor = true;
            AwayPlus2.Click += AwayPlus2_Click;
            // 
            // AwayPlus3
            // 
            AwayPlus3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AwayPlus3.Location = new Point(1094, 186);
            AwayPlus3.Name = "AwayPlus3";
            AwayPlus3.Size = new Size(95, 35);
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
            ClientSize = new Size(1904, 1041);
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
            Text = "Basketball | meiga.lt";
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