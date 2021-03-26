using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    public class Student : Woman
    {
        public int Year { get; }
        public int Course { get; }
        public int Group { get; }
        public Student(string name, int age, int weight, int height, int year, int course, int group) : base(name, age, weight, height)
        {
            if (year <= 1900)
            {
                throw new ArgumentException("Год должен быть больше 1900");
            }
            if (course <= 0)
            {
                throw new ArgumentException("Курс должен быть больше 0");
            }
            if (group <= 0)
            {
                throw new ArgumentException("Группа должна быть больше 0");
            }
            Year = year;
            Course = course;
            Group = group;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($", {Year}, {Course}, {Group}");
        }
    }
}
