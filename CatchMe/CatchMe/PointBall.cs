namespace CatchMe
{
    public class PointBall : Ball
    {
        public PointBall(List<Ball> balls, int x, int y) : base(balls) 
        {
            this.x = x - size / 2;
            this.y = y - size / 2;
        }
    }
}
