using System.Numerics;

namespace AngryBirds
{
    public class LineSight : ISprite
    {
        private Vector2 cord1 = new();
        private Vector2 cord2 = new();
        public event EventHandler<ShotEventArgs>? Shot;

        private bool visible = false;
        protected Brush brush = Brushes.Aqua;
        protected Pen pen = new(Color.Aqua, 5f);

        private int radius = 10;

        private List<IDrawGroup> list = [];
        public void Draw(Graphics graphics) 
        {
            if (visible)
            {
                var rect = new Rectangle((int)(cord1.X - radius), (int)(cord1.Y - radius), radius * 2, radius * 2);
                graphics.FillEllipse(brush, rect);

                rect = new Rectangle((int)(cord2.X - radius), (int)(cord2.Y - radius), radius * 2, radius * 2);
                graphics.FillEllipse(brush, rect);

                graphics.DrawLine(pen, new((int)cord1.X, (int)cord1.Y), new((int)cord2.X, (int)cord2.Y));
            }
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

        public void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            visible = true;
            cord1 = new(e.Location.X, e.Location.Y);
        }
        public void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            visible = false;
            cord2 = new(e.Location.X, e.Location.Y);
            Shot?.Invoke(this, new ShotEventArgs(cord2 - cord1));
        }
        public void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            cord2 = new(e.Location.X, e.Location.Y);
        }
    }
}
