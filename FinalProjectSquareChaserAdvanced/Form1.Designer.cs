namespace FinalProjectSquareChaserAdvanced
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.p1scoreLabel = new System.Windows.Forms.Label();
            this.p2scoreLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // p1scoreLabel
            // 
            this.p1scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p1scoreLabel.Location = new System.Drawing.Point(52, 26);
            this.p1scoreLabel.Name = "p1scoreLabel";
            this.p1scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.p1scoreLabel.TabIndex = 0;
            this.p1scoreLabel.Text = "P1: 0";
            // 
            // p2scoreLabel
            // 
            this.p2scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p2scoreLabel.Location = new System.Drawing.Point(52, 49);
            this.p2scoreLabel.Name = "p2scoreLabel";
            this.p2scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.p2scoreLabel.TabIndex = 1;
            this.p2scoreLabel.Text = "P2: 0";
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeLabel.Location = new System.Drawing.Point(407, 26);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 23);
            this.timeLabel.TabIndex = 2;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.winLabel.Location = new System.Drawing.Point(159, 310);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(269, 23);
            this.winLabel.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(159, 160);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(269, 23);
            this.titleLabel.TabIndex = 4;
            // 
            // subtitleLabel
            // 
            this.subtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtitleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtitleLabel.Location = new System.Drawing.Point(159, 183);
            this.subtitleLabel.Name = "subtitleLabel";
            this.subtitleLabel.Size = new System.Drawing.Size(348, 85);
            this.subtitleLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.subtitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.p2scoreLabel);
            this.Controls.Add(this.p1scoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label p1scoreLabel;
        private System.Windows.Forms.Label p2scoreLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
    }
}

