// Write a program to show the use of generic classes and methods.

using System;

namespace GenericDemo
{
    // Step 1: Define a generic class
    class GenericClass<T>
    {
        private T value;

        public GenericClass(T value)
        {
            this.value = value;
        }

        // Step 2: Generic method to display value
        public void Display()
        {
            Console.WriteLine("Value: " + value);
        }

        // Step 3: Generic method to add two values of the same type
        public T Add(T otherValue)
        {
            dynamic a = value;
            dynamic b = otherValue;
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            // Using Generic Class with an integer
            GenericClass<int> intObj = new GenericClass<int>(10);
            intObj.Display();
            Console.WriteLine("Sum: " + intObj.Add(5));

            // Using Generic Class with a string
            GenericClass<string> strObj = new GenericClass<string>("Hello");
            strObj.Display();
            Console.WriteLine("Concatenated: " + strObj.Add(" World"));
        }
    }
}

// Output:
// Purna Shrestha (28683/078)
// Value: 10
// Sum: 15
// Value: Hello
// Concatenated: Hello World