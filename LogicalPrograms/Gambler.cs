using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Gambler
    {
        public void Gamble(int stake, int goal, int bets)
        {
            int winCount = 0;
            Random random = new Random();
            for(int i = 0; i < bets;i++)
            {
                int betResult = random.Next(0, 2);
                if (betResult == 1)
                {
                    winCount++;
                    stake--;
                }
                else
                {
                    stake--;
                }
                if(stake == 0 || stake==goal)
                {
                    break;
                }
            }
            double winPercent = winCount * 100 / bets;
            Console.WriteLine("Number of wins: " + winCount);
            Console.WriteLine("Win Percentage: " + winPercent);
            Console.WriteLine("Loss Percentage: " + (100 - winPercent));
        }
    }
}
