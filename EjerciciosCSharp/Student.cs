using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp
{
    public class Student
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        
        //constructorr
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void StuDetails()
        {
            Console.Write($"Name: {Name}. \n");
            Console.Write($"Age: {Age}. \n");
            Console.Write($"Grade: {Grade}. \n");
        }
    }
}
