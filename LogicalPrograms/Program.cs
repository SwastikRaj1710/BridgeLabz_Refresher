using System;

namespace LogicalPrograms // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. A Gambler Simulation which displays the number of wins and win-loss percentage");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the stake");
                        int stake = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the goal");
                        int goal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number of bets");
                        int bets = Convert.ToInt32(Console.ReadLine());
                        Gambler obj1 = new Gambler();
                        obj1.Gamble(stake, goal, bets);
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}