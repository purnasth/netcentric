// 5. Write a program that reflects the overloading and overriding of constructor and function

using System;

namespace OverloadOverrideDemo
{
    class Person
    {
        public string name;

        // Constructor Overloading
        public Person()
        {
            name = "Unknown";
        }

        public Person(string name)
        {
            this.name = name;
        }

        // Method Overloading
        public void Show()
        {
            Console.WriteLine("Name: " + name);
        }

        public void Show(string prefix)
        {
            Console.WriteLine(prefix + name);
        }

        // Virtual function
        public virtual void Greet()
        {
            Console.WriteLine("Hello from Person!");
        }
    }

    class Student : Person
    {
        // Constructor chaining
        public Student(string name) : base(name) { }

        // Overriding method
        public override void Greet()
        {
            Console.WriteLine("Hello from Student!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            Person p1 = new Person();
            Person p2 = new Person("Suman");

            p1.Show();
            p2.Show("Student: ");
            p2.Greet();

            Student s1 = new Student("Purna");
            s1.Show();
            s1.Greet();  // Overridden method
        }
    }
}

