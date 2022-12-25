using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_system.MyObjects
{
    // TODO: закинуть сюда общие методы и поля
    class BaseObject
    {
        public Color ObjColor;

        public int Radius;
        public float X;
        public float Y;

        public Action<BaseObject, BaseObject> OnOverlap;

        public Matrix GetTransform()
        {
            var matrix = new Matrix();
            matrix.Translate(X, Y);

            return matrix;
        }

        public virtual GraphicsPath GetGraphicsPath()
        {
            return new GraphicsPath();
        }

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

        public virtual void Overlap(BaseObject obj)
        {
            if (this.OnOverlap != null)
                this.OnOverlap(this, obj);
        }

    }
}
