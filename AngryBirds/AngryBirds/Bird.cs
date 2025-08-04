using Timer = System.Windows.Forms.Timer;

namespace AngryBirds
{
    internal class Bird : Ball
    {
        protected Form form;
        protected bool IsShot = false;
        private Timer DeathTimer = new();
        public event EventHandler<EventArgs>? Death;
        public Bird(Form form)
        {
            this.form = form;
            radius = 20;
            Position = new(radius, form.ClientSize.Height - radius);
            brush = Brushes.Red;
            DeathTimer.Enabled = false;
            DeathTimer.Interval = 3000;
            DeathTimer.Tick += DeathTimer_Tick;
            Death += death;
        }
        private void DeathTimer_Tick(object? sender, EventArgs e)
        {
            Death?.Invoke(this, new());
        }
        private void death(object? sender, EventArgs e)
        {
            DeathTimer.Dispose();
            this.Kill();
        }

        public void Shot(object sender, ShotEventArgs e)
        {
            if (!IsShot)
            {
                Velocity = -e.Sight * 3;
                Speed = (int)Math.Sqrt(Speed);
                Acceleration = new(0, 1f);
                IsShot = true;
                DeathTimer.Enabled=true;
            }
        }
        public override void Update()
        {
            base.Update();
            WallCollision();
        }
        public void WallCollision()
        {
            if (Position.Y >= form.ClientSize.Height - radius)
            {
                Velocity = new(Velocity.X, -Velocity.Y);
                Speed = (int)(Speed * 0.9);
            }
            if (Position.X >= form.ClientSize.Width + radius)
            {
                Death?.Invoke(this, new());
            }
            if (Position.X <= -radius)
            {
                Death?.Invoke(this, new());
            }
            if (Position.Y >= form.ClientSize.Height + radius)
            {
                Death?.Invoke(this, new());
            }
        }
        public bool BallsCollision(DrawGroup balls, out List<ISprite> collisions)
        {
            collisions = [];
            bool f = false;
            for (int i = 0; i < balls.Count; i++)
            {
                Ball ball = (Ball)balls[i];
                if ((Position - ball.Position).Length() < radius + ball.GetRadius())
                {
                    f = true;
                    collisions.Add(ball);
                }
            }
            return f;
        }
    }
}
