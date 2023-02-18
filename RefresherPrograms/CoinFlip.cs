using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class CoinFlip
    {
        public void HeadTail(int num)
        {
            double newNum = 0, heads = 0, tails = 0;
            Random random = new Random();
            for (int i=0;i<num;i++)
            {
                newNum = random.NextDouble();
                if (newNum < 0.5)
                {
                    tails++;
                    Console.WriteLine("Tails");
                }
                else
                {
                    heads++;
                    Console.WriteLine("Heads");
                }
            }
            double headPercent = heads/(heads+tails);
            double tailPercent = tails / (heads + tails);
            Console.WriteLine("Percentage of Heads: " + headPercent);
            Console.WriteLine("Percentage of Tails: " + tailPercent);
        }
    }
}
