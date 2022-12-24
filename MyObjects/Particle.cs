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
        public int Life;

        public static Random random = new Random();
    
        
        public Particle()
        {
            Direction = random.Next(360);
            Speed = 1 + random.Next(10);
            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public void draw(Graphics g)
        {
            // Может в дальнейшем сделать цвет статическим?
            SolidBrush brush = new SolidBrush(Color.Black);

            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            brush.Dispose();
        }

        public static void generateParticles(int amount, List<Particle> particles, PictureBox display)
        {
            for (int i = 0; i < amount; i++)
            {
                Particle particle = new Particle();
                particle.X = display.Image.Width / 2;
                particle.Y = display.Image.Height / 2;

                particles.Add(particle);
            }
        }

        private static void resetParticle(Particle particle)
        {
            particle.Life = 20 + random.Next(100);
            particle.X = // бл
        }

        public static void updateState(List<Particle> particles)
        {
            foreach (Particle particle in particles)
            {
                particle.Life -= 1;
                particle.Life < 0 ? resetParticle(particle) : moveParticle(particle);
                var directionInRadians = particle.Direction / 180 * Math.PI;
                particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                particle.Y += (float)(particle.Speed * Math.Sin(directionInRadians));
            }
        }

        private static void render(List<Particle> particles, Graphics g)
        {
            foreach (Particle particle in particles)
                particle.draw(g);
        }

        public static void drawParticleList(List<Particle> particles, Graphics g)
        {
            g.Clear(Color.White);
            render(particles, g);
        }
    
    }
}
