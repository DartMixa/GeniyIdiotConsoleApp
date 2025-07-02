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

        protected Brush brush = Brushes.Aqua;
        public List<Ball> balls;
        public Ball(List<Ball> balls) 
        {
            this.balls = balls;
        }
        public void Draw(Graphics graphics)
        {
            
            var rect = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rect);
        }
        public virtual void Go()
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
        public bool PointCollision(int x, int y) 
        {
            if ((Math.Pow((this.x - x + size / 2), 2) + Math.Pow((this.y - y + size / 2), 2)) < Math.Pow(size / 2, 2))
            {
                return true;
            }
            return false;
        }
    }
}
