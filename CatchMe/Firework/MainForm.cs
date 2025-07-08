using BallsClassLibrary;

namespace Firework
{
    public partial class MainForm : Form
    {
        public List<Ball> balls = [];
        public Graphics graphics;

        Bitmap buffer;
        public Graphics bufferGraphics;
        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.ResizeRedraw |
              ControlStyles.ContainerControl |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.SupportsTransparentBackColor
              , true);
            UpdateTimer.Start();
            graphics = CreateGraphics();
            buffer = new(ClientSize.Width, ClientSize.Height);
            bufferGraphics = Graphics.FromImage(buffer);
        }
        public void Clear()
        {
            bufferGraphics.Clear(Color.White);
        }

        private void Update(object sender, EventArgs e)
        {
            Clear();
            int i = 0;
            while (i < balls.Count)
            {
                var ball = balls[i];
                if (!ball.IsOnForm(this))
                {
                    ball.Kill();
                }
                i++;
            }
            foreach (var ball in balls)
            {

                ball.Go();
                ball.Draw(bufferGraphics);
            }

            graphics.DrawImage(buffer, 0, 0);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            Random random = new();
            for (int i = 0; i < random.Next(5, 12); i++)
            {
                var ball = new FireworkBall(balls, e.X, e.Y);
                balls.Add(ball);
            }
        }

        private void rocketTimer_Tick(object sender, EventArgs e)
        {
            Random random = new();
            rocketTimer.Interval = random.Next(600, 1000);
            var ball = new RocketBall(balls, this);
            balls.Add(ball);
            ball.BoomEvent += Ball_BoomEvent;
        }

        private void Ball_BoomEvent(object sender, BoomEventArgs e)
        {
            Random random = new();
            for (int i = 0; i < random.Next(5, 12); i++)
            {
                var ball = new FireworkBall(balls, e.cord.x, e.cord.y);
                balls.Add(ball);
            }
            ((Ball)sender).Kill();
        }
    }
}
