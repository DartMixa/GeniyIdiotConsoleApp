namespace BallsClassLibrary
{
    public class FireworkBall : PointAccelVelBall
    {
        private List<Brush> brushes = [Brushes.Thistle, 
            Brushes.Aqua,
            Brushes.Aquamarine, 
            Brushes.BlueViolet, 
            Brushes.BlanchedAlmond, 
            Brushes.Blue, 
            Brushes.BurlyWood,
            Brushes.Coral,
            Brushes.DarkCyan
        ];
        public FireworkBall(List<Ball> balls, int x, int y) : base(balls, x, y)
        {
            brush = brushes[random.Next(0, brushes.Count)];
        }
    }
}
