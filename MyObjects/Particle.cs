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
            Direction = random.Next(360);
            Speed = 1 + random.Next(10);
            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public void draw(Graphics g)
        {
            // Может в дальнейшем сделать начальный цвет частицы статическим?
            float k = Math.Min(1f, Life / 100);
            int alpha = (int)(k * 255);

            Color color = Color.FromArgb(alpha, Color.Black);
            SolidBrush brush = new SolidBrush(color); 

            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            brush.Dispose();
        }
        
        public static void addParticles(PictureBox display)
        {
            int amountToAdd = random.Next(10);
            amountToAdd = Math.Min(amountToAdd, amount - amountToAdd);

            for (int i = 0; i < amountToAdd; i++)
            {
                Particle particle = new Particle();
                particle.X = display.Image.Width / 2;
                particle.Y = display.Image.Height / 2;

                particles.Add(particle);
            }
        }

        // TODO: снег падает с неба, значит Y = -15, X - задавать рандомно
        //private static void resetParticle(Particle particle, PictureBox g)
        //{
        //    particle.Life = 20 + random.Next(100);
        //    particle.X = random.Next(g.Image.Width);
        //    particle.Y = -15;
        //}

        private static void resetValues(Particle particle, PictureBox display)
        {
            particle.Life = 20 + random.Next(100);
            particle.X = display.Image.Width / 2;
            particle.Y = display.Image.Height / 2;

            particle.Direction = random.Next(360);
            particle.Speed = random.Next(10);
            particle.Radius = random.Next(10);
        }

        private static void resetParticle(Particle particle, PictureBox display)
        {
            if (amount < particles.Count - toRemove.Count)
                toRemove.Add(particle);

            else
                resetValues(particle, display);
        }

        private static void moveParticle(Particle particle)
        {
            double directionInRadians = particle.Direction / 180 * Math.PI;
            particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
            particle.Y += (float)(particle.Speed * Math.Sin(directionInRadians));
        }

        public static void updateState(PictureBox display)
        {

            foreach (Particle particle in particles)
            {
                particle.Life -= 1;

                if (particle.Life < 0)
                    resetParticle(particle, display);
                else
                    moveParticle(particle);
            }

            foreach (Particle particle in toRemove)
                particles.Remove(particle);

            toRemove.Clear();
        }

        private static void render(Graphics g)
        {
            foreach (Particle particle in particles)
                particle.draw(g);
        }

        public static void drawParticleList(Graphics g)
        {
            g.Clear(Color.White);
            render(g);
        }
    
    }
}
