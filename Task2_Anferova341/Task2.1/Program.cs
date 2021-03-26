//Создать класс Man.Определить свойства для: имени, возраста, веса и роста.
//Создать производный класс Student, дополняющий  свойства: год начала обучения, курс и номер группы.
//Обеспечить нахождение класса в заведомо корректном состоянии.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Акимова", 19, 56, 182, 2020, 2, 211);
            Console.WriteLine(st);
        }
    }
}
