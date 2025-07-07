namespace BallsClassLibrary
{
    public class Particle : Ball
    {
        Random random = new Random();
        public Particle(List<Ball> balls, int x, int y, int radius) : base(balls)
        {
            this.cord.x = x;
            this.cord.y = y;
            this.radius = radius;
            brush = Brushes.Yellow;
            Angle = random.Next(0, 360);
            Speed = random.Next(5, 20);
        }
        public override void Go()
        {
            base.Go();
            radius -= 3;
            if (radius <= 0)
            {
                Kill();
            }
        }
    }
}
