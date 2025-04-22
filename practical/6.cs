// 6. Write a program to implement multiple inheritance with the use of interfaces.

using System;

namespace MultipleInheritanceDemo
{
    interface IStudent
    {
        void Study();
    }

    interface IEmployee
    {
        void Work();
    }

    class Person : IStudent, IEmployee
    {
        public void Study()
        {
            Console.WriteLine("Studying as a student.");
        }

        public void Work()
        {
            Console.WriteLine("Working as an employee.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            Person p = new Person();
            p.Study();
            p.Work();
        }
    }
}

// Output:

// Purna Shrestha (28683/078)
// Studying as a student.
// Working as an employee.