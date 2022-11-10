using P13_BreakoutGame.Helper;
using System;
using System.Drawing;

namespace P13_BreakoutGame
{
    /// <summary>
    /// A drawable figure component of the game.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Trivial constructor.
        /// </summary>
        /// <param name="position">The top-left corner of the figure.</param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        protected Figure(Vector2D position, Size size, Color color)
        {
            Position = position;
            Size = size;
            Brush = new SolidBrush(color);
            SetSide();
        }

        // properties

        /// <summary>
        /// The top-left corner of the figure.
        /// </summary>
        public Vector2D Position { get; }

        /// <summary>
        /// The size of the figure.
        /// </summary>
        public Size Size { get; private set; }

        /// <summary>
        /// The brush to draw the figure.
        /// </summary>
        public Brush Brush { get; }

        /// <summary>
        /// The X coordinate of the left side of the figure.
        /// </summary>
        public double LeftSide { get; private set; }

        /// <summary>
        /// The X coordinate of the right side of the figure.
        /// </summary>
        public double RightSide { get; private set; }

        /// <summary>
        /// The Y coordinate of the top side of the figure.
        /// </summary>
        public double TopSide { get; private set; }

        /// <summary>
        /// The Y coordinate of the bottom side of the figure.
        /// </summary>
        public double BottomSide { get; private set; }

        // methods

        /// <summary>
        /// Computes the horizontal and vertical edges of the figure.
        /// </summary>
        public void SetSide()
        {
            LeftSide = Position.X;
            TopSide = Position.Y;
            RightSide = LeftSide + Size.Width;
            BottomSide = TopSide + Size.Height;
        }

        /// <summary>
        /// Draws a rectangle.
        /// </summary>
        /// <param name="graphics"></param>
        public virtual void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brush, new Rectangle(Position.ToPoint(), Size));

        }

        /// <summary>
        /// Returns the X and Y coordinates of the nearest edges of the figure to a point.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public virtual (double nearestX, double nearestY) Nearest(Vector2D point)
        {
            return (
                point.X < LeftSide ? LeftSide : (point.X > RightSide ? RightSide : point.X),
                point.Y > BottomSide ? BottomSide : (point.Y < TopSide ? TopSide : point.Y));
        }

        /// <summary>
        /// Computes the bounce of the collusion of a point with a given direction.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="nearestX"></param>
        /// <param name="nearestY"></param>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        public void Bounce(Vector2D point, double nearestX, double nearestY, ref double dx, ref double dy)
        {
            var disX = Math.Abs(point.X - nearestX);
            var disY = Math.Abs(point.Y - nearestY);

            if (disX == 0)
            {
                dy = -dy;
            }
            else if (disY == 0)
            {
                dx = -dx;
            }
            else if (disX == disY)
            {
                dx = -dx;
                dy = -dy;
            }
            else if (disX < disY)
            {
                dx = -dx;
            }
            else
            {
                dy = -dy;
            }
        }
    }
}
