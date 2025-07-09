using BallsClassLibrary;

namespace FruitNinja
{
    public partial class MainForm : Form
    {
        public List<Ball> balls = [];
        public Graphics graphics;

        Bitmap buffer;
        public Graphics bufferGraphics;
        (int x, int y) ondMouseCord = (0, 0);
        (int x, int y) MouseCord = (0, 0);
        private Counter lossCounter;

        bool slow = false;

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

            var font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lossCounter = new(10, 10, Brushes.Red, font, "Пропущено: ");
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
                    lossCounter.Add();
                }
                i++;
            }
            foreach (var ball in balls)
            {
                ball.Go();
                ball.Draw(bufferGraphics);
            }

            i = 0;
            while (i < balls.Count)
            {
                var ball = balls[i];
                if (ball.SegmentCollision(MouseCord, ondMouseCord))
                {
                    if (ball.GetType() == typeof(BombFruitBall))
                    {
                        Close();
                    }
                    if (ball.GetType() == typeof(BananaFruitBall))
                    {
                        Slowdown();
                    }
                    ball.Kill();
                }
                i += 1;
            }

            lossCounter.Draw(bufferGraphics);

            //bufferGraphics.DrawLine(Pens.Black, new(MouseCord.x, MouseCord.y), new(ondMouseCord.x, ondMouseCord.y));

            ondMouseCord = MouseCord;

            graphics.DrawImage(buffer, 0, 0);
        }
        private void Slowdown()
        {
            if (!slow)
            {
                foreach (var ball in balls)
                {
                    ball.Slowdown();
                }
            }
            slow = true;
            SlowdownTimer.Stop();
            SlowdownTimer.Start();

        }
        private void FruitSpawnTimer_Tick(object sender, EventArgs e)
        {
            var newBalls = new List<Ball>();
            for (int i = 0; i < 3; i++)
            {
                var ball = new FruitBall(balls, this);
                newBalls.Add(ball);
            }
            var random = new Random();
            if (random.Next(0, 6) == 0)
            {
                var ball = new BombFruitBall(balls, this);
                newBalls.Add(ball);
            }
            if (random.Next(0, 6) == 0)
            {
                var ball = new BananaFruitBall(balls, this);
                newBalls.Add(ball);
            }

            if (slow)
            {
                foreach (var item in newBalls)
                {
                    item.Slowdown();
                }
            }

            balls.AddRange(newBalls);
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MouseCord = (e.X, e.Y);
        }

        private void SlowdownTimer_Tick(object sender, EventArgs e)
        {
            slow = false;
            foreach (var ball in balls)
            {
                ball.Boost();
            }
        }
    }
}
