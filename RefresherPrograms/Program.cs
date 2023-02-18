using System;

namespace RefresherPrograms // Note: actual namespace depends on the project name.
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
                Console.WriteLine("12. Delete an element at the desired position");
                Console.WriteLine("13. Find the second largest element in a given array");
                Console.WriteLine("14. Remove all duplicates elements from a given array");
                Console.WriteLine("15. Find the smallest gap between numbers in a given array");
                Console.WriteLine("16. Find the percentage of heads and tails when flipping the coin, a given number of times");
                Console.WriteLine("17. Find whether a given year is a Leap Year or not");
                Console.WriteLine("18. Display a table pf powers of 2 that are less than or equal to the given number");
                Console.WriteLine("19. Find the Nth Harmonic Value for a given value N");
                Console.WriteLine("20. Find the prime factors of a given number");
                Console.WriteLine("21. Find the Quotient and Remainder for the given Dividend and Divisor");
                Console.WriteLine("22. Swap two given numbers");
                Console.WriteLine("23. Find whether a given number is Even or Odd");
                Console.WriteLine("24. Find whether the given alphabet is a Vowel or a Consonant");
                Console.WriteLine("25. Find the Largest among the three given numbers");
                Console.WriteLine("26. Exit");
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
                        int len1 = Convert.ToInt32(Console.ReadLine());
                        int[] arr1 = new int[len1];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len1; i++)
                        {
                            arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Prime obj7 = new Prime();
                        obj7.PrimeArray(arr1);
                        break;
                    case 8:
                        Console.WriteLine("Enter size of array");
                        int len2 = Convert.ToInt32(Console.ReadLine());
                        int[] arr2 = new int[len2];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len2; i++)
                        {
                            arr2[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        ZeroesAtEnd obj8 = new ZeroesAtEnd();
                        obj8.MoveZeroes(arr2);
                        break;
                    case 9:
                        Console.WriteLine("Enter size of array");
                        int len3 = Convert.ToInt32(Console.ReadLine());
                        int[] arr3 = new int[len3];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len3; i++)
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
                        Console.WriteLine("Enter size of array");
                        int len4 = Convert.ToInt32(Console.ReadLine());
                        int[] arr4 = new int[len4];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len4; i++)
                        {
                            arr4[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the desired position from which the element has to de deleted");
                        int x = Convert.ToInt32(Console.ReadLine());
                        ArrayDeletion obj12 = new ArrayDeletion();
                        obj12.Delete(arr4, x);
                        break;
                    case 13:
                        Console.WriteLine("Enter size of array");
                        int len5 = Convert.ToInt32(Console.ReadLine());
                        int[] arr5 = new int[len5];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len5; i++)
                        {
                            arr5[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        SecondLargest obj13 = new SecondLargest();
                        int second = obj13.FindSecondLargest(arr5);
                        if (second == -1)
                            Console.WriteLine("Second Largest element not found");
                        else
                            Console.WriteLine("Second Largest Element: " + second);
                        break;
                    case 14:
                        Console.WriteLine("Enter size of array");
                        int len6 = Convert.ToInt32(Console.ReadLine());
                        object[] arr6 = new object[len6];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len6; i++)
                        {
                            arr6[i] = Console.ReadLine();
                        }
                        RemoveDuplicates obj14 = new RemoveDuplicates();
                        obj14.Duplicate(arr6);
                        break;
                    case 15:
                        Console.WriteLine("Enter size of array");
                        int len7 = Convert.ToInt32(Console.ReadLine());
                        int[] arr7 = new int[len7];
                        Console.WriteLine("Enter the array elements");
                        for (int i = 0; i < len7; i++)
                        {
                            arr7[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        SmallestGap obj15 = new SmallestGap();
                        int minGap = obj15.minGap(arr7);
                        Console.WriteLine("Smallest gap between the numbers in an array: " + minGap);
                        break;
                    case 16:
                        Console.WriteLine("Enter the number of times to flip coin");
                        int flips = Convert.ToInt32(Console.ReadLine());
                        CoinFlip obj16 = new CoinFlip();
                        obj16.HeadTail(flips);
                        break;
                    case 17:
                        Console.WriteLine("Enter the year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        LeapYear obj17 = new LeapYear();
                        bool isLeap = obj17.IsLeapYear(year);
                        if (isLeap)
                            Console.WriteLine("Year " + year + " is a Leap Year");
                        else
                            Console.WriteLine("Year " + year + " is not a Leap Year");
                        break;
                    case 18:
                        Console.WriteLine("Enter the value of N");
                        int table = Convert.ToInt32(Console.ReadLine());
                        if(table > 30)
                        {
                            Console.WriteLine("Integer Overflow Error, please enter a value in the range of 0-30");
                        }
                        else
                        {
                            Console.WriteLine("Powers of 2 till " + table);
                            PowersOf2 obj18 = new PowersOf2();
                            obj18.Power(table);
                        }
                        break;
                    case 19:
                        Console.WriteLine("Enter the value of N");
                        int nthTerm = Convert.ToInt32(Console.ReadLine());
                        if(nthTerm == 0) 
                        {
                            Console.WriteLine("Please enter a value grater than 0");
                        }
                        else
                        {
                            Harmonic obj19 = new Harmonic();
                            float nthHarmonic = obj19.NthHarmonic(nthTerm);
                            Console.WriteLine("Nth Harmonic Value: " + nthHarmonic);
                        }
                        break;
                    case 20:
                        Console.WriteLine("Enter a number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        PrimeFactors obj20 = new PrimeFactors();
                        Console.WriteLine("Prime Factors are: ");
                        obj20.PrintPrimeFactors(number);
                        break;
                    case 21:
                        Console.WriteLine("Enter the Dividend and Divisor");
                        int dividend = Convert.ToInt32(Console.ReadLine());
                        int divisor = Convert.ToInt32(Console.ReadLine());
                        QuotientRemainder obj21 = new QuotientRemainder();
                        obj21.FindQuotientRemainder(dividend, divisor);
                        break;
                    case 22:
                        Console.WriteLine("Enter two numbers");
                        int firstNum = Convert.ToInt32(Console.ReadLine());
                        int secondNum = Convert.ToInt32(Console.ReadLine());
                        Swap obj22 = new Swap();
                        obj22.SwapTwo(firstNum, secondNum);
                        break;
                    case 23:
                        Console.WriteLine("Enter a number");
                        int numInput = Convert.ToInt32(Console.ReadLine());
                        EvenOdd obj23 = new EvenOdd();
                        obj23.IsEvenOdd(numInput);
                        break;
                    case 24:
                        Console.WriteLine("Enter an alphabet");
                        char alphabet = Convert.ToChar(Console.ReadLine());
                        VowelConsonant obj24 = new VowelConsonant();
                        obj24.IsVowelConsonant(alphabet);
                        break;
                    case 25:
                        Console.WriteLine("Enter the three numbers");
                        int number1 = Convert.ToInt32(Console.ReadLine());
                        int number2 = Convert.ToInt32(Console.ReadLine());
                        int number3 = Convert.ToInt32(Console.ReadLine());
                        LargestAmong3 obj25 = new LargestAmong3();
                        int largestNumber = obj25.Largest(number1,number2,number3);
                        Console.WriteLine("The Largest number among the 3 numbers is: " + largestNumber);
                        break;
                    case 26:
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