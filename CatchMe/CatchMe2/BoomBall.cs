using CatchMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchMe2
{
    internal class BoomBall(List<Ball> balls, int witch, int height) : RandomVelBoll(balls, witch, height)
    {
        public List<Ball> Boom()
        {
            List<Ball> list = [];
            for (int i = 0; i < random.Next(3, 6); i++)
            {
                list.Add(new Particle(list, x, y, size));
            }
            return list;
        }
    }
    public class Particle : Ball
    {
        Random random = new Random();
        public Particle(List<Ball> balls, int x, int y, int size) : base(balls)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            brush = Brushes.Yellow;
            int angle = random.Next(0, 360);
            double angleRad = angle * 2 * Math.PI / 360;
            int randomSpeed = random.Next(5, 20);
            vel = ((int)Math.Round(randomSpeed * Math.Cos(angleRad)), (int)Math.Round(randomSpeed * Math.Sin(angleRad)));
        }
        public override void Go()
        {
            base.Go();
            size -= 5;
            if (size <= 0)
            {
                Kill();
            }
        }
    }
}
