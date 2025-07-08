namespace BallsClassLibrary
{
    public class RandomVelBoll : RandomSizeAndPointBall
    {
        public RandomVelBoll(List<Ball> balls, int witch, int height) : base(balls, witch, height)
        {
            Angle = random.Next(0, 360);
            Speed = random.Next(5, 20);
        }
    }
}
