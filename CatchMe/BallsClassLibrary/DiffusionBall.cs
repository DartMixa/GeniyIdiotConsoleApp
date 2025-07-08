using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsClassLibrary
{
    public class DiffusionBall : BilliardBall
    {
        public DiffusionBall(List<Ball> balls, Form form, Brush brush, Rectangle rect) : base(balls, 1000, 1000, form)
        {
            this.brush = brush;
            cord.x = random.Next(rect.Left + 5, rect.Right - 5);
            cord.y = random.Next(rect.Top + 5, rect.Bottom - 5);
            Speed = random.Next(2, 5);
            radius = 5;
            color = brush == Brushes.Blue ? Col.blue : Col.red;
        }
    }
}
