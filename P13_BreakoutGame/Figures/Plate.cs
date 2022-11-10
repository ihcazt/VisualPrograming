using P13_BreakoutGame.Helper;
using System.Drawing;

namespace P13_BreakoutGame
{
    /// <summary>
    /// A plate component.
    /// </summary>
    public class Plate : Figure
    {
        public Plate(Vector2D position, Size size, Color color)
            : base(position, size, color)
        {
        }
    }
}
