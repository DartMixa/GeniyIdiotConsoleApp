namespace CatchMe
{
    public class RandomSizeAndPointBall : RandomPointBall 
    {
        public RandomSizeAndPointBall(MainForm form) : base(form) 
        {
            size = random.Next(20, 60); 
        }
    }
}
