using System;
using System.Collections.Generic;
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
        
        private MainForm form;
        public Ball(MainForm form)
        {
            this.form = form;
        }
        public void Draw()
        {
            var brush = Brushes.Aqua;
            var rect = new Rectangle(x, y, size, size);
            form.bufferGraphics.FillEllipse(brush, rect);
        }
        public void Go()
        {
            x += vel.Item1;
            y += vel.Item2;
        }
        public void Kill()
        {
            form.balls.Remove(this);
        }
        public bool IsOnForm() 
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
