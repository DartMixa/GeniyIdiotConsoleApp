namespace CatchMe
{
    class RandomVelBoll : RandomSizeAndPointBall 
    {
        public RandomVelBoll(MainForm form) : base(form) 
        {
            int angle = random.Next(0, 360);
            double angleRad = angle * 2 * Math.PI / 360;
            int randomSpeed = random.Next(5, 20);
            vel = ((int)Math.Round(randomSpeed * Math.Cos(angleRad)), (int)Math.Round(randomSpeed * Math.Sin(angleRad)));
        }
    }
}
