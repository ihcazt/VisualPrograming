using P13_BreakoutGame.Helper;
using System;
using System.Drawing;

namespace P13_BreakoutGame.Figures
{
    /// <summary>
    /// A break out game.
    /// </summary>
    public class Game
    {
        // the board size
        private readonly int boardWidth;
        private readonly int boardHeight;

        /// <summary>
        /// Trivial constructor.
        /// </summary>
        /// <param name="boardWidth"></param>
        /// <param name="boardHeight"></param>
        /// <param name="brickRaws"></param>
        /// <param name="brickColumns"></param>
        public Game(int boardWidth, int boardHeight, int brickRaws, int brickColumns, double difficulty)
        {
            this.boardWidth = boardWidth;
            this.boardHeight = boardHeight;
            BrickRaws = brickRaws;
            BrickColumns = brickColumns;
            Difficulty = difficulty;
            Init();
        }

        // properties

        /// <summary>
        /// The number of the raws of bricks.
        /// </summary>
        public int BrickRaws { get; }

        /// <summary>
        /// The number of the columns of the bricks.
        /// </summary>
        public int BrickColumns { get; }

        /// <summary>
        /// The game difficulty.
        /// </summary>
        /// <remarks>
        /// Should be greater then zero.<br/>
        /// The greater - the more difficult.
        /// </remarks>
        public double Difficulty { get; }

        /// <summary>
        /// The game space.
        /// </summary>
        public Walls Walls { get; private set; }

        /// <summary>
        /// The game bricks.
        /// </summary>
        public Brick[,] Bricks { get; private set; }

        /// <summary>
        /// The game plate.
        /// </summary>
        public Plate Plate { get; private set; }

        /// <summary>
        /// The game ball.
        /// </summary>
        public Ball Ball { get; private set; }

        public void PlateMove(bool toLeft, bool toRight)
        {
            if (toLeft || toRight)
            {
                int direction = toLeft ? -1 : 1;
                var dist = direction * 10 * Difficulty;
                var toMove = (direction < 0) ? Plate.Position.X >= dist : boardWidth - (Plate.Position.X + Plate.Size.Width) >= dist;
                if (toMove)
                {
                    Plate.Position.X += dist;
                    Plate.SetSide();
                }
            }
        }

        public void BallMove()
        {
            Ball.Position.X += Ball.Direction.X * Difficulty;
            Ball.Position.Y += Ball.Direction.Y * Difficulty;

            Ball.Center.X = Ball.Position.X + Ball.Radius;
            Ball.Center.Y = Ball.Position.Y + Ball.Radius;

            for (int i = 0; i < BrickRaws; ++i)
            {
                for (int j = 0; j < BrickColumns; ++j)
                {
                    var brick = Bricks[i, j];
                    if (brick.State == Brick.States.Live && Collusion(brick))
                    {
                        brick.State = Brick.States.Dead;
                    }
                }
            }

            Collusion(Walls);
            Collusion(Plate);
        }

        /// <summary>
        /// Draws the game.
        /// </summary>
        /// <param name="graphics"></param>
        public void Draw(Graphics graphics)
        {
            // draw the board

            Walls.Draw(graphics);
            Plate.Draw(graphics);

            for (int i = 0; i < BrickRaws; ++i)
            {
                for (int j = 0; j < BrickColumns; ++j)
                {
                    var brick = Bricks[i, j];

                    if (brick.State == Brick.States.Live)
                    {
                        brick.Draw(graphics);
                    }
                }
            }

            Ball.Draw(graphics);
        }

        /// <summary>
        /// Initiates the game.
        /// </summary>
        private void Init()
        {
            Random random = new Random();

            Walls = new Walls(new Size(boardWidth, boardHeight), Color.AliceBlue);
            Ball = new Ball(new Vector2D(boardWidth / 2 - 10, boardHeight - 30), new Vector2D(-4, -4), 10, Color.Blue);
            Plate = new Plate(new Vector2D(boardWidth / 2 - 80, boardHeight - 10), new Size(160, 10), Color.OrangeRed);
            Bricks = new Brick[BrickRaws, BrickColumns];
            for (int i = 0; i < BrickRaws; ++i)
            {
                for (int j = 0; j < BrickColumns; ++j)
                {
                    Bricks[i, j] = new Brick(new Vector2D(5 + 100 * j, 40 + 30 * i), new Size(80, 10), 
                        Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
                }
            }
        }

        /// <summary>
        /// Handles a potential collusion of the ball with a figure.
        /// </summary>
        /// <param name="figure"></param>
        /// <returns>Returns true if there is a collusion.</returns>
        private bool Collusion(Figure figure)
        {
            (var nearestX, var nearestY) = figure.Nearest(Ball.Center);

            if (ColludeWith(nearestX, nearestY))
            {
                double dx = Ball.Direction.X;
                double dy = Ball.Direction.Y;

                figure.Bounce(Ball.Center, nearestX, nearestY, ref dx, ref dy);

                Ball.Direction.X = dx;
                Ball.Direction.Y = dy;

                return true;
            }

            return false;
        }

        /// <summary>
        /// Checks if the ball colludes with an horizontal or vertical lines.
        /// </summary>
        /// <param name="horizontalLine"></param>
        /// <param name="verticalLine"></param>
        /// <returns></returns>
        private bool ColludeWith(double horizontalLine, double verticalLine)
        {
            double dx = horizontalLine - Ball.Center.X;
            double dy = verticalLine - Ball.Center.Y;

            return dx * dx + dy * dy <= Ball.Radius * Ball.Radius;
        }
    }
}
