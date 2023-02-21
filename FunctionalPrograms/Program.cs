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
                Console.WriteLine("3. Exit");
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
                            Console.WriteLine("Number of triplets found " + tripletsCount);
                        }
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}