// 2. Write a program to create a new string from a given string where first and last characters will be interchanged.

using System;

namespace SwapCharactersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string result;

            if (input.Length < 2)
            {
                result = input;
            }
            else
            {
                char first = input[0];
                char last = input[input.Length - 1];
                string middle = input.Substring(1, input.Length - 2);
                result = last + middle + first;
            }

            Console.WriteLine("Modified string: " + result);
        }
    }
}


// Output:

// Purna Shrestha (28683/078)
// Enter a string: Hello World
// Modified string: dello WorlH