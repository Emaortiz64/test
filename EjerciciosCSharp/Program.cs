using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace EjerciciosCSharp;




//Ejercicio 1






class program
{
    static void Main(string[] args){
        Classroom classroom = new Classroom();      //importante instanciar la classroom para que exista
        
        Student student1 = new Student("pichi", 45, 90);
        /*
        Student student2 = new Student("Tu vieja", 69, 22);
        Student student3 = new Student("Carlos Pellegrini", 178, 100);
        Student student4 = new Student("dei revo", 178, 100);
         */

        for (int i = 0; i < 5000; i++) {
            Student perro = new Student("Peluca Milei", 45, 90);
            classroom.AddNewStudent(perro);
        }

        classroom.AddNewStudent(student1);
       //classroom.AddNewStudent(student2);
        //classroom.AddNewStudent(student3);

        Console.WriteLine("\n");
        Console.WriteLine("Displaying all students in the classroom:\n");
       // classroom.EnumerateStudents();

        Console.WriteLine("\n");


        classroom.RemoveStudent(classroom.Students.Last());
        //classroom.RemoveStudent(student4);                          //revisar, primero muestra el else y luego elimina normalmente


        Console.WriteLine("Checking if students have passed:");

        
        //classroom.CheckPass();

    }
}