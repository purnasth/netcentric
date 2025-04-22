// Write a program to show how to handle exception in C#

using System;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            try
            {
                Console.Write("Enter numerator: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter denominator: ");
                int den = Convert.ToInt32(Console.ReadLine());

                int result = num / den;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter numbers.");
            }
            finally
            {
                Console.WriteLine("Thank you for using the program.");
            }
        }
    }
}


// Output:

// Purna Shrestha (28683/078)
// Enter numerator: 10
// Enter denominator: 0
// Error: Division by zero is not allowed.
// Thank you for using the program.

// Purna Shrestha (28683/078)
// Enter numerator: 10
// Enter denominator: 2
// Result: 5
// Thank you for using the program.
