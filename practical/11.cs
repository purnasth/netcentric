// 11. Demonstrate Asynchronous programming with async, await, Task in C#.

using System;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    class Program
    {
        // Step 1: Define an asynchronous method
        public static async Task LongRunningTask()
        {
            Console.WriteLine("Task started...");

            // Simulate a delay (e.g., downloading data)
            await Task.Delay(3000);  // 3-second delay

            Console.WriteLine("Task completed.");
        }

        // Step 2: Main method calls the asynchronous task
        static async Task Main(string[] args)
        {
            Console.Write("Purna Shrestha (28683/078)\n");

            // Step 3: Call the async method
            await LongRunningTask();

            Console.WriteLine("Main method continues execution.");
        }
    }
}


// Output:
// Purna Shrestha (28683/078)
// Task started...
// Task completed.
// Main method continues execution.
//