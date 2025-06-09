namespace GameApp
{
    partial class FormRockPaperScissors
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
            lblPlayer1 = new Label();
            lblPlayer2 = new Label();
            btnPlayer1Rock = new Button();
            btnPlayer1Paper = new Button();
            btnPlayer1Scissors = new Button();
            btnPlayer2Rock = new Button();
            btnPlayer2Paper = new Button();
            btnPlayer2Scissors = new Button();
            lblPlayer1Choice = new Label();
            lblPlayer2Choice = new Label();
            lblResult = new Label();
            lblPlayer1Score = new Label();
            lblPlayer2Score = new Label();
            btnReturnMenu = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Microsoft JhengHei UI", 20F);
            lblPlayer1.Location = new Point(74, 31);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(107, 43);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "玩家1";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Microsoft JhengHei UI", 20F);
            lblPlayer2.Location = new Point(811, 31);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(107, 43);
            lblPlayer2.TabIndex = 1;
            lblPlayer2.Text = "玩家2";
            // 
            // btnPlayer1Rock
            // 
            btnPlayer1Rock.Image = Properties.Resources.石頭;
            btnPlayer1Rock.Location = new Point(12, 77);
            btnPlayer1Rock.Name = "btnPlayer1Rock";
            btnPlayer1Rock.Size = new Size(225, 225);
            btnPlayer1Rock.TabIndex = 2;
            btnPlayer1Rock.Text = "石頭";
            btnPlayer1Rock.UseVisualStyleBackColor = true;
            btnPlayer1Rock.Click += btnPlayer1Rock_Click;
            // 
            // btnPlayer1Paper
            // 
            btnPlayer1Paper.Image = Properties.Resources.布;
            btnPlayer1Paper.Location = new Point(12, 308);
            btnPlayer1Paper.Name = "btnPlayer1Paper";
            btnPlayer1Paper.Size = new Size(225, 225);
            btnPlayer1Paper.TabIndex = 3;
            btnPlayer1Paper.Text = "布";
            btnPlayer1Paper.UseVisualStyleBackColor = true;
            btnPlayer1Paper.Click += btnPlayer1Paper_Click;
            // 
            // btnPlayer1Scissors
            // 
            btnPlayer1Scissors.Image = Properties.Resources.剪刀;
            btnPlayer1Scissors.Location = new Point(12, 539);
            btnPlayer1Scissors.Name = "btnPlayer1Scissors";
            btnPlayer1Scissors.Size = new Size(225, 225);
            btnPlayer1Scissors.TabIndex = 4;
            btnPlayer1Scissors.Text = "剪刀";
            btnPlayer1Scissors.UseVisualStyleBackColor = true;
            btnPlayer1Scissors.Click += btnPlayer1Scissors_Click;
            // 
            // btnPlayer2Rock
            // 
            btnPlayer2Rock.Image = Properties.Resources.石頭;
            btnPlayer2Rock.Location = new Point(745, 77);
            btnPlayer2Rock.Name = "btnPlayer2Rock";
            btnPlayer2Rock.Size = new Size(225, 225);
            btnPlayer2Rock.TabIndex = 5;
            btnPlayer2Rock.Text = "石頭";
            btnPlayer2Rock.UseVisualStyleBackColor = true;
            btnPlayer2Rock.Click += btnPlayer2Rock_Click;
            // 
            // btnPlayer2Paper
            // 
            btnPlayer2Paper.Image = Properties.Resources.布;
            btnPlayer2Paper.Location = new Point(745, 308);
            btnPlayer2Paper.Name = "btnPlayer2Paper";
            btnPlayer2Paper.Size = new Size(225, 225);
            btnPlayer2Paper.TabIndex = 6;
            btnPlayer2Paper.Text = "布";
            btnPlayer2Paper.UseVisualStyleBackColor = true;
            btnPlayer2Paper.Click += btnPlayer2Paper_Click;
            // 
            // btnPlayer2Scissors
            // 
            btnPlayer2Scissors.Image = Properties.Resources.剪刀;
            btnPlayer2Scissors.Location = new Point(745, 539);
            btnPlayer2Scissors.Name = "btnPlayer2Scissors";
            btnPlayer2Scissors.Size = new Size(225, 225);
            btnPlayer2Scissors.TabIndex = 7;
            btnPlayer2Scissors.Text = "剪刀";
            btnPlayer2Scissors.UseVisualStyleBackColor = true;
            btnPlayer2Scissors.Click += btnPlayer2Scissors_Click;
            // 
            // lblPlayer1Choice
            // 
            lblPlayer1Choice.AutoSize = true;
            lblPlayer1Choice.Font = new Font("Microsoft JhengHei UI", 15F);
            lblPlayer1Choice.Location = new Point(245, 146);
            lblPlayer1Choice.Name = "lblPlayer1Choice";
            lblPlayer1Choice.Size = new Size(134, 32);
            lblPlayer1Choice.TabIndex = 8;
            lblPlayer1Choice.Text = "玩家1選擇:";
            // 
            // lblPlayer2Choice
            // 
            lblPlayer2Choice.AutoSize = true;
            lblPlayer2Choice.Font = new Font("Microsoft JhengHei UI", 15F);
            lblPlayer2Choice.Location = new Point(245, 279);
            lblPlayer2Choice.Name = "lblPlayer2Choice";
            lblPlayer2Choice.Size = new Size(134, 32);
            lblPlayer2Choice.TabIndex = 9;
            lblPlayer2Choice.Text = "玩家2選擇:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft JhengHei UI", 25F);
            lblResult.Location = new Point(245, 390);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(201, 54);
            lblResult.TabIndex = 10;
            lblResult.Text = "比賽結果:";
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.AutoSize = true;
            lblPlayer1Score.Font = new Font("Microsoft JhengHei UI", 15F);
            lblPlayer1Score.Location = new Point(245, 219);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(134, 32);
            lblPlayer1Score.TabIndex = 11;
            lblPlayer1Score.Text = "玩家1分數:";
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.AutoSize = true;
            lblPlayer2Score.Font = new Font("Microsoft JhengHei UI", 15F);
            lblPlayer2Score.Location = new Point(245, 327);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(134, 32);
            lblPlayer2Score.TabIndex = 12;
            lblPlayer2Score.Text = "玩家2分數:";
            // 
            // btnReturnMenu
            // 
            btnReturnMenu.Font = new Font("Microsoft JhengHei UI", 20F);
            btnReturnMenu.Location = new Point(392, 773);
            btnReturnMenu.Name = "btnReturnMenu";
            btnReturnMenu.Size = new Size(181, 54);
            btnReturnMenu.TabIndex = 13;
            btnReturnMenu.Text = "返回主選單";
            btnReturnMenu.UseVisualStyleBackColor = true;
            btnReturnMenu.Click += btnReturnMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 30F);
            label1.Location = new Point(245, 31);
            label1.Name = "label1";
            label1.Size = new Size(377, 64);
            label1.TabIndex = 14;
            label1.Text = "剪刀、石頭、布";
            // 
            // FormRockPaperScissors
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 1053);
            Controls.Add(label1);
            Controls.Add(btnReturnMenu);
            Controls.Add(lblPlayer2Score);
            Controls.Add(lblPlayer1Score);
            Controls.Add(lblResult);
            Controls.Add(lblPlayer2Choice);
            Controls.Add(lblPlayer1Choice);
            Controls.Add(btnPlayer2Scissors);
            Controls.Add(btnPlayer2Paper);
            Controls.Add(btnPlayer2Rock);
            Controls.Add(btnPlayer1Scissors);
            Controls.Add(btnPlayer1Paper);
            Controls.Add(btnPlayer1Rock);
            Controls.Add(lblPlayer2);
            Controls.Add(lblPlayer1);
            Name = "FormRockPaperScissors";
            Text = "FormRockPaperScissors";
            Load += FormRockPaperScissors_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayer1;
        private Label lblPlayer2;
        private Button btnPlayer1Rock;
        private Button btnPlayer1Paper;
        private Button btnPlayer1Scissors;
        private Button btnPlayer2Rock;
        private Button btnPlayer2Paper;
        private Button btnPlayer2Scissors;
        private Label lblPlayer1Choice;
        private Label lblPlayer2Choice;
        private Label lblResult;
        private Label lblPlayer1Score;
        private Label lblPlayer2Score;
        private Button btnReturnMenu;
        private Label label1;
    }
}