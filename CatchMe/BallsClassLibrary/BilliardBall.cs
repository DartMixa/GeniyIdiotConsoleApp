using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BallsClassLibrary
{
    public class BilliardBall : RandomVelBoll
    {
        Form form;
        protected Col color;
        public event EventHandler<CollisionEventArgs> OnCollision;
        public BilliardBall(List<Ball> balls, int witch, int height, Form form) : base(balls, witch, height)
        {
            this.form = form;
        }
        public override void Go()
        {
            (int x, int y) newCord = (cord.x + (int)Vel.X, cord.y + (int)Vel.Y);

            if (newCord.x - radius < 0)
            {
                OnCollision(this, new(Side.Left, color));
                LineCollision(Math.PI / 2);
            }
            if (newCord.x + radius > form.ClientSize.Width)
            {
                OnCollision(this, new(Side.Right, color));
                LineCollision(Math.PI / 2);
            }

            if (newCord.y - radius < 0)
            {
                OnCollision(this, new(Side.Top, color));
                LineCollision(0);
            }
            if (newCord.y + radius > form.ClientSize.Height)
            {
                OnCollision(this, new(Side.Bottom, color));
                LineCollision(0);
            }
            base.Go();
        }
        public void LineCollision(double angle)
        {
            double normalAngle = angle + Math.PI / 2;
            Vector2 normal = new Vector2(
                (float)Math.Cos(normalAngle),
                (float)Math.Sin(normalAngle)
            );
            normal = Vector2.Normalize(normal);

            float dotProduct = Vector2.Dot(Vel, normal);
            Vector2 reflected = Vel - 2 * dotProduct * normal;
            Angle = (int)(Math.Atan2(reflected.Y, reflected.X) * 180 / Math.PI);
        }
        public void BallCollision(BilliardBall ball)
        {
            double distance = Math.Sqrt(Math.Pow(ball.cord.x - cord.x + ball.Vel.X - Vel.X, 2) + Math.Pow(ball.cord.y - cord.y + ball.Vel.Y - Vel.Y, 2));
            if (distance <= radius + ball.radius)
            {
                //Vector2 normal = new Vector2(ball.cord.x - cord.x, ball.cord.y - cord.y);
                double angle = Math.Atan2(ball.cord.y - cord.y, ball.cord.x - cord.x) + Math.PI / 2;
                LineCollision(angle);
                ball.LineCollision(angle);
            }
        }
    }
}
