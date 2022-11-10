using P13_BreakoutGame.Helper;
using System.Drawing;

namespace P13_BreakoutGame
{
    /// <summary>
    /// A space component.
    /// </summary>
    public class Walls : Figure
    {
        /// <summary>
        /// Trivial constructor.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="graphics"></param>
        public Walls(Size size, Color color)
            : base(new Vector2D(0, 0), size, color)
        {
        }

        public override (double nearestX, double nearestY) Nearest(Vector2D point)
        {
            var leftDist = point.X - LeftSide;
            var rightDist = RightSide - point.X;
            var topDist = point.Y - TopSide;
            var bottomDist = BottomSide - point.Y;
            double horizontalDist;
            double vericalDist;
            double nearestX;
            double nearestY;

            if (leftDist < rightDist)
            {
                nearestX = LeftSide;
                horizontalDist = leftDist;
            }
            else
            {
                nearestX = RightSide;
                horizontalDist = rightDist;

            }

            if (topDist < bottomDist)
            {
                nearestY = TopSide;
                vericalDist = topDist;
            }
            else
            {
                nearestY = BottomSide;
                vericalDist = bottomDist;

            }

            if(horizontalDist < vericalDist)
            {
                nearestY = point.Y;
            }
            else if(vericalDist < horizontalDist)
            {
                nearestX = point.X;
            }

            return (nearestX, nearestY);
        }
    }
}
