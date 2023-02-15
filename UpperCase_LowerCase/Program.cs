using System;

namespace UpperCase_LowerCase // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of your favourite place where you would like to visit the most:");
            string place = Console.ReadLine();
            Console.WriteLine("Place Name in Uppercase: " + place.ToUpper());
            Console.WriteLine("Place Name in Lowercase: " + place.ToLower());
        }
    }
}