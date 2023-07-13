namespace YoketoruCS
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
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            buttonTitle = new Button();
            labelGameover = new Label();
            labelClear = new Label();
            labelHighScore = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            labelCopyright = new Label();
            tempPlayer = new Label();
            tempObstacle = new Label();
            tempItem = new Label();
            labelTimer = new Label();
            labelScore = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(363, 137);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(56, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるCS";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(344, 247);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(125, 60);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonTitle
            // 
            buttonTitle.Location = new Point(344, 313);
            buttonTitle.Name = "buttonTitle";
            buttonTitle.Size = new Size(125, 60);
            buttonTitle.TabIndex = 2;
            buttonTitle.TabStop = false;
            buttonTitle.Text = "Back to title";
            buttonTitle.UseVisualStyleBackColor = true;
            buttonTitle.Click += buttonTitle_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Location = new Point(363, 195);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(72, 15);
            labelGameover.TabIndex = 3;
            labelGameover.Text = "GAME OVER";
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Location = new Point(363, 82);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(44, 15);
            labelClear.TabIndex = 4;
            labelClear.Text = "CLEAR!";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Location = new Point(44, 25);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(64, 15);
            labelHighScore.TabIndex = 5;
            labelHighScore.Text = "High score";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labelCopyright
            // 
            labelCopyright.AutoSize = true;
            labelCopyright.Location = new Point(44, 60);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(62, 15);
            labelCopyright.TabIndex = 6;
            labelCopyright.Text = "CopyRight";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Location = new Point(658, 220);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(37, 15);
            tempPlayer.TabIndex = 7;
            tempPlayer.Text = "(・ω・)";
            // 
            // tempObstacle
            // 
            tempObstacle.AutoSize = true;
            tempObstacle.Location = new Point(658, 270);
            tempObstacle.Name = "tempObstacle";
            tempObstacle.Size = new Size(19, 15);
            tempObstacle.TabIndex = 10;
            tempObstacle.Text = "◇";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Location = new Point(659, 322);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(19, 15);
            tempItem.TabIndex = 11;
            tempItem.Text = "☆";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(363, 25);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(34, 15);
            labelTimer.TabIndex = 12;
            labelTimer.Text = "timer";
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(44, 137);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(35, 15);
            labelScore.TabIndex = 13;
            labelScore.Text = "score";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 451);
            Controls.Add(labelScore);
            Controls.Add(labelTimer);
            Controls.Add(tempItem);
            Controls.Add(tempObstacle);
            Controls.Add(tempPlayer);
            Controls.Add(labelCopyright);
            Controls.Add(labelHighScore);
            Controls.Add(labelClear);
            Controls.Add(labelGameover);
            Controls.Add(buttonTitle);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Button buttonTitle;
        private Label labelGameover;
        private Label labelClear;
        private Label labelHighScore;
        private FileSystemWatcher fileSystemWatcher1;
        private Label tempItem;
        private Label tempObstacle;
        private Label tempPlayer;
        private Label labelCopyright;
        private Label labelTimer;
        private Label labelScore;
    }
}