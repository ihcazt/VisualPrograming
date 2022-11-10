using System.Windows.Forms;

namespace P11._1_TicTacToe
{
    public partial class TwoPlayersNamesForm : Form
    {
        public TwoPlayersNamesForm()
        {
            InitializeComponent();
        }

        public string GetFirstPlayerName()
        {
            return FirstPlayerNameTextBox.Text;
        }

        public string GetSecondPlayerName()
        {
            return SecondPlayerNameTextBox.Text;
        }

        public bool AreValid()
        {
            var firstPlayerName = GetFirstPlayerName();
            var secondPlayerName = GetSecondPlayerName();

            return firstPlayerName != "" && secondPlayerName != "" && firstPlayerName != secondPlayerName;

        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            if (AreValid())
            {
                Close();
            }
        }
    }
}
