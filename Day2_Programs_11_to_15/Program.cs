using System;

namespace Day2_Programs_11_to_15 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Factorial of a number");
                Console.WriteLine("2. Print 1 to 100 without using loop");
                Console.WriteLine("3. Find roots of a quadratic equation");
                Console.WriteLine("4. Convert a number to string depending on it's factors");
                Console.WriteLine("5. Check the presence of a,e and p alphabets in a given string");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter a number");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Factorial obj1 = new Factorial();
                        int ans = obj1.fact(num);
                        Console.WriteLine("Factorial of " + num + " = " + ans);
                        break;
                    case 2:
                        Print_1_to_100 obj2 = new Print_1_to_100();
                        obj2.Print(1);
                        break;
                    case 3:
                        Console.WriteLine("Enter the values of a, b and c");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        Quadratic obj3 = new Quadratic();
                        obj3.Roots(a, b, c);
                        break;
                    case 4:
                        Console.WriteLine("Enter a number");
                        int n = Convert.ToInt32(Console.ReadLine());
                        NumbertoString obj4 = new NumbertoString();
                        string res = obj4.StringFactors(n);
                        Console.WriteLine("\n" + res);
                        break;
                    case 5:
                        Console.WriteLine("Enter a string");
                        string str = Console.ReadLine();
                        CharactersPresent obj5 = new CharactersPresent();
                        obj5.Present(str);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice!!!");
                        break;
                }
            }
        }
    }
}