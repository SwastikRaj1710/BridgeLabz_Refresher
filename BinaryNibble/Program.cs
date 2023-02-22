using System;

namespace BinaryNibble // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int binary = Convert.ToInt32(Convert.ToString(number, 2));
            Console.WriteLine("Binary Representation of " + number + ": " + binary);

            SwapNibbles obj1 = new SwapNibbles();
            int swapped = obj1.Swap(number);
            Console.WriteLine("After swapping Nibbles: " + swapped);

            Powerof2 obj2 = new Powerof2();
            bool isPowerof2 = obj2.IsPowerof2(swapped);
            if (isPowerof2)
            {
                Console.WriteLine("The resultant number " + swapped + " is a Power of 2");
            }
            else
            {
                Console.WriteLine("The resultant number " + swapped + " is not a Power of 2");
            }
        }
    }
}