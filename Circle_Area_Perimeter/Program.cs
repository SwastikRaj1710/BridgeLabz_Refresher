using System;

namespace Circle_Area_Perimeter // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the diameter of the circle:");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double radius = diameter / 2;
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Perimeter of the circle: " + perimeter);
            Console.WriteLine("Area of the circle: " + area);
        }
    }
}