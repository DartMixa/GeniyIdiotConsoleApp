using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsClassLibrary
{
    public class BoomBall(List<Ball> balls, int witch, int height) : RandomVelBoll(balls, witch, height)
    {
        public List<Ball> Boom()
        {
            List<Ball> list = [];
            for (int i = 0; i < random.Next(3, 6); i++)
            {
                list.Add(new Particle(list, cord.x, cord.y, radius));
            }
            return list;
        }
    }
}
