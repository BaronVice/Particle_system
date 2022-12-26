using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle_system.MyObjects
{
    class MousePoint : BaseObject
    {
        public MousePoint()
        {
            Radius = 1;
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
