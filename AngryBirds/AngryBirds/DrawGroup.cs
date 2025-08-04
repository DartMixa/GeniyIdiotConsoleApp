namespace AngryBirds
{
    internal class DrawGroup : IDrawGroup
    {
        private List<ISprite> list = [];
        private int currentIndex = -1;
        public int Count 
        {
            get => list.Count;
        }
        public void Draw(Graphics graphics) 
        {
            foreach (var item in list)
            {
                item.Draw(graphics);
            }
        }
        public void AddObject(ISprite obj) 
        {
            obj.AddGroup(this);
            list.Add(obj);
        }
        public void RemoveObject(ISprite obj) 
        {
            list.Remove(obj);
            obj.RemoveGroup(this);
        }
        public void Update() 
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Update();
            }
        }
        public ISprite this[int i]
        {
            get { return list[i]; }
        }
    }
}
