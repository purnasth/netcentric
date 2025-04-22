// 3. Write a program to demonstrate the basics of class and object.

using System;

namespace BasicsOfClassObject
{
    class Person
    {
        public string name;
        public int age;

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            Person p1 = new Person();
            p1.name = "Purna";
            p1.age = 21;

            p1.DisplayInfo();
        }
    }
}


// Output:

// Purna Shrestha (28683/078)
// Name: Purna
// Age: 21
