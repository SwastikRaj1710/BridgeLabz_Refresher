using System;

namespace ObjectOrientedPrograms // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. JSON Inventory Data Management");
                Console.WriteLine("2. Stock Account Management");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        JSONInventory obj1 = new JSONInventory();
                        obj1.PriceCalculation();
                        break;
                    case 2:
                        StockPortfolio obj2 = new StockPortfolio();
                        obj2.StockDetails();
                        break;
                    case 3:
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