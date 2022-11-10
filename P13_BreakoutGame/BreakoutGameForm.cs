using P13_BreakoutGame.Figures;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P13_BreakoutGame
{
    /// <summary>
    /// A break out game form.
    /// </summary>
    public partial class BreakoutGameForm : Form
    {
        // board size
        private const int BOARD_WIDTH = 790;
        private const int BOARD_HEIGHT = 400;

        // bricks matrix size
        private const int BRICKS_RAWS = 6;
        private const int BRICKS_COLUMNS = 8;

        // frames per second
        private const int FPS = 100;
        private const int WAITING = 1000 / FPS;

        // the game difficulty between 0 (exclude) and 1 (include). The greater - the more difficult.
        private const double DIFFICULTY = 1;

        // graphics
        private readonly Bitmap image;
        private readonly Graphics graphics;

        // clock
        private readonly Timer ticTacTimer = new Timer();

        // the game
        private Game game;

        /// <summary>
        /// Trivial constructor.
        /// </summary>
        public BreakoutGameForm()
        {
            InitializeComponent();

            // set clock
            ticTacTimer.Interval = WAITING;
            ticTacTimer.Tick += TicTacTimer_Tick;

            // set graphics
            image = new Bitmap(BOARD_WIDTH, BOARD_HEIGHT);
            graphics = Graphics.FromImage(image);
        }

        // the picture box
        private PictureBox pictureBox;

        /// <summary>
        /// Invokes on load of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BreakoutGameForm_Load(object sender, System.EventArgs e)
        {
            Text = "Breakout";

            // set the auto size
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoSize = true;

            // set the picture box
            pictureBox = new PictureBox
            {
                Size = new Size(BOARD_WIDTH, BOARD_HEIGHT),

            };
            Controls.Add(pictureBox);

            // create a game
            game = new Game(BOARD_WIDTH, BOARD_HEIGHT, BRICKS_RAWS, BRICKS_COLUMNS, DIFFICULTY);

            // start the clock
            ticTacTimer.Start();
        }

        // true if the left or right arrows, respectively, were pressed
        private bool toLeft = false;
        private bool toRight = false;

        /// <summary>
        /// Invokes at the end of each clock cycle and draws the new state of the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicTacTimer_Tick(object sender, EventArgs e)
        {
            // stop the clock
            ticTacTimer.Stop();

            // move the plate
            game.PlateMove(toLeft, toRight);

            // move the ball
            game.BallMove();

            // draw the board
            game.Draw(graphics);

            // display the new image
            pictureBox.Image = image;

            // start the clock
            ticTacTimer.Start();
        }

        /// <summary>
        /// Invokes when the a key gets down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BreakoutGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            // if left arrow
            if (e.KeyCode == Keys.Left)
            {
                toLeft = true;
            }
            // if right arrow
            else if (e.KeyCode == Keys.Right)
            {
                toRight = true;
            }
        }

        /// <summary>
        /// Invokes when a key gets up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BreakoutGameForm_KeyUp(object sender, KeyEventArgs e)
        {
            // if left arrow
            if (e.KeyCode == Keys.Left)
            {
                toLeft = false;
            }
            // if right arrow
            else if (e.KeyCode == Keys.Right)
            {
                toRight = false;
            }
        }
    }
}
