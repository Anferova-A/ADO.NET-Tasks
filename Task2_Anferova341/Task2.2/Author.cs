using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class Author
    {
        public string Name { get; }
        public string Surname { get; }
        public int YearOfBirth { get; }

        public Author(string name, string surname, int year)
        {
            if (name == string.Empty)
            {
                throw new ArgumentException("Имя не может быть пустой строкой");
            }
            if (surname == string.Empty)
            {
                throw new ArgumentException("Фамилия не может быть пустой строкой");
            }
            if (year <= 0)
            {
                throw new ArgumentException("Год рождения не может быть отрицательным");
            }
            Name = name;
            Surname = surname;
            YearOfBirth = year;
        }

        public override string ToString()
            => string.Format($"{Name} {Surname} {YearOfBirth}");
    }
}
