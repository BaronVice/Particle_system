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

        public float Direction;
        public float Speed;
        public float Life;

        public static Random random = new Random();
        public static List<Particle> particles = new List<Particle>();
        private static List<Particle> toRemove = new List<Particle>();
        public static int amount = 500;

        public Particle()
        {
            Direction = random.Next(70, 110);
            Speed = 1 + random.Next(10);
            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public Particle(float x, float y)
        {
            X = x;
            Y = y;
            Direction = random.Next(70, 110);
            Speed = 1 + random.Next(10);
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
        
        public static void AddParticles(PictureBox display)
        {
            int amountToAdd = random.Next(10);
            amountToAdd = Math.Min(amountToAdd, amount - amountToAdd);

            for (int i = 0; i < amountToAdd; i++)
            {
                Particle particle = new Particle(random.Next(display.Image.Width), -30);
                particles.Add(particle);
            }
        }

        private static void ResetValues(Particle particle, PictureBox display)
        {
            particle.Life = 20 + random.Next(100);
            particle.X = random.Next(display.Image.Width);
            particle.Y = -30;

            particle.Direction = random.Next(70, 110);
            particle.Speed = random.Next(10);
            particle.Radius = random.Next(10);
        }

        private static void ResetParticle(Particle particle, PictureBox display)
        {
            if (amount < particles.Count - toRemove.Count)
                toRemove.Add(particle);

            else
                ResetValues(particle, display);
        }

        private static void MoveParticle(Particle particle)
        {
            double directionInRadians = particle.Direction / 180 * Math.PI;
            particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
            particle.Y += (float)(particle.Speed * Math.Sin(directionInRadians));
        }

        public static void UpdateState(PictureBox display)
        {

            foreach (Particle particle in particles)
            {
                particle.Life -= 1;

                if (particle.Life < 0)
                    ResetParticle(particle, display);
                else
                    MoveParticle(particle);
            }

            foreach (Particle particle in toRemove)
                particles.Remove(particle);

            toRemove.Clear();
        }

        private static void Render(Graphics g)
        {
            foreach (Particle particle in particles)
                particle.Draw(g);
        }

        public static void DrawParticleList(Graphics g)
        {
            g.Clear(Color.White);
            Render(g);
        }
    
    }
}
