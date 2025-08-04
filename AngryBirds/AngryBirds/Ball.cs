using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace AngryBirds
{
    internal class Ball : ISprite
    {
        protected Random random = new Random();
        private List<IDrawGroup> list = [];

        protected Brush brush = Brushes.Aqua;
        protected int radius = 10;
        protected Vector2 Acceleration = new(0, 0f);
        public Vector2 Position = new(10, 10);

        private int speed = 10;
        private int angle = 0;
        private Vector2 velocity = new(0, 0);
        protected Vector2 Velocity
        {
            get { return velocity; }
            set
            {
                velocity = value;
                speed = (int)value.Length();
                angle = (int)(Math.Atan2(value.Y, value.X) * 180 / Math.PI);
            }
        }
        protected int Speed
        {
            get { return speed; }
            set
            {
                speed = value;
                UpdateVel();
            }
        }
        protected int Angle
        {
            get { return angle; }
            set
            {
                angle = value;
                UpdateVel();
            }
        }

        public void Draw(Graphics graphics) 
        {
            var rect = new Rectangle((int)(Position.X - radius), (int)(Position.Y - radius), radius * 2, radius * 2);
            graphics.FillEllipse(brush, rect);
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
        private void UpdateVel()
        {
            double angleRad = Angle * 2 * Math.PI / 360;
            velocity = new((int)Math.Round(Speed * Math.Cos(angleRad)), (int)Math.Round(Speed * Math.Sin(angleRad)));
        }
        public virtual void Update() 
        {
            Velocity += Acceleration;
            Position += Velocity;
        }
        public int GetRadius() 
        {
            return radius;
        }
    }
}
