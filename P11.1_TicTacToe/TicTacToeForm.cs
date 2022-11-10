using System;
using System.Drawing;
using System.Windows.Forms;

namespace P11._1_TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        //-------------------1---------------------

        private int result = 0;

        /// <summary>
        /// Returns the result: 1 - the first player wins, 2 - the second player wins, 0 - draw.
        /// </summary>
        /// <returns></returns>
        public int GetResult()
        {
            return result;
        }
        
        //----------------------------------------

        private const int N = 3;
        private const int SQURE_SIZE = 50;
        private const int PADDING_SIZE = 3;
        private const int UP_SIZE = 12;
        private const int LEFT_SIZE = 15;

        private TextBox winnerTextBox;

        private int[,] squers = new int[N, N];


        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            // size of the form
            Size = new Size(340, 230);

            // title of the form
            Text = "Tic Tac Toe";

            // the square buttons
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    var button = new Button
                    {
                        Name = $"Button{i}{j}",
                        Size = new Size(SQURE_SIZE, SQURE_SIZE),
                        TabStop = false,
                        Location = new Point(
                            (SQURE_SIZE + PADDING_SIZE) * i + LEFT_SIZE + PADDING_SIZE,
                            (SQURE_SIZE + PADDING_SIZE) * j + UP_SIZE + PADDING_SIZE),
                    };
                    button.Click += Button_Click;
                    Controls.Add(button);
                }
            }

            // the reset button
            var submitButton = new Button
            {
                Name = "SubmitButton",
                Text = "Submit",
                Font = new Font("Segoe UI", 12),
                Size = new Size(85, 30),
                Location = new Point(200, 50),
                TabStop = false
            };
            submitButton.Click += SubmitButton_Click;
            Controls.Add(submitButton);

            // the winner label
            var winnerLabel = new Label
            {
                Name = "WinnerLabel",
                Text = "Winner",
                Size = new Size(61, 21),
                Location = new Point(200, 110),
                Font = new Font("Segoe UI", 12)
            };
            Controls.Add(winnerLabel);

            // the winner text-box
            winnerTextBox = new TextBox
            {
                Name = "WinnerTextBox",
                Font = new Font("Segoe UI", 12),
                Size = new Size(18, 29),
                Location = new Point(267, 107),
                ReadOnly = true,
                TabStop = false
            };
            Controls.Add(winnerTextBox);
        }

        private int first = 0;

        private int turn = 0;

        private bool gameOn = true;

        private readonly string[] symbol = { "X", "O" };

        private void Button_Click(object sender, EventArgs e)
        {
            if (gameOn)
            {
                var senderButton = (sender as Button);
                var buttonName = senderButton.Name;
                var i = int.Parse(buttonName.Substring(buttonName.Length - 2, 1));
                var j = int.Parse(buttonName.Substring(buttonName.Length - 1));
                if (squers[i, j] == 0)
                {
                    squers[i, j] = turn + 1;
                    senderButton.Text = symbol[turn];
                    turn = (turn + 1) % 2;
                    Check();
                }
            }
        }

        private void Check()
        {
            Check(1);
            Check(2);
        }

        private void Check(int player)
        {
            if (squers[0, 0] == player && squers[0, 1] == player && squers[0, 2] == player
                || squers[1, 0] == player && squers[1, 1] == player && squers[1, 2] == player
                || squers[2, 0] == player && squers[2, 1] == player && squers[2, 2] == player
                || squers[0, 0] == player && squers[1, 0] == player && squers[2, 0] == player
                || squers[0, 1] == player && squers[1, 1] == player && squers[2, 1] == player
                || squers[0, 2] == player && squers[1, 2] == player && squers[2, 2] == player
                || squers[0, 0] == player && squers[1, 1] == player && squers[2, 2] == player
                || squers[0, 2] == player && squers[1, 1] == player && squers[2, 0] == player)
            {
                winnerTextBox.Text = symbol[player - 1];
                gameOn = false;
                result = player;
            }
        }

        private bool cancel = true;

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            cancel = false;
            Close();
        }

        private void TicTacToeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = cancel;
        }
    }
}

