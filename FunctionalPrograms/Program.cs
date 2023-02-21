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
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter the numner of rows and columns");
                        int m = Convert.ToInt32(Console.ReadLine());
                        int n = Convert.ToInt32(Console.ReadLine());
                        object[,] arr1 = new object[m,n];
                        Console.WriteLine("Enter the array elements");
                        for(int i=0;i<m;i++)
                        {
                            for(int j=0;j<n;j++)
                            {
                                arr1[i,j] = Console.ReadLine();
                            }
                        }
                        Array2D obj1 = new Array2D();
                        obj1.Print2DArray(arr1);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}