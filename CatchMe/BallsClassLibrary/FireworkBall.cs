using System;

namespace BallsClassLibrary
{
    public class FireworkBall : PointAccelVelBall
    {
        public FireworkBall(List<Ball> balls, int x, int y) : base(balls, x, y)
        {
            brush = RandomBrush.Next();
        }
    }
}
