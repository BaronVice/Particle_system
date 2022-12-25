using Particle_system.MyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Particle_system
{
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emitter.amount = (int)numericUpDown1.Value;
        }
        
        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            emitter.UpdateState(picDisplay);

            emitter.DrawParticleList(Graphics.FromImage(picDisplay.Image));

            picDisplay.Invalidate();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            emitter.AddParticles(picDisplay);

            if (emitter.amount <= emitter.particles.Count)
                timer2.Stop();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            emitter.amount = (int)numericUpDown1.Value;
            timer2.Start();
        }
    }
}
