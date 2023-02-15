using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class SumDiffSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2;
            double diff = num1 - num2;

            double SumSq = Math.Pow(sum, 2);
            double DiffSq = Math.Pow(diff, 2);
            Console.Write("Square of Sum of the two numbers: ");
            Console.WriteLine(SumSq);
            Console.Write("Square of Difference of the two numbers: ");
            Console.WriteLine(DiffSq);
        }
    }
}