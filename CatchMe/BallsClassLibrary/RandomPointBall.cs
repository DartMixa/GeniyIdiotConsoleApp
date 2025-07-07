using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BallsClassLibrary
{
    public class RandomPointBall : Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(List<Ball> balls, int witch, int height) : base(balls)
        {
            cord.x = random.Next(0, witch);
            cord.y = random.Next(0, height);
        }
    }
}
