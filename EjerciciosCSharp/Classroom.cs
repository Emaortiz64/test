using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCSharp
{
    public class Classroom
    {                                       //lista de estudiantes
        public List<Student> Students { get; set; }                          //ojo la S !!!


        //constructor de la calse

        public Classroom()
        {
            Students = new List<Student>();
        }

        //agregar nuevo student

        public void AddNewStudent(Student student)     //(Student student, string name, int age, Int64 grade) 
        {
            Students.Add(student);
            Console.WriteLine($"Adding students to the classroom... Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }

        public void RemoveStudent(Student student)                          //nota, ver  Student studentToRemove = Students.Find(student => student.Name == name); 
        {
            int contador = 0;
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Name == student.Name)
                {
                    Students.RemoveAt(i);
                    Console.WriteLine($"The student {student.Name} has been eliminated from the classroom.\n");
                    break;
                }
                else { 
                    contador++;
                }
            }

            if (contador == Students.Count)
            {
                Console.WriteLine($"We can't find that student in the classroom.\n");
            }

        }

        public void EnumerateStudents()
        {
            foreach (var student in Students)
            {             //como tengo que asignar el tipo de dato y no estoy seguro uso var para que C# lo haga automáticamente
                student.StuDetails();
            }
        }

        public void CheckPass()
        {
            foreach (var Student in Students)
            {
                if (Student.Grade >= 60)
                {
                    Console.WriteLine($"{Student.Name} has passed!!!");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
