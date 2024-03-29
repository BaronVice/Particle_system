﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle_system.MyObjects
{
    /** <summary>
     * Класс <c>Particle</c> определяет частицу
     * </summary>
     * <value>
     * <c> SpeedX, SpeedY </c> - векторы скоростей, <br/>
     * <c> Life </c> - жизнь частицы. <br/>
     * </value>
     */
    class Particle : BaseObject
    {
        public float SpeedX;
        public float SpeedY;
        public float Life;

        public static Random random = new Random();
        public static Color baseColor = Color.White;

        public Particle()
        {
            double direction = random.Next(70, 110);
            int speed = 1 + random.Next(10);
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);
        }

        public Particle(float x, float y)
        {
            X = x;
            Y = y;
            double direction = random.Next(70, 110);
            int speed = 1 + random.Next(10);
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = 2 + random.Next(10);
            Life = 20 + random.Next(100);

            ObjColor = baseColor;
        }

        /** <summary> 
        * Метод <c>Draw</c> отображает частицу на графике
        * <paramref name="g"/>.
        * </summary>
        * <param name="g"> График, на котором будет нарисована частица </param>
        */
        public void Draw(Graphics g)
        {
            float k = Math.Min(1f, Life / 100);
            int alpha = (int)(k * 255);

            Color color = Color.FromArgb(alpha, ObjColor);
            SolidBrush brush = new SolidBrush(color);

            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);

            brush.Dispose();
        }

        /** <summary> 
        * Метод <c>ResetValues</c> производит перерождение частицы
        * <paramref name="display"/>.
        * </summary>
        * <param name="display"> График, на котором будет нарисована частица </param>
        */
        public void ResetValues(PictureBox display)
        {
            Life = 20 + random.Next(100);
            X = random.Next(display.Image.Width);
            Y = -30;

            double direction = random.Next(70, 110);
            int speed = 1 + random.Next(10);
            SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            SpeedY = (float)(Math.Sin(direction / 180 * Math.PI) * speed);

            Radius = random.Next(10);

        }

        /** <summary> 
        * Метод <c>MoveParticle</c> производит перемещение частицы в соответствии с гравитацией по
        * <paramref name="gX"/> и <paramref name="gY"/>.
        * </summary>
        * <param name="gX"> Гравитация по оси X </param>
        * <param name="gY"> Гравитация по оси Y </param>
        */
        public void MoveParticle(float gX, float gY)
        {
            SpeedX += gX;
            SpeedY += gY;

            X += SpeedX;
            Y += SpeedY;
        }

        public override GraphicsPath GetGraphicsPath()
        {
            var path = base.GetGraphicsPath();
            path.AddEllipse(X - Radius, Y - Radius, Radius * 2, Radius * 2);
            return path;
        }
    }
}