using System;

namespace MultiplyString // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            String number = Console.ReadLine();
            double ans = Convert.ToDouble(number) * 10;
            Console.WriteLine("10 times the number " + number + " is equal to " + Convert.ToString(ans));
        }
    }
}