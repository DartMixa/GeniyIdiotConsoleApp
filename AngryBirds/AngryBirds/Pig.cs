namespace AngryBirds
{
    internal class Pig: Ball
    {
        public Pig(Form form)
        {
            radius = 30;
            Position = new(random.Next(radius + 50, form.ClientSize.Width - radius), random.Next(radius, form.ClientSize.Height - radius - 50));
            brush = Brushes.Green;
        }
    }
}
