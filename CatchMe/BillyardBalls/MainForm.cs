using BallsClassLibrary;

namespace BillyardBalls
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

            graphics.DrawImage(buffer, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                balls.Add(new BilliardBall(balls, ClientSize.Width, ClientSize.Height, this));
            }
        }
    }
}
