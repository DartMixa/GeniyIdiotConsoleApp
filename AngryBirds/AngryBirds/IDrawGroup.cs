namespace AngryBirds
{
    public interface IDrawGroup
    {
        public void Draw(Graphics graphics) { }
        public void AddObject(ISprite obj) { }
        public void RemoveObject(ISprite obj) { }
        public void Update() { }
    }
}
