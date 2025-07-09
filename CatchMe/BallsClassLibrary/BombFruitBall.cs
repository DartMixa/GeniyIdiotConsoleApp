namespace BallsClassLibrary
{
    public class BombFruitBall : FruitBall
    {
        public BombFruitBall(List<Ball> balls, Form form) : base(balls, form)
        {
            brush = Brushes.Black;
        }
    }
}
