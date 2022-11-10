using System;
using System.Windows.Forms;

namespace P10_ExMixDrix
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private const int N = 3;

        private int[,] squers = new int[N, N];

        private readonly string[] symbol = { "X", "O" };

        private int first = 0;

        private int player = 0;

        private bool gameOn = true;

        private void Button_Click(object sender, EventArgs e)
        {
            if (gameOn)
            {
                var senderButton = (sender as Button);

                var buttonName = senderButton.Name;
                var butttonIndex = buttonName.Substring(buttonName.Length - 1);
                var buttonNumber = int.Parse(butttonIndex);

                var i = buttonNumber / N;
                var j = buttonNumber % N;

                if (squers[i, j] == 0)
                {
                    var value = player + 1;

                    squers[i, j] = value;
                    senderButton.Text = symbol[player];

                    Check(value);

                    if(!gameOn)
                    {
                        WinnerTextBox.Text = symbol[player];
                    }

                    player = (player + 1) % 2;
                }
            }
        }

        private void Check(int value)
        {
            if (squers[0, 0] == value && squers[0, 1] == value && squers[0, 2] == value
                || squers[1, 0] == value && squers[1, 1] == value && squers[1, 2] == value
                || squers[2, 0] == value && squers[2, 1] == value && squers[2, 2] == value
                || squers[0, 0] == value && squers[1, 0] == value && squers[2, 0] == value
                || squers[0, 1] == value && squers[1, 1] == value && squers[2, 1] == value
                || squers[0, 2] == value && squers[1, 2] == value && squers[2, 2] == value
                || squers[0, 0] == value && squers[1, 1] == value && squers[2, 2] == value
                || squers[0, 2] == value && squers[1, 1] == value && squers[2, 0] == value)
            {
                gameOn = false;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            squers = new int[N, N];
            if (!gameOn)
            {
                first = (first + 1) % 2;
            }
            player = first;
            gameOn = true;
            foreach (Control ctrl in Controls)
            {
                if (ctrl.Name.Substring(0, 6) == "Button" || ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
    }
}
