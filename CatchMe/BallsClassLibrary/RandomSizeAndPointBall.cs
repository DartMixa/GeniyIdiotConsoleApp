namespace BallsClassLibrary
{
    public class RandomSizeAndPointBall : RandomPointBall 
    {
        public RandomSizeAndPointBall(List<Ball> balls, int witch, int height) : base(balls, witch, height) 
        {
            radius = random.Next(10, 30);
        }
    }
}
