using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsClassLibrary
{
    public class FruitBall : AccelerationVelBall
    {
        public FruitBall(List<Ball> balls, Form form) : base(balls)
        {
            cord = (random.Next(form.ClientSize.Width / 4, form.ClientSize.Width - form.ClientSize.Width / 4), form.ClientSize.Height);
            Angle = random.Next(180 + 70, 360 - 70);
            Speed = random.Next(20, 30);
            radius = random.Next(20, 30);
            brush = RandomBrush.Next();
            Acceleration = new(0, 1f);
        }
    }
}
