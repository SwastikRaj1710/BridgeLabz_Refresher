using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    internal class BankingCashCounter
    {
        public void PerformBankOperations()
        {
            QueueUtility q = new QueueUtility();
            while(true)
            {
                Console.WriteLine("\nWelcome to the Bank");
                Console.WriteLine("Cash Counter");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Number of people in the Queue");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter your choice:");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter the amount you want to Deposit");
                        q.enqueue(Convert.ToInt32(Console.ReadLine()));
                        q.display();
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount you want to Withdraw ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if(withdraw<=q.peek())
                        {
                            q.dequeue();
                            int remaining = q.peek() - withdraw;
                            if (remaining > 0)
                                q.enqueue(remaining);
                            Console.WriteLine("Your Available Balance is: ");
                            q.display();
                        }
                        else
                        {
                            Console.WriteLine("Withdraw amount more than the amount deposited in queue");
                        }
                        break;
                    case 3:
                        int j = q.getSize();
                        Console.WriteLine("The number of people in Queue is: " + j);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Incorrect choice!");
                        break;
                }
            }
        }
    }
}
