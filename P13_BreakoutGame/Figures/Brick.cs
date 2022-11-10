using P13_BreakoutGame.Helper;
using System.Drawing;

namespace P13_BreakoutGame
{
    /// <summary>
    /// A brick component.
    /// </summary>
    public class Brick : Figure
    {
        /// <summary>
        /// A break possible states.
        /// </summary>
        public enum States { Live, Dead }

        /// <summary>
        /// Trivial constructor.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        public Brick(Vector2D position, Size size, Color color)
            : base(position, size, color)
        {
            State = States.Live;
        }

        // properties

        /// <summary>
        /// The state of the brick.
        /// </summary>
        public States State { get; set; }
    }
}
