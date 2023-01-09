using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_system.MyObjects
{
    /** <summary>
     * Класс <c>Circle</c> определяет окружнсть, через которую проходят частицы
     * </summary>
     * <value>
     * <c> Name </c> - название окружности.
     * </value>
     */
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
            Radius = random.Next(30, 70);
        }

        /** <summary> 
        * Метод <c>DrawCircleList</c> запускает прорисовку всех окружностей из списка
        * <paramref name="circles"/> на графике <paramref name="g"/>.
        * </summary>
        * <param name="g"> График, на котором будет происходить прорисовка </param>
        * <param name="circles"> Список окружностей для прорисовки </param>
        */
        public static void DrawCircleList(Graphics g, List<Circle> circles)
        {
            Render(g, circles);
        }

        /** <summary> 
        * Метод <c>DrawCircleList</c> рисует окружности из списка
        * <paramref name="circles"/> на графике <paramref name="g"/>.
        * </summary>
        * <param name="g"> График, на котором будет происходить прорисовка </param>
        * <param name="circles"> Список окружностей для прорисовки </param>
        */
        private static void Render(Graphics g, List<Circle> circles)
        {
            foreach (Circle circle in circles)
                circle.Draw(g);
        }

        /** <summary> 
        * Метод <c>GetRandomColor</c> задает случаный цвет окружности
        * </summary>
        */
        public static Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        /** <summary> 
        * Метод <c>ChangeColors</c> задает всем окружностям из списка
        * <paramref name="circles"/> новые цвета.
        * </summary>
        * <param name="circles"> Список окружностей для смены цвета </param>
        */
        public static void ChangeColors(List<Circle> circles)
        {
            foreach (Circle circle in circles)
                circle.ObjColor = GetRandomColor();
        }

        /** <summary> 
        * Метод <c>Draw</c> отображает окружность на графике
        * <paramref name="g"/>.
        * </summary>
        * <param name="g"> График, на котором будет нарисована окружность </param>
        */
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(ObjColor, 10);
            g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            DrawCircuit(g, Radius - 5);
            DrawCircuit(g, Radius + 5);
            pen.Dispose();
        }

        /** <summary> 
        * Метод <c>DrawCircuit</c> рисует контуры окружности в соответствии с заданным радиусом
        * <paramref name="rad"/>.
        * </summary>
        * <param name="g"> График, на котором будет нарисован контур </param>
        * <param name="rad"> Радиус окружности контура </param>
        */
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