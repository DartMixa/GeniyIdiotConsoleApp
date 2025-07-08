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

            i = 0;
            while (i < balls.Count)
            {
                var ball = balls[i];
                if (ball.SegmentCollision(MouseCord, ondMouseCord))
                {
                    ball.Kill();
                }
                i += 1;
            }
            
            //bufferGraphics.DrawLine(Pens.Black, new(MouseCord.x, MouseCord.y), new(ondMouseCord.x, ondMouseCord.y));

            ondMouseCord = MouseCord;

            graphics.DrawImage(buffer, 0, 0);
        }
        private void FruitSpawnTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                var ball = new FruitBall(balls, this);
                balls.Add(ball);
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MouseCord = (e.X, e.Y);
        }
    }
}
