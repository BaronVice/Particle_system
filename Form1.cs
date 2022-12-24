using Particle_system.MyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Particle_system
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            Particle.amount = (int)numericUpDown1.Value;
        }
        
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Particle.updateState(picDisplay);

            Particle.drawParticleList(Graphics.FromImage(picDisplay.Image));

            picDisplay.Invalidate();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Particle.addParticles(picDisplay);

            if (Particle.amount <= Particle.particles.Count)
                timer2.Stop();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Particle.amount = (int)numericUpDown1.Value;
            timer2.Start();
        }
    }
}
