//Вариант 2
//Написать свой класс Triangle, три точки с указанными координатами, а также свойствами,
//позволяющими узнать площадь и периметра треугольника.Обеспечить нахождение объекта
//в заведомо корректном состоянии.Написать программу, демонстрирующую
//использование данного треугольника.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1.Anferova341
{
    class Program
    {
        static Triangle Read()
        {
            Triangle tr;
            using (StreamReader f = new StreamReader("f.txt"))
            {
                List<Point> points = new List<Point>();
                while (!f.EndOfStream)
                {
                    string[] point = f.ReadLine().Split();
                    points.Add(new Point((double.Parse(point[0])), double.Parse(point[1])));
                }

                tr = new Triangle(points[0], points[1], points[2]);
            }
            return tr;
        }

        static void Write(params string[] args)
        {
            using (StreamWriter g = new StreamWriter("g.txt"))
            {
               foreach (var a in args)
                {
                    g.WriteLine(a);
                }
            }
        }
        static void Main()
        {
            Triangle tr = Read();

            Write($"Площадь - {tr.Area}", $"Периметр - {tr.Perimetr}");
        }
    }
}
