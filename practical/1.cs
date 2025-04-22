// 1. Write a program to convert a string to uppercase and lowercase & vice versa.

using System;

namespace CaseConversionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string converted = "";

            foreach (char c in input)
            {
                if (char.IsLower(c))
                    converted += char.ToUpper(c);
                else if (char.IsUpper(c))
                    converted += char.ToLower(c);
                else
                    converted += c;
            }

            Console.WriteLine("Converted string: " + converted);
        }
    }
}

// Output: 

// Purna Shrestha (28683/078)
// Enter a string: HeLLo WoRLd123!
// Converted string: hEllO wOrlD123!
