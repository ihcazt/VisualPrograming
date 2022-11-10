using P13_BreakoutGame.Helper;
using System.Drawing;

namespace P13_BreakoutGame
{
    /// <summary>
    ///  A ball component.
    /// </summary>
    public class Ball : Figure
    {

        /// <summary>
        /// Trivial constructor.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="color"></param>
        public Ball(Vector2D position, Vector2D direction, int radius, Color color)
            : base(position, new Size(2 * radius, 2 * radius), color)
        {
            Center = new Vector2D(Position.X + radius, Position.Y + radius);
            Radius = radius;
            Direction = direction;
        }

        // properties

        /// <summary>
        /// The center of the ball.
        /// </summary>
        public Vector2D Center { get; set; }

        /// <summary>
        /// The radius of the ball.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Ball direction.
        /// </summary>
        public Vector2D Direction { get; set; }

        // methods

        /// <summary>
        /// Draws an ellipse.
        /// </summary>
        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brush, new Rectangle(Position.ToPoint(), Size));
        }
    }
}
