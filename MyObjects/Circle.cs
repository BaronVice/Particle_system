using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_system.MyObjects
{
    // TODO: метод смены цвета объекта, если тот попал в область, у каждой области будет Color,
    // сделать метод при нажатии на область появление контекстного меню с возможностью изменить радиус и цвет

    // Будет прикольно сделать появление колец там, где было нажато контекстное меню PictureBox'a
    class Circle : BaseObject
    {
        public String Name;
        public static Random random = new Random();
        public static Pen circuit = new Pen(Color.White, 1);

        public Circle(int x, int y, String name)
        {
            Name = name;
            X = x;
            Y = y;
            ObjColor = GetRandomColor();
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
                circle.ObjColor = GetRandomColor();
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(ObjColor, 10);
            g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            DrawCircuit(g, Radius - 5);
            DrawCircuit(g, Radius + 5);
            pen.Dispose();
        }

        private void DrawCircuit(Graphics g, int rad)
        {
            g.DrawEllipse(circuit, X - rad, Y - rad, rad * 2, rad * 2);
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            int rad = Radius * 2;
            path.AddEllipse(X - rad, Y - rad, rad * 2, rad * 2);
            return path;
        }
    }
}