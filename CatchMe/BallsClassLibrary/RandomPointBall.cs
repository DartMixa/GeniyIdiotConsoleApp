using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BallsClassLibrary
{
    public class RandomPointBall : Ball
    {
        public RandomPointBall(List<Ball> balls, int witch, int height) : base(balls)
        {
            cord.x = random.Next(radius, witch - radius);
            cord.y = random.Next(radius, height - radius);
        }
    }
}
