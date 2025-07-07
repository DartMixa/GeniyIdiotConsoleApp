namespace BallsClassLibrary
{
    public class PointBall : Ball
    {
        public PointBall(List<Ball> balls, int x, int y) : base(balls) 
        {
            this.cord.x = x - radius;
            this.cord.y = y - radius;
        }
    }
}
