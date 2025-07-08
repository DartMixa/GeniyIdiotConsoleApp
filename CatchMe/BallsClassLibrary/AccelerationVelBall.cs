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
    public class PointAccelVelBall : AccelerationVelBall
    {
        public PointAccelVelBall(List<Ball> balls, int x, int y) : base(balls)
        {
            cord.x = x;
            cord.y = y;
        }
    }
    public class FireworkBall : PointAccelVelBall
    {
        private List<Brush> brushes = [Brushes.Thistle, 
            Brushes.Aqua,
            Brushes.Aquamarine, 
            Brushes.BlueViolet, 
            Brushes.BlanchedAlmond, 
            Brushes.Blue, 
            Brushes.BurlyWood,
            Brushes.Coral,
            Brushes.DarkCyan
        ];
        public FireworkBall(List<Ball> balls, int x, int y) : base(balls, x, y)
        {
            brush = brushes[random.Next(0, brushes.Count)];
        }
    }
}
