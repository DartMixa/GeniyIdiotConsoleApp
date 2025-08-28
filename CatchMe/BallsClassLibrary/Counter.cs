using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsClassLibrary
{
    public class Counter
    {
        private (int x, int y) cord;
        private Brush brush;
        private Font font;
        private int count;
        private string txt;
        public Counter(int x, int y, Brush brush, Font font, string txt = "")
        {
            cord = (x, y);
            this.brush = brush;
            this.font = font;
            count = 0;
            this.txt = txt;
        }
        public void Add()
        {
            count += 1;
        }
        public void Draw(Graphics graphics)
        {
            graphics.DrawString(txt + Convert.ToString(count), font, brush, cord.x, cord.y);
        }
    }
}
