using Particle_system.MyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Particle_system
{
    public partial class Form1 : Form
    {


        List<Particle> particles = new List<Particle>();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            Particle.generateParticles(500, particles, picDisplay);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Particle.updateState(particles);

            Particle.drawParticleList(particles, Graphics.FromImage(picDisplay.Image));

            picDisplay.Invalidate();
        }
    }
}
