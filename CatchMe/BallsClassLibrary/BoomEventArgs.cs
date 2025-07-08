namespace BallsClassLibrary
{
    public class BoomEventArgs 
    {
        public (int x, int y) cord;

        public BoomEventArgs((int x, int y) cord)
        {
            this.cord = cord;
        }
    }
}
