using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BallsClassLibrary
{
    public class AccelerationVelBall : Ball
    {
        protected Vector2 Acceleration = new(0, 0.2f);
        public AccelerationVelBall(List<Ball> balls) : base(balls)
        {
            radius = random.Next(5, 10);
            Speed = random.Next(5, 10);
            Angle = random.Next(180, 360);
        }
        public override void Go()
        {
            Vel += Acceleration;
            base.Go();
        }
    }
}
