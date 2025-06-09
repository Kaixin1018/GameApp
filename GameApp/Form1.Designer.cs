namespace GameApp
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
            lblTitle = new Label();
            btnRockPaperScissors = new Button();
            btnDiceGame = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei UI", 10F);
            lblTitle.Location = new Point(327, 53);
            lblTitle.MaximumSize = new Size(100, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(95, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "請選擇遊戲";
            // 
            // btnRockPaperScissors
            // 
            btnRockPaperScissors.Location = new Point(144, 153);
            btnRockPaperScissors.Name = "btnRockPaperScissors";
            btnRockPaperScissors.Size = new Size(200, 30);
            btnRockPaperScissors.TabIndex = 1;
            btnRockPaperScissors.Text = "進入剪刀、石頭、布遊戲";
            btnRockPaperScissors.UseVisualStyleBackColor = true;
            btnRockPaperScissors.Click += btnRockPaperScissors_Click;
            // 
            // btnDiceGame
            // 
            btnDiceGame.Location = new Point(453, 153);
            btnDiceGame.Name = "btnDiceGame";
            btnDiceGame.Size = new Size(200, 30);
            btnDiceGame.TabIndex = 2;
            btnDiceGame.Text = "進入骰子遊戲";
            btnDiceGame.UseVisualStyleBackColor = true;
            btnDiceGame.Click += btnDiceGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDiceGame);
            Controls.Add(btnRockPaperScissors);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnRockPaperScissors;
        private Button btnDiceGame;
    }
}
