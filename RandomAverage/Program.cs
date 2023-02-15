using System;

namespace RandomAverage // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sum = 0;
            double avg = 0;
            Console.WriteLine("Five randomly generated numbers are: ");
            for (int i = 0; i < 5; i++)
            {
                int num = random.Next(10, 51);
                Console.Write(num + " ");
                sum += num;
            }
            avg = sum / 5;
            Console.WriteLine("\nAverage of the 5 above generated random numbers: " + avg);
        }
    }
}