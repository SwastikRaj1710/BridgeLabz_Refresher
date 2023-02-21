using System;

namespace FunctionalPrograms // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. A library for reading in 2D arrays from standard input and printing them out to standard output");
                Console.WriteLine("2. Count the number of triples that sum to exactly 0");
                Console.WriteLine("3. Find the Euclidean distance from a given point (x, y) to the origin (0,0)");
                Console.WriteLine("4. Find the roots of a Quadratic equation");
                Console.WriteLine("5. Find the Effective temperature(Wind Chill) using the given temperature and wind speed");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter the numner of rows and columns");
                        int m = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        object[,] arr = new object[m,n];
                        Console.WriteLine("Enter the array elements");
                        for(int i=0;i<m;i++)
                        {
                            for(int j=0;j<n;j++)
                            {
                                arr[i,j] = Console.ReadLine();
                            }
                        }
                        Array2D obj1 = new Array2D();
                        obj1.Print2DArray(arr);
                        break;
                    case 2:
                        Console.WriteLine("Enter the number of elements");
                        int len1 = Convert.ToInt32(Console.ReadLine());
                        int[] arr1 = new int[len1];
                        Console.WriteLine("Enter the array elements");
                        for(int i=0;i<len1;i++)
                        {
                            arr1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Triplets obj2 = new Triplets();
                        int tripletsCount = obj2.FindTriplets(arr1);
                        if(tripletsCount==0)
                        {
                            Console.WriteLine("No triplets found");
                        }
                        else
                        {
                            Console.WriteLine("Number of triplets found: " + tripletsCount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the x and y coordinates");
                        double x = Convert.ToDouble(Console.ReadLine());
                        double y = Convert.ToDouble(Console.ReadLine());
                        EuclideanDist obj3 = new EuclideanDist();
                        double distance = obj3.CalculateEuclidean(x, y);
                        Console.WriteLine("The Euclidean Distance between the given points and origin (0,0) is: " + distance);
                        break;
                    case 4:
                        Console.WriteLine("Enter the values of a, b and c");
                        double a = Convert.ToDouble(Console.ReadLine());
                        double b = Convert.ToDouble(Console.ReadLine());
                        double c = Convert.ToDouble(Console.ReadLine());
                        Quadratic obj4 = new Quadratic();
                        obj4.Roots(a, b, c);
                        break;
                    case 5:
                        Console.WriteLine("Enter the temperature in Fahrenheit (less than 50)");
                        double temp = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the wind speed in Miles per hour (from 3 to 120");
                        double windspeed = Convert.ToDouble(Console.ReadLine());
                        WindChill obj5 = new WindChill();
                        double windchill = obj5.FindWindChill(temp, windspeed);
                        Console.WriteLine("The WindChill for the given temperature and wind speed is: " + windchill);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}