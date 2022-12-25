using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_system.MyObjects
{
    // TODO: метод смены цвета объекта, если тот попал в область, у каждой области будет Color,
    // сделать метод при нажатии на область появление контекстного меню с возможностью изменить радиус и цвет

    // Будет прикольно сделать появление колец там, где было нажато контекстное меню PictureBox'a
    class Circle
    {
        public int Radius;
        public float X;
        public float Y;
        public Color CircleColor;

        public static Random random = new Random();
        public static Pen circuit = new Pen(Color.Black, 1);

        public Circle(int x, int y)
        {
            X = x;
            Y = y;
            CircleColor = GetRandomColor();
            Radius = random.Next(20, 30);
        }

        public static void DrawCircleList(Graphics g, List<Circle> circles)
        {
            Render(g, circles);
        }

        private static void Render(Graphics g, List<Circle> circles)
        {
            foreach (Circle circle in circles)
                circle.Draw(g);
        }

        public static Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        public static void ChangeColors(List<Circle> circles, Graphics g)
        {
            foreach (Circle circle in circles)
                circle.CircleColor = GetRandomColor();
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(CircleColor, 10);
            g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            DrawCircuit(g, Radius - 5);
            DrawCircuit(g, Radius + 5);
            pen.Dispose();
        }

        private void DrawCircuit(Graphics g, int rad)
        {
            g.DrawEllipse(circuit, X - rad, Y - rad, rad * 2, rad * 2);
        }
    }
}
