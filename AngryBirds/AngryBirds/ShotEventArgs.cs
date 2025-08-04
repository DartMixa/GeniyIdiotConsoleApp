using System.Numerics;

namespace AngryBirds
{
    public class ShotEventArgs
    {
        public Vector2 Sight;

        public ShotEventArgs(Vector2 sight)
        {
            Sight = sight;
        }
    }
}
