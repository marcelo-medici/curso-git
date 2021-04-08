using System;
using System.Collections.Generic;
using HashSet.Entities;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Course courseA = new Course();
            Console.Write("How many students for course A? ");
            int qtdStudentsA = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdStudentsA; i++)
            {
                courseA.AddStudent(int.Parse(Console.ReadLine()));
            }
            Course courseB = new Course();
            Console.Write("How many students for course B? ");
            int qtdStudentsB = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdStudentsB; i++)
            {
                courseB.AddStudent(int.Parse(Console.ReadLine()));
            }
            Course courseC = new Course();
            Console.Write("How many students for course C? ");
            int qtdStudentsC = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdStudentsC; i++)
            {
                courseC.AddStudent(int.Parse(Console.ReadLine()));
            }

            HashSet<int> courses = new HashSet<int>(courseA.StudentID);
            courses.UnionWith(courseB.StudentID);
            courses.UnionWith(courseC.StudentID);

            Console.WriteLine("Total students: " + courses.Count);
        }
    }
}
