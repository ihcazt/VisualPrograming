using System;
using System.Drawing;
using System.Windows.Forms;

namespace Othello
{
    public partial class OthelloForm : Form
    {
        public OthelloForm()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------------

        /// <summary>
        ///  The board size should be even >= 4.
        /// </summary>
        private const int BOARD_SIZE = 6;

        /// <summary>
        /// The players colors.
        /// </summary>
        private readonly Color[] colors = { Color.Red, Color.Blue };

        /// <summary>
        /// The size of a square.
        /// </summary>
        private const int SQUARE_SIZE = 60;

        // maximum points over all games.
        private int maxPoints = 0;

        // the points of the players
        private int[] points;

        // whose turn is?
        private int currentPlayer;

        // state
        private bool isFinished;

        // ------------------------------------------------------------------------

        // the board
        private readonly RoundedButton[,] board = new RoundedButton[BOARD_SIZE, BOARD_SIZE];

        // the empty square color
        private Color defaultColor;

        private int menuHight;
        /// <summary>
        /// Initiates the board.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OthelloForm_Load(object sender, EventArgs e)
        {
            menuHight = OthelloToolStripMenuItem.Size.Height;

            // set the client size
            ClientSize = new Size(BOARD_SIZE * SQUARE_SIZE, BOARD_SIZE * SQUARE_SIZE + menuHight);

            // automatic size
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;

            // initialize the board
            InitBoard();
        }

        private void InitBoard()
        {
            // the button size
            var buttonSize = new Size(SQUARE_SIZE, SQUARE_SIZE);

            // initialize the board
            for (int i = 0; i < BOARD_SIZE; ++i)
            {
                for (int j = 0; j < BOARD_SIZE; ++j)
                {
                    Controls.Remove(board[i, j]);

                    board[i, j] = new RoundedButton
                    {
                        Size = buttonSize,
                        Location = new Point(SQUARE_SIZE * i, SQUARE_SIZE * j + menuHight),
                        TabStop = false
                    };

                    // add handler to the click event
                    board[i, j].Click += Button_Click;

                    // add the square to the form
                    Controls.Add(board[i, j]);
                }
            }

            // set the empty square color
            defaultColor = board[0, 0].BackColor;

            // initialize the center square
            board[BOARD_SIZE / 2 - 1, BOARD_SIZE / 2 - 1].IsRournd = true;
            board[BOARD_SIZE / 2 - 1, BOARD_SIZE / 2 - 1].BackColor = colors[0];

            board[BOARD_SIZE / 2 - 1, BOARD_SIZE / 2].IsRournd = true;
            board[BOARD_SIZE / 2 - 1, BOARD_SIZE / 2].BackColor = colors[1];

            board[BOARD_SIZE / 2, BOARD_SIZE / 2 - 1].IsRournd = true;
            board[BOARD_SIZE / 2, BOARD_SIZE / 2 - 1].BackColor = colors[1];

            board[BOARD_SIZE / 2, BOARD_SIZE / 2].IsRournd = true;
            board[BOARD_SIZE / 2, BOARD_SIZE / 2].BackColor = colors[0];

            // the points of the players
            points = new int[] { 2, 2 };

            // whose turn is?
            currentPlayer = 0;

            // state
            isFinished = false;


            // add title
            Title();
        }

        /// <summary>
        /// Adds title.
        /// </summary>
        private void Title()
        {
            var state =
                isFinished ? (points[0] > points[1] ? colors[0].Name + " Wins" : (points[1] > points[0] ? colors[1].Name + " Wins" : "Draw")) : $"turn: {colors[currentPlayer].Name}";

            Text = $"Othello {colors[0].Name}: {points[0]} {colors[1].Name}: {points[1]} {state}";
        }

        // ------------------------------------------------------------------------

        /// <summary>
        /// The click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            // which button is clicked
            var button = sender as RoundedButton;

            // the button indexes
            var x = button.Bounds.X / SQUARE_SIZE;
            var y = button.Bounds.Y / SQUARE_SIZE;


            if (MoveMade(x, y))
            {
                // add the new move
                board[x, y].BackColor = colors[currentPlayer];
                board[x, y].IsRournd = true;
                ++points[currentPlayer];

                NextState();

                Title();
            }
        }

        /// <summary>
        /// Compute the next state.
        /// </summary>
        private void NextState()
        {
            currentPlayer = (currentPlayer + 1) % 2;

            if (!HasMove())
            {
                currentPlayer = (currentPlayer + 1) % 2;

                if (!HasMove())
                {
                    isFinished = true;

                    maxPoints = Math.Max(Math.Max(maxPoints, points[0]), points[1]);
                }
            }
        }

        /// <summary>
        /// Checks if the current player has a move.
        /// </summary>
        /// <returns></returns>
        private bool HasMove()
        {
            for (var x = 0; x < BOARD_SIZE; ++x)
            {
                for (var y = 0; y < BOARD_SIZE; ++y)
                {
                    if (board[x, y].BackColor.Equals(defaultColor))
                    {
                        for (int i = -1; i <= 1; ++i)
                        {
                            for (int j = -1; j <= 1; ++j)
                            {
                                if (ThereIsAFlip(x, y, i, j))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if a player move (click on the (x, y) square) is legal.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private bool MoveMade(int x, int y)
        {
            // if the square is not empty
            if (!board[x, y].BackColor.Equals(defaultColor))
            {
                return false;
            }

            var moveMade = false;

            // check in all directions if there is a flip of opponent squares
            for (int i = -1; i <= 1; ++i)
            {
                for (int j = -1; j <= 1; ++j)
                {
                    if (ThereIsAFlip(x, y, i, j))
                    {
                        Flip(x, y, i, j);
                        moveMade = true;
                    }
                }
            }

            return moveMade;
        }

        /// <summary>
        /// Checks if a move (click on an (x, y) square) of the current player flips squares of the opponent in (i, j) direction.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool ThereIsAFlip(int x, int y, int i, int j)
        {
            // not allowed zero direction
            if (i == 0 && j == 0)
            {
                return false;
            }

            // the first nearby square in the given direction
            var u = x + i;
            var v = y + j;

            // if the square is out of board
            if (u < 0 || u >= BOARD_SIZE || v < 0 || v >= BOARD_SIZE)
            {
                return false;
            }

            // the opponent color
            var opponentColor = colors[(currentPlayer + 1) % 2];

            // if the square doesn't belong to the opponent
            if (!board[u, v].BackColor.Equals(opponentColor))
            {
                return false;
            }

            // move to the end of the opponent squares in the given direction
            while (u + i >= 0 && u + i < BOARD_SIZE && v + j >= 0 && v + j < BOARD_SIZE && board[u + i, v + j].BackColor.Equals(opponentColor))
            {
                u += i;
                v += j;
            }

            // check if there is a current player square in at the end
            return u + i >= 0 && u + i < BOARD_SIZE && v + j >= 0 && v + j < BOARD_SIZE && board[u + i, v + j].BackColor.Equals(colors[currentPlayer]);
        }

        /// <summary>
        /// Flips after a current player move (click on a (x, y) square) the current player opponent squares in (i, j) direction. 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <remarks>Assumes the direction is legal.</remarks>
        private void Flip(int x, int y, int i, int j)
        {
            // the first nearby square in the given direction
            var u = x + i;
            var v = y + j;

            // the opponent player
            var opponentPlayer = (currentPlayer + 1) % 2;

            // the opponent color
            var opponentColor = colors[opponentPlayer];

            // move over all opponent squares in the given direction and flip them.
            while (board[u, v].BackColor.Equals(opponentColor))
            {
                board[u, v].BackColor = colors[currentPlayer];

                board[u, v].IsRournd = true;

                ++points[currentPlayer];

                --points[opponentPlayer];

                u += i;
                v += j;
            }
        }

        private void HallOfFameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hallOfFameForm = new HallOfFameForm();

            hallOfFameForm.SetNote($"Best score is {maxPoints}");

            hallOfFameForm.ShowDialog();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitBoard();
        }
    }
}
