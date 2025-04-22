// Write a program to illustrate encapsulation with properties and indexers.

using System;

namespace EncapsulationDemo
{
    class StudentList
    {
        private string[] students = new string[5];
        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                if (value >= 0 && value <= 5)
                    count = value;
                else
                    Console.WriteLine("Count must be between 0 and 5.");
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return students[index];
                else
                    return "Invalid index";
            }
            set
            {
                if (index >= 0 && index < students.Length)
                    students[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            StudentList list = new StudentList();
            list.Count = 3;
            list[0] = "Ram";
            list[1] = "Shyam";
            list[2] = "Rita";

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": " + list[i]);
            }
        }
    }
}

// Output:

// Purna Shrestha (28683/078)
// Student 1: Ram
// Student 2: Shyam
// Student 3: Rita

