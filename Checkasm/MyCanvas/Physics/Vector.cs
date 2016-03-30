using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amberfish.Canvas.Physics
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector() { }

        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
