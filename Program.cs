using System;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            University[] universities = new University[3]; //3 is the number of deprtments

            universities[0] = new Art();
            universities[1] = new Science();
            universities[2] = new Social();

            // double loop for each departement and each student in the department
            foreach (University university in universities)
            {
                Console.WriteLine("#" + university.GetType().Name + ":");
                foreach (Student student in university.Students)
                {
                    Console.WriteLine("   " + student.GetType().Name);
                    Console.WriteLine("      -------->>>      Students in " + university.GetType().Name);
                }
            }
            Console.ReadKey(); //program keep running until key entered
        }
    }
}
//Factory method parrern from creational design patterns applied to university. Students can be added 
//in Departments.cs and in main is possible add more departments.

