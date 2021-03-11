using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Task1.Anferova341
{
    class Point
    {
        public double X { get; }
        public double Y { get; }
        public Point(double x, double y) 
        {
            this.X = x;
            this.Y = y;
        }

        public static double DistPoint(Point p1, Point p2) => Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
    }
}
