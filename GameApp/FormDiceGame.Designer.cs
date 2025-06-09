namespace GameApp
{
    partial class FormDiceGame
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
            lblPlayerDice = new Label();
            lblComputerDice = new Label();
            lblDiceResult = new Label();
            btnRollDice = new Button();
            btnReturnMenu = new Button();
            lblDiceGame = new Label();
            pictureBoxPlayerDice = new PictureBox();
            pictureBoxComputerDice = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerDice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputerDice).BeginInit();
            SuspendLayout();
            // 
            // lblPlayerDice
            // 
            lblPlayerDice.AutoSize = true;
            lblPlayerDice.Location = new Point(38, 109);
            lblPlayerDice.Name = "lblPlayerDice";
            lblPlayerDice.Size = new Size(99, 19);
            lblPlayerDice.TabIndex = 0;
            lblPlayerDice.Text = "玩家擲骰子：";
            // 
            // lblComputerDice
            // 
            lblComputerDice.AutoSize = true;
            lblComputerDice.Location = new Point(751, 109);
            lblComputerDice.Name = "lblComputerDice";
            lblComputerDice.Size = new Size(99, 19);
            lblComputerDice.TabIndex = 1;
            lblComputerDice.Text = "電腦擲骰子：";
            // 
            // lblDiceResult
            // 
            lblDiceResult.AutoSize = true;
            lblDiceResult.Location = new Point(458, 88);
            lblDiceResult.Name = "lblDiceResult";
            lblDiceResult.Size = new Size(84, 19);
            lblDiceResult.TabIndex = 2;
            lblDiceResult.Text = "比賽結果：";
            // 
            // btnRollDice
            // 
            btnRollDice.Location = new Point(458, 230);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(94, 29);
            btnRollDice.TabIndex = 3;
            btnRollDice.Text = "擲骰子";
            btnRollDice.UseVisualStyleBackColor = true;
            btnRollDice.Click += btnRollDice_Click;
            // 
            // btnReturnMenu
            // 
            btnReturnMenu.Location = new Point(471, 413);
            btnReturnMenu.Name = "btnReturnMenu";
            btnReturnMenu.Size = new Size(94, 29);
            btnReturnMenu.TabIndex = 4;
            btnReturnMenu.Text = "返回主選單";
            btnReturnMenu.UseVisualStyleBackColor = true;
            btnReturnMenu.Click += btnReturnMenu_Click;
            // 
            // lblDiceGame
            // 
            lblDiceGame.AutoSize = true;
            lblDiceGame.Location = new Point(385, 42);
            lblDiceGame.Name = "lblDiceGame";
            lblDiceGame.Size = new Size(69, 19);
            lblDiceGame.TabIndex = 5;
            lblDiceGame.Text = "骰子遊戲";
            // 
            // pictureBoxPlayerDice
            // 
            pictureBoxPlayerDice.BackgroundImageLayout = ImageLayout.Center;
            pictureBoxPlayerDice.Location = new Point(38, 166);
            pictureBoxPlayerDice.Name = "pictureBoxPlayerDice";
            pictureBoxPlayerDice.Size = new Size(200, 200);
            pictureBoxPlayerDice.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayerDice.TabIndex = 6;
            pictureBoxPlayerDice.TabStop = false;
            // 
            // pictureBoxComputerDice
            // 
            pictureBoxComputerDice.Location = new Point(751, 166);
            pictureBoxComputerDice.Name = "pictureBoxComputerDice";
            pictureBoxComputerDice.Size = new Size(200, 200);
            pictureBoxComputerDice.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxComputerDice.TabIndex = 7;
            pictureBoxComputerDice.TabStop = false;
            // 
            // FormDiceGame
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 1053);
            Controls.Add(pictureBoxComputerDice);
            Controls.Add(pictureBoxPlayerDice);
            Controls.Add(lblDiceGame);
            Controls.Add(btnReturnMenu);
            Controls.Add(btnRollDice);
            Controls.Add(lblDiceResult);
            Controls.Add(lblComputerDice);
            Controls.Add(lblPlayerDice);
            Name = "FormDiceGame";
            Text = "FormDiceGame";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerDice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputerDice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerDice;
        private Label lblComputerDice;
        private Label lblDiceResult;
        private Button btnRollDice;
        private Button btnReturnMenu;
        private Label lblDiceGame;
        private PictureBox pictureBoxPlayerDice;
        private PictureBox pictureBoxComputerDice;
    }
}