using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameApp
{
    public partial class FormDiceGame : Form
    {
        private Random random = new Random();

        public FormDiceGame()
        {
            InitializeComponent();
        }

        private async void btnRollDice_Click(object sender, EventArgs e)
        {
            await AnimateDiceRoll(); // 播放動畫

            int playerDice = random.Next(1, 7);
            int computerDice = random.Next(1, 7);

            UpdateDiceImage(playerDice, computerDice); // 更新圖片

            lblPlayerDice.Text = $"玩家骰子：{playerDice}";
            lblComputerDice.Text = $"電腦骰子：{computerDice}";

            if (playerDice > computerDice)
                lblDiceResult.Text = "🎉 你贏了！";
            else if (playerDice < computerDice)
                lblDiceResult.Text = "😢 電腦贏了！";
            else
                lblDiceResult.Text = "🤝 平手！";
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close(); // 返回選單
        }

        private void UpdateDiceImage(int playerRoll, int computerRoll)
        {
            string playerPath = Path.Combine(Application.StartupPath, "Resources", $"dice{playerRoll}.png");
            string computerPath = Path.Combine(Application.StartupPath, "Resources", $"dice{computerRoll}.png");

            // 檢查圖片是否存在
            if (!File.Exists(playerPath) || !File.Exists(computerPath))
            {
                MessageBox.Show($"圖片不存在！請檢查 Resources 資料夾。\n玩家圖片路徑: {playerPath}\n電腦圖片路徑: {computerPath}");
                return; // 停止執行，避免程式崩潰
            }

            try
            {
                pictureBoxPlayerDice.Image = Image.FromFile(playerPath);
                pictureBoxComputerDice.Image = Image.FromFile(computerPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("圖片載入失敗：" + ex.Message);
            }
            string testPath = Path.Combine(Application.StartupPath, "Resources", "dice1.png");

           
        }

        private async Task AnimateDiceRoll()
        {
            string resourcesFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

            for (int i = 0; i < 10; i++)
            {
                int tempPlayerRoll = random.Next(1, 7);
                int tempComputerRoll = random.Next(1, 7);

                string playerPath = Path.Combine(resourcesFolder, $"dice{tempPlayerRoll}.png");
                string computerPath = Path.Combine(resourcesFolder, $"dice{tempComputerRoll}.png");

                if (File.Exists(playerPath) && File.Exists(computerPath))
                {
                    pictureBoxPlayerDice.Image = Image.FromFile(playerPath);
                    pictureBoxComputerDice.Image = Image.FromFile(computerPath);
                }

                pictureBoxPlayerDice.Refresh();
                pictureBoxComputerDice.Refresh();

                await Task.Delay(100);
            }
        }

    }
}