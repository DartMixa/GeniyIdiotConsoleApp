namespace BallsClassLibrary
{
    public class RandomBrush
    {
        static private List<Brush> brushes = [Brushes.Thistle,
            Brushes.Aqua,
            Brushes.Aquamarine,
            Brushes.BlueViolet,
            Brushes.BlanchedAlmond,
            Brushes.Blue,
            Brushes.BurlyWood,
            Brushes.Coral,
            Brushes.DarkCyan
        ];
        static private Random random = new();
        static public Brush Next() 
        {
            return brushes[random.Next(0, brushes.Count)];
        }
    }
}
