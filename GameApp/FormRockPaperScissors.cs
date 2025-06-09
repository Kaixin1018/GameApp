using System;
using System.Numerics;
using System.Windows.Forms;

namespace GameApp
{
    public partial class FormRockPaperScissors : Form
    {
        private Player player1 = new Player("玩家 1");
        private Player player2 = new Player("玩家 2");

        public FormRockPaperScissors()
        {
            InitializeComponent();
            lblPlayer1Choice.Visible = false; // 讓玩家 1 的選擇
        }

        private void PlayerSelect(Player player, string choice)
        {
            player.Choice = choice;

            if (player == player1)
            {
                lblPlayer1Choice.Visible = false; // 玩家 1 的選擇仍然隱藏

            }

            if (!string.IsNullOrEmpty(player1.Choice) && !string.IsNullOrEmpty(player2.Choice))
            {
                lblPlayer1Choice.Visible = true; // 當玩家 2 選擇後才顯示玩家 1 的選擇
                lblPlayer1Choice.Text = "玩家 1 選擇：" + player1.Choice;
                lblPlayer2Choice.Text = "玩家 2 選擇：" + player2.Choice;
                CheckWinner();
            }
        }

        private void ResetGame()
        {
            player1.ResetChoice();
            player2.ResetChoice();

            lblPlayer1Choice.Text = "玩家 1 選擇：";
            lblPlayer2Choice.Text = "玩家 2 選擇：";
            lblResult.Text = "比賽結果：";

            lblPlayer1Choice.Visible = false; // 隱藏玩家 1 的選擇
        }
        private async void CheckWinner()
        {
            if (player1.Choice == player2.Choice)
                lblResult.Text = "平手！";
            else if ((player1.Choice == "Rock" && player2.Choice == "Scissors") ||
                     (player1.Choice == "Paper" && player2.Choice == "Rock") ||
                     (player1.Choice == "Scissors" && player2.Choice == "Paper"))
            {
                lblResult.Text = "玩家 1 贏了！";
                player1.Score++;
            }
            else
            {
                lblResult.Text = "玩家 2 贏了！";
                player2.Score++;
            }

            lblPlayer1Score.Text = $"玩家 1 分數：{player1.Score}";
            lblPlayer2Score.Text = $"玩家 2 分數：{player2.Score}";

            await Task.Delay(2000); // 等待 2 秒後重新開始
            ResetGame();
        }

        private void btnPlayer1Rock_Click(object sender, EventArgs e) => PlayerSelect(player1, "Rock");
        private void btnPlayer2Rock_Click(object sender, EventArgs e) => PlayerSelect(player2, "Rock");

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close(); // 返回選單
        }

        private void btnPlayer1Paper_Click(object sender, EventArgs e) => PlayerSelect(player1, "Paper");


        private void btnPlayer2Paper_Click(object sender, EventArgs e) => PlayerSelect(player2, "Paper");

        private void btnPlayer1Scissors_Click(object sender, EventArgs e) => PlayerSelect(player1, "Scissors");

        private void btnPlayer2Scissors_Click(object sender, EventArgs e) => PlayerSelect(player2, "Scissors");

        private void FormRockPaperScissors_Load(object sender, EventArgs e)
        {

        }
    }
}
