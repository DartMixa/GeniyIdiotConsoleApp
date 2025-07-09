namespace BallsClassLibrary
{
    public class BananaFruitBall : FruitBall
    {
        public BananaFruitBall(List<Ball> balls, Form form) : base(balls, form)
        {
            brush = Brushes.Yellow;
        }
    }
}
