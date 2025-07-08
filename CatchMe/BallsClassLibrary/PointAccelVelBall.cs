namespace BallsClassLibrary
{
    public class PointAccelVelBall : AccelerationVelBall
    {
        public PointAccelVelBall(List<Ball> balls, int x, int y) : base(balls)
        {
            cord.x = x;
            cord.y = y;
        }
    }
}
