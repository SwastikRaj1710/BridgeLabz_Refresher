using System;

namespace ExecutionTime // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Program Running Time");
            }
            DateTime endTime = DateTime.Now;
            TimeSpan totalTime = (endTime - startTime);
            Console.WriteLine($"Execution time of the program:{totalTime.TotalMilliseconds}ms");
        }
    }
}