using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Anferova341
{
    class Triangle
    {
        public Point a, b, c;
        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area
        {
            get => (double) 1 / 2 * ((a.X - c.X) * (b.Y - c.Y) - (b.X - c.X) * (a.Y - c.Y));
        }

        public double Perimetr
        {
            get => Point.DistPoint(a, b) + Point.DistPoint(a, c) + Point.DistPoint(b, c);
        }
    }
}
