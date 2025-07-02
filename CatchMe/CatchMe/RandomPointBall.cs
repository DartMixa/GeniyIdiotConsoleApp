namespace CatchMe
{
    public class RandomPointBall : Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(List<Ball> balls, int witch, int height) : base(balls)
        {
            x = random.Next(0, witch - size);
            y = random.Next(0, height - size);
        }
    }
}
