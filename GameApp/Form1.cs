namespace GameApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRockPaperScissors_Click(object sender, EventArgs e)
        {
            FormRockPaperScissors gameForm = new FormRockPaperScissors();
            gameForm.Show();
            this.Hide(); // ���åD���
        }

        private void btnDiceGame_Click(object sender, EventArgs e)
        {
            FormDiceGame diceForm = new FormDiceGame();
            diceForm.Show();
            this.Hide();
        }
    }
}
