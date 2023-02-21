using System;

namespace FileHandling // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Perform read write operations on a TXT file");
                Console.WriteLine("2. Perform read write operations on a CSV file");
                Console.WriteLine("3. Perform read write operations on a JSON file");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        TXT obj1 = new TXT();
                        obj1.ReadWriteOps();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice!");
                        break;
                }
            }
        }
    }
}