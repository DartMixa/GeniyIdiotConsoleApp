using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CatchMe
{
    public class Ball
    {
        protected int x = 10;
        protected int y = 10;
        protected int size = 50;
        protected (int, int) vel = (10, 10);

        public List<Ball> balls;
        public Ball(List<Ball> balls) 
        {
            this.balls = balls;
        }
        public void Draw(Graphics graphics)
        {
            var brush = Brushes.Aqua;
            var rect = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rect);
        }
        public void Go()
        {
            x += vel.Item1;
            y += vel.Item2;
        }
        public void Kill()
        {
            balls.Remove(this);
        }
        public bool IsOnForm(Form form) 
        {
            if (x + size < 0 | y + size < 0)
            {
                return false;
            }
            else if (x - size > form.ClientSize.Width | y - size > form.ClientSize.Height)
            {
                return false;
            }
            return true;
        }
    }
}
