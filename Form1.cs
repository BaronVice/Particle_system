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
        int mouseX, mouseY;
        int menuClickedX, menuClickedY;
        List<Circle> circles = new List<Circle>();

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emitter.amount = (int)numericUpDown1.Value;
            emitter.gravitationX = (float)gravX.Value;
            emitter.gravitationY = (float)gravY.Value;
        }
        
        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            emitter.UpdateState(picDisplay);
            // Позже (или не нужно)
            //Circle.UpdateState(picDisplay);

            // Может отдельным методом?
            Graphics g = Graphics.FromImage(picDisplay.Image);
           
            g.Clear(Color.White);
            Circle.DrawCircleList(g, circles);
            emitter.DrawParticleList(g);

            picDisplay.Invalidate();

            g.Dispose();
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

        private void gravX_ValueChanged(object sender, EventArgs e)
        {
            emitter.gravitationX = (float)gravX.Value;
        }

        private void gravY_ValueChanged(object sender, EventArgs e)
        {
            emitter.gravitationY = (float)gravY.Value;
        }

        private void создатьЗдесьКольцоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circles.Add(new Circle(menuClickedX, menuClickedY));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle.ChangeColors(circles, Graphics.FromImage(picDisplay.Image));
        }

        private void picDisplayContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menuClickedX = mouseX;
            menuClickedY = mouseY;
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }
    }
}
