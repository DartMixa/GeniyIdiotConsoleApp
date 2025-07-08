using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsClassLibrary
{
    public class RocketBall : PointAccelVelBall
    {
        private System.Windows.Forms.Timer BoomTimer = new();
        public event EventHandler<BoomEventArgs> BoomEvent;
        public RocketBall(List<Ball> balls, Form form) : base(balls, random.Next(0, form.ClientSize.Width), form.ClientSize.Height)
        {
            Angle = random.Next(180 + 45, 360 - 45);
            Speed = random.Next(10, 15);
            BoomTimer.Interval = 1000;
            BoomTimer.Start();
            BoomTimer.Tick += Boom;
        }

        private void Boom(object? sender, EventArgs e)
        {
            BoomEvent(this, new(cord));
        }
        public override void Kill()
        {
            base.Kill();
            BoomTimer.Dispose();
        }
    }
}
