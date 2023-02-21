using System;
using System.Collections;

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
                Console.WriteLine("2. Find the number of random numbers to be generated in order to get the given distinct numbers");
                Console.WriteLine("3. Create a stopwatch to calculate the time elapsed between the start and stop clicks");
                Console.WriteLine("4. Exit");
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
                        Console.WriteLine("Enter the number of distinct numbers");
                        int distinct = Convert.ToInt32(Console.ReadLine());
                        List<int> l = new List<int>();
                        Console.WriteLine("Enter the distinct numbers");
                        for(int i=0;i<distinct;i++)
                        {
                            l.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        CouponNumbers obj2 = new CouponNumbers();
                        int randomCount = obj2.CountRandom(l);
                        Console.WriteLine("The number of random numbers generated to get all given unique numbers is: " + randomCount);
                        break;
                    case 3:
                        Timer obj3 = new Timer();
                        Console.WriteLine("Enter S to start the stopwatch");
                        char command = Convert.ToChar(Console.ReadLine());
                        if(command=='S')
                        {
                            obj3.FindElapsedTime();
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}