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
                Console.WriteLine("1. Find the Factorial of a number");
                Console.WriteLine("2. Print 1 to 100 without using loop");
                Console.WriteLine("3. Find roots of a quadratic equation");
                Console.WriteLine("4. Convert a number to string depending on it's factors");
                Console.WriteLine("5. Check the presence of a,e and p alphabets in a given string");
                Console.WriteLine("6. Find the average of a float array");
                Console.WriteLine("7: Find all the prime numbers in a given array");
                Console.WriteLine("8. Move all zeroes in an array to the end");
                Console.WriteLine("9. Find the first repeated element in an array");
                Console.WriteLine("10. Check the syntax of a given arithmetic expression and evaluate it");
                Console.WriteLine("11. Find the length of the longest substring with no repeating characters in a given string");
                Console.WriteLine("12. Exit");
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
                        Console.WriteLine("Enter the size of the array");
                        int size = Convert.ToInt32(Console.ReadLine());
                        float[] arr = new float[size];
                        Console.WriteLine("Enter the array elements");
                        for(int i=0;i<size;i++)
                        {
                            arr[i] = Single.Parse(Console.ReadLine());
                        }
                        ArrayAverage obj6 = new ArrayAverage();
                        float result = obj6.Average(arr);
                        Console.WriteLine("Average: " + result);
                        break;
                    case 7:
                        Console.WriteLine("Enter size of array");
                        int len = Convert.ToInt32(Console.ReadLine());
                        int[] arr1 = new int[len];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len; i++)
                        {
                            arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Prime obj7 = new Prime();
                        obj7.PrimeArray(arr1);
                        break;
                    case 8:
                        Console.WriteLine("Enter size of array");
                        int length = Convert.ToInt32(Console.ReadLine());
                        int[] arr2 = new int[length];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < length; i++)
                        {
                            arr2[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        ZeroesAtEnd obj8 = new ZeroesAtEnd();
                        obj8.MoveZeroes(arr2);
                        break;
                    case 9:
                        Console.WriteLine("Enter size of array");
                        int len1 = Convert.ToInt32(Console.ReadLine());
                        int[] arr3 = new int[len1];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len1; i++)
                        {
                            arr3[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        FirstRepeated obj9 = new FirstRepeated();
                        int first = obj9.Repeated(arr3);
                        if (first == -1)
                            Console.WriteLine("No repeated element found");
                        else
                            Console.WriteLine("First Repeated Element: " + first);
                        break;
                    case 10:
                        Console.WriteLine("Enter an arithmetic expression");
                        string arith = Console.ReadLine();
                        ValidExpression obj11 = new ValidExpression();
                        int solution = obj11.check(arith);
                        if (solution == -999)
                            Console.WriteLine("The entered Arithmetic Expression is invalid");
                        else
                        {
                            Console.WriteLine("The entered Arithmetic Expression is valid");
                            Console.WriteLine("The solution of this Arithmetic Expression is: " + solution);
                        }
                        break;
                    case 11:
                        Console.WriteLine("Enter a string");
                        string inputString = Console.ReadLine();
                        LongestSubstring obj10 = new LongestSubstring();
                        int longest = obj10.Longest(inputString);
                        Console.WriteLine("Length of the longest substring is: " + longest);
                        break;
                    case 12:
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