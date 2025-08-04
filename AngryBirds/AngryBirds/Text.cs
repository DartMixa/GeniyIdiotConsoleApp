namespace AngryBirds
{
    public class Text : ISprite
    {
        private List<IDrawGroup> list = [];

        private (int x, int y) cord;
        private Brush brush;
        private System.Drawing.Font font;
        private string txt;
        public Text(int x, int y, Brush brush, System.Drawing.Font font, string txt = "")
        {
            cord = (x, y);
            this.brush = brush;
            this.font = font;
            this.txt = txt;
        }
        public void Draw(Graphics graphics)
        {
            graphics.DrawString(txt, font, brush, cord.x, cord.y);
        }
        public void AddGroup(IDrawGroup group)
        {
            list.Add(group);
        }
        public void RemoveGroup(IDrawGroup group)
        {
            list.Remove(group);
        }
        public void Kill()
        {
            while (list.Count != 0)
            {
                list[0].RemoveObject(this);
            }
            list.Clear();
        }
        public void Update() { }
    }
}
