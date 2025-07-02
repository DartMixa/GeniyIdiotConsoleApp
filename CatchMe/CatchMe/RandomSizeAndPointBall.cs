namespace CatchMe
{
    public class RandomSizeAndPointBall : RandomPointBall 
    {
        public RandomSizeAndPointBall(List<Ball> balls, int witch, int height) : base(balls, witch, height) 
        {
            size = random.Next(20, 60); 
        }
    }
}
