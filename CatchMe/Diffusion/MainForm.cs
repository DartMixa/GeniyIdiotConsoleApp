using BallsClassLibrary;
using System.Drawing;

namespace Diffusion
{
    public partial class Diffusion : Form
    {
        public List<Ball> balls = [];
        public Graphics graphics;

        Bitmap buffer;
        public Graphics bufferGraphics;

        public ((Counter left, Counter right, Counter top, Counter bottom) blue, (Counter left, Counter right, Counter top, Counter bottom) red) counters;

        public Diffusion()
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

            var font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

            counters.blue.left = new(10, ClientSize.Height / 2 - 10, Brushes.Blue, font);
            counters.blue.right = new(ClientSize.Width - 35, ClientSize.Height / 2 - 10, Brushes.Blue, font);
            counters.blue.top = new(ClientSize.Width / 2, 5, Brushes.Blue, font);
            counters.blue.bottom = new(ClientSize.Width / 2, ClientSize.Height - 20, Brushes.Blue, font);

            counters.red.left = new(10, ClientSize.Height / 2 + 10, Brushes.Red, font);
            counters.red.right = new(ClientSize.Width - 35, ClientSize.Height / 2 + 10, Brushes.Red, font);
            counters.red.top = new(ClientSize.Width / 2, 20, Brushes.Red, font);
            counters.red.bottom = new(ClientSize.Width / 2, ClientSize.Height - 35, Brushes.Red, font);
        }

        public void Clear()
        {
            bufferGraphics.Clear(Color.White);
        }

        private void Update(object sender, EventArgs e)
        {
            Clear();
            int i = 0;

            for (int boll1Nom = 0; boll1Nom < balls.Count; boll1Nom++)
            {
                for (int boll2Nom = boll1Nom; boll2Nom < balls.Count; boll2Nom++)
                {
                    ((BilliardBall)balls[boll1Nom]).BallCollision((BilliardBall)balls[boll2Nom]);
                }
            }

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

            counters.blue.left.Draw(bufferGraphics);
            counters.blue.right.Draw(bufferGraphics);
            counters.blue.top.Draw(bufferGraphics);
            counters.blue.bottom.Draw(bufferGraphics);

            counters.red.left.Draw(bufferGraphics);
            counters.red.right.Draw(bufferGraphics);
            counters.red.top.Draw(bufferGraphics);
            counters.red.bottom.Draw(bufferGraphics);

            graphics.DrawImage(buffer, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                var ball = new DiffusionBall(balls, this, Brushes.Blue, new Rectangle(0, 0, ClientSize.Width / 2, ClientSize.Height));
                balls.Add(ball);
                ball.OnCollision += Ball_OnCollision;
            }
            for (int i = 0; i < 100; i++)
            {
                var ball = new DiffusionBall(balls, this, Brushes.Red, new Rectangle(ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height));
                balls.Add(ball);
                ball.OnCollision += Ball_OnCollision;
            }
        }

        private void Ball_OnCollision(object? sender, CollisionEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    switch (e.Color)
                    {
                        case Col.red:
                            counters.red.left.Add();
                            break;
                        case Col.blue:
                            counters.blue.left.Add();
                            break;
                    }
                    break;
                case Side.Right:
                    switch (e.Color)
                    {
                        case Col.red:
                            counters.red.right.Add();
                            break;
                        case Col.blue:
                            counters.blue.right.Add();
                            break;
                    }
                    break;
                case Side.Top:
                    switch (e.Color)
                    {
                        case Col.red:
                            counters.red.top.Add();
                            break;
                        case Col.blue:
                            counters.blue.top.Add();
                            break;
                    }
                    break;
                case Side.Bottom:
                    switch (e.Color)
                    {
                        case Col.red:
                            counters.red.bottom.Add();
                            break;
                        case Col.blue:
                            counters.blue.bottom.Add();
                            break;
                    }
                    break;
            }
        }
    }
}
