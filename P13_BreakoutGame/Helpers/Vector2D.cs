using System;
using System.Drawing;

namespace P13_BreakoutGame.Helper
{
    /// <summary>
    /// A two dimensional vector.
    /// </summary>
    public class Vector2D
    {
        /// <summary>
        /// Trivial constructor.
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public Vector2D(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        // properties

        /// <summary>
        /// The X coordinate of the vector.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// The Y coordinate of the vector.
        /// </summary>
        public double Y { get; set; }

        // methods

        /// <summary>
        /// Returns the nearest point.
        /// </summary>
        /// <returns></returns>
        public Point ToPoint()
        {
            return new Point(Convert.ToInt32(Math.Round(X, 0)), Convert.ToInt32(Math.Round(Y, 0)));
        }
    }
}
