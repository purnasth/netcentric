using System;

namespace CalenderJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] calendar = new int[5][];

            calendar[0] = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            calendar[1] = new int[7] { 8, 9, 10, 11, 12, 13, 14 };
            calendar[2] = new int[7] { 15, 16, 17, 18, 19, 20, 21 };
            calendar[3] = new int[7] { 22, 23, 24, 25, 26, 27, 28 };
            calendar[4] = new int[3] { 29, 30, 31 };

            Console.WriteLine("Simple Calendar using a Jagged Array:");
            Console.WriteLine("---------------------------------------");

            for (int week = 0; week < calendar.Length; week++)
            {
                Console.Write("Week " + (week + 1) + ": ");

                for (int day = 0; day < calendar[week].Length; day++)
                {
                    Console.Write(calendar[week][day] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}