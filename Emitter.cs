﻿using Particle_system.MyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle_system
{
    class Emitter
    {
        public List<Particle> particles = new List<Particle>();
        private List<Particle> toRemove = new List<Particle>();

        public int amount = 500;
        public static Random random = new Random();

        public void DrawParticleList(Graphics g)
        {
            g.Clear(Color.White);
            Render(g);
        }

        private void Render(Graphics g)
        {
            foreach (Particle particle in particles)
                particle.Draw(g);
        }

        public void AddParticles(PictureBox display)
        {
            int amountToAdd = random.Next(10);
            amountToAdd = Math.Min(amountToAdd, amount - amountToAdd);

            for (int i = 0; i < amountToAdd; i++)
            {
                Particle particle = new Particle(random.Next(display.Image.Width), -30);
                particles.Add(particle);
            }
        }

        public void UpdateState(PictureBox display)
        {

            foreach (Particle particle in particles)
            {
                particle.Life -= 1;

                if (particle.Life < 0)
                    ResetParticle(particle, display);
                else
                    particle.MoveParticle();
            }

            foreach (Particle particle in toRemove)
                particles.Remove(particle);

            toRemove.Clear();
        }

        private void ResetParticle(Particle particle, PictureBox display)
        {
            if (amount < particles.Count - toRemove.Count)
                toRemove.Add(particle);

            else
                particle.ResetValues(display);
        }
    }
}