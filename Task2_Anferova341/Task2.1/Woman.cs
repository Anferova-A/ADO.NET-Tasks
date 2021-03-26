using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    public class Woman
    {
        public string Name { get; }
        public int Age { get; }
        public int Weight { get; }
        public int Height { get; }

        public Woman (string name, int age, int weight, int height)
        {
            if (name == string.Empty)
            {
                throw new ArgumentException("Имя не может быть пустой строкой");
            }
            if (age <= 0)
            {
                throw new ArgumentException("Возраст должен быть больше 0");
            }
            if (weight <= 0)
            {
                throw new ArgumentException("Вес должен быть больше 0");
            }
            if (height <= 0)
            {
                throw new ArgumentException("Рост должен быть больше 0");
            }

            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }


        public override string ToString()
        {
            return string.Format($"{ Name}, { Age}, { Weight}, { Height}");
        }
    }
}
