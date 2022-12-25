using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle_system.MyObjects
{
    class Particle
    {
        public int Radius;
        public float X;
        public float Y;

        public float SpeedX;
        public float SpeedY;
        public float Life;

        public static Random random = new Random();

        public Particle()
        {
            double direction = random.Next(70, 110);
            int speed = 1 + random.Next(10);
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public Particle(float x, float y)
        {
            X = x;
            Y = y;
            double direction = random.Next(70, 110);
            int speed = 1 + random.Next(10);
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public void Draw(Graphics g)
        {
            // Может в дальнейшем сделать начальный цвет частицы статическим?
            float k = Math.Min(1f, Life / 100);
            int alpha = (int)(k * 255);

            Color color = Color.FromArgb(alpha, Color.Black);
            SolidBrush brush = new SolidBrush(color); 

            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            brush.Dispose();
        }

        public void ResetValues(PictureBox display)
        {
            Life = 20 + random.Next(100);
            X = random.Next(display.Image.Width);
            Y = -30;

            double direction = random.Next(70, 110);
            int speed = 1 + random.Next(10);
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = random.Next(10);
        }

        public void MoveParticle()
        {
            X += SpeedX;
            Y += SpeedY;
        }    
    }
}
