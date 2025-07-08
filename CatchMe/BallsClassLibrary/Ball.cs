using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BallsClassLibrary
{
    public class Ball
    {
        public List<Ball> balls;

        public (int x, int y) cord = (10, 10);
        protected int radius = 25;

        protected Brush brush = Brushes.Aqua;

        private int speed = 10;
        private int angle = 0;
        private Vector2 vel = new(10, 10);

        protected Vector2 Vel { get { return vel; } set { vel = value; } }
        protected int Speed {
            get { return speed; } 
            set 
            {
                speed = value;
                UpdateVel();
            }
        }
        protected int Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                UpdateVel();
            }
        }

        public Ball(List<Ball> balls) 
        {
            this.balls = balls;
        }
        public void Draw(Graphics graphics)
        {
            var rect = new Rectangle(cord.x - radius, cord.y - radius, radius * 2, radius * 2);
            graphics.FillEllipse(brush, rect);
        }
        public virtual void Go()
        {
            cord.x += (int)vel.X;
            cord.y += (int)vel.Y;
        }
        public void Kill()
        {
            balls.Remove(this);
        }
        public bool IsOnForm(Form form)
        {
            if (cord.x + radius < 0 | cord.y + radius < 0)
            {
                return false;
            }
            else if (cord.x - radius > form.ClientSize.Width | cord.y - radius > form.ClientSize.Height)
            {
                return false;
            }
            return true;
        }
        public bool PointCollision(int x, int y)
        {
            if ((Math.Pow((this.cord.x - x), 2) + Math.Pow((this.cord.y - y), 2)) < Math.Pow(radius, 2))
            {
                return true;
            }
            return false;
        }
        private void UpdateVel()
        {
            double angleRad = Angle * 2 * Math.PI / 360;
            vel = new((int)Math.Round(Speed * Math.Cos(angleRad)), (int)Math.Round(Speed * Math.Sin(angleRad)));
        }
    }
}
