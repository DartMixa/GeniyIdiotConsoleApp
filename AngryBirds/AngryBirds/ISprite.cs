namespace AngryBirds
{
    public interface ISprite
    {
        public void Draw(Graphics graphics) { }
        public void AddGroup(IDrawGroup group) { }
        public void RemoveGroup(IDrawGroup group) { }
        public void Kill() { }
        public void Update() { }
    }
}
