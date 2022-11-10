using P11._1_TicTacToe;
using System;
using System.Windows.Forms;

namespace P14_MultiForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly TicTacToeRepository TicTacToeRepository = new TicTacToeRepository();

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
        }

        private void TicTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var playersNames = new TwoPlayersNamesForm();
            playersNames.ShowDialog();

            if (playersNames.AreValid())
            {
                var firstName = playersNames.GetFirstPlayerName();
                var secondName = playersNames.GetSecondPlayerName();

                var ticTacToe = new TicTacToeForm();
                ticTacToe.ShowDialog();
                var result = ticTacToe.GetResult();
                ticTacToe.Dispose();

                TicTacToeRepository.AddResult(firstName, result == 1 ? 1 : result == 2 ? -1 : 0);
                TicTacToeRepository.AddResult(secondName, result == 2 ? 1 : result == 1 ? -1 : 0);
            }
            
            playersNames.Dispose();
        }

        private void HallOfFameTicTacToeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hallOfFames = new TicTacToeHallOfFameFrame();
            hallOfFames.Add(TicTacToeRepository.Bests());
            hallOfFames.ShowDialog();
            hallOfFames.Dispose();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
