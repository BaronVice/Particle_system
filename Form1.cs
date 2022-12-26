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
        List<Circle> circles = new List<Circle>();

        int mouseX, mouseY;
        int menuClickedX, menuClickedY;
        MousePoint mousePoint = new MousePoint();

        bool isDragged = false;
        Circle draggedCircle;

        int counter = 1;
        Circle chosenCircle;

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
            // Позже (или не нужно)
            //Circle.UpdateState(picDisplay);

            // Может отдельным методом?
            Graphics g = Graphics.FromImage(picDisplay.Image);

            emitter.UpdateState(picDisplay);
            CheckOverlaped(g);

            g.Clear(Color.Black);
            Circle.DrawCircleList(g, circles);
            emitter.DrawParticleList(g);

            picDisplay.Invalidate();

            g.Dispose();
        }

        private void CheckOverlaped(Graphics g)
        {
            foreach (Particle particle in emitter.particles)
                foreach (Circle circle in circles)
                {
                    if (particle.Overlaps(circle, g))
                    {
                        particle.ObjColor = circle.ObjColor;
                        break;
                    }
                    else
                    {
                        particle.ObjColor = Particle.baseColor;
                    }
                }
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
            if (circles.Count >= 5)
                circles.RemoveAt(0);

            circles.Add(new Circle(menuClickedX, menuClickedY, $"Circle{counter++}"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle.ChangeColors(circles, Graphics.FromImage(picDisplay.Image));
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {
            mousePoint.X = mouseX;
            mousePoint.Y = mouseY;

            foreach (Circle circle in circles)
                if (circle.Overlaps(mousePoint, Graphics.FromImage(picDisplay.Image)))
                {
                    chosenCircle = circle;

                    circleName.Enabled = true;
                    circleRadius.Enabled = true;

                    circleName.Text = circle.Name;
                    circleRadius.Value = circle.Radius;

                    return;
                }
                else
                {
                    circleName.Enabled = false;
                    circleRadius.Enabled = false;
                }
        }

        private void circleName_TextChanged(object sender, EventArgs e)
        {
            chosenCircle.Name = circleName.Text;
        }

        private void circleRadius_ValueChanged(object sender, EventArgs e)
        {
            chosenCircle.Radius = (int)circleRadius.Value;
        }

        private void picDisplay_DoubleClick(object sender, EventArgs e)
        {

            foreach (Circle circle in circles)
                if (circle.Overlaps(mousePoint, Graphics.FromImage(picDisplay.Image)))
                {
                    draggedCircle = circle;
                    isDragged = !isDragged;
                    return;
                }

            isDragged = false;
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

            if (isDragged)
            {
                draggedCircle.X = e.X;
                draggedCircle.Y = e.Y;
            }
        }
    }
}