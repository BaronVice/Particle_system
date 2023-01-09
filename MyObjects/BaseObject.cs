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
     * Родительский класс <c>BaseObject</c> для выделения общих полей и методов фигур.
     * </summary>
     * <value>
     * <c> ObjColor </c> - базовый цвет объекта, <br/>
     * <c> Radius </c> - радиус объекта, <br/>
     * <c> X и Y </c> - координаты объекта, <br/>
     * <c> OnOverlap </c> - пересечение с текущим объектом.
     * </value>
     */
    class BaseObject
    {
        public Color ObjColor;

        public int Radius;
        public float X;
        public float Y;

        public Action<BaseObject, BaseObject> OnOverlap;

        /** <summary> 
        * Метод <c>GetTransform</c> определяет матрицу перехода.
        * </summary>
        */
        public Matrix GetTransform()
        {
            var matrix = new Matrix();
            matrix.Translate(X, Y);

            return matrix;
        }

        /** <summary> 
        * Метод <c>GetGraphicsPath</c> определяет нахождение объекта на рисунке.
        * </summary>
        */
        public virtual GraphicsPath GetGraphicsPath()
        {
            return new GraphicsPath();
        }

        /** <summary> 
        * Метод <c>Overlaps</c> определяет пересекается ли текущий объект
        * с заданным объектом <paramref name="obj"/> на графике <paramref name="g"/>.
        * </summary>
        * <returns>
        * true при пересечении объектов, иначе false
        * </returns>
        * <param name="obj"> Объект, с которым проверяется пересечение </param>
        * <param name="g"> Рассматриваемый график </param>
        */
        public virtual bool Overlaps(BaseObject obj, Graphics g)
        {
            var path1 = this.GetGraphicsPath();
            var path2 = obj.GetGraphicsPath();

            path1.Transform(this.GetTransform());
            path2.Transform(obj.GetTransform());

            var region = new Region(path1);
            region.Intersect(path2);

            return !region.IsEmpty(g);
        }

        /** <summary> 
        * Метод <c>Overlap</c> задает значение для делегаты OnOverlap, в случае если она еще
        * не определена.
        * </summary>
        * <param name="obj"> Объект, с которым требуется задать пересечение </param>
        */
        public virtual void Overlap(BaseObject obj)
        {
            if (this.OnOverlap != null)
                this.OnOverlap(this, obj);
        }

    }
}