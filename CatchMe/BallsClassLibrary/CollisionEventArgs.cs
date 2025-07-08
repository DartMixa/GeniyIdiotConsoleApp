namespace BallsClassLibrary
{
    public class CollisionEventArgs
    {
        public Side Side;
        public Col Color;
        public CollisionEventArgs(Side side, Col color) 
        {
            Side = side;
            Color = color;
        }
    }
}
