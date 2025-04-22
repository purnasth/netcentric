// 10. Write a program to demonstrate the use of the method as a condition in the LINQ.

using System;
using System.Linq;

namespace LINQMethodConditionDemo
{
    class Program
    {
        // Step 1: Define a method that checks if a number is even
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Step 2: Main program
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            // A list of numbers
            var numbers = new int[] { 10, 15, 22, 33, 40, 55, 60 };

            // Step 3: Use LINQ to filter the numbers using the method as condition
            var evenNumbers = from num in numbers
                              where IsEven(num)  // Using the IsEven method as condition
                              select num;

            // Step 4: Display the result
            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}


// Output:

// Purna Shrestha (28683/078)
// Even numbers:
// 10
// 22
// 40
// 60
//
