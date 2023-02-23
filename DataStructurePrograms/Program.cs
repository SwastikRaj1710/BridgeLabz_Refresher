using System;

namespace DataStructurePrograms // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Read data from a file, perform insertion or deletion and write the data back to another file");
                Console.WriteLine("2. Exit");
                
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch(ch)
                {
                    case 1:
                        UnorderedList obj1 = new UnorderedList();
                        obj1.FileModification();
                        break;
                    case 2:
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