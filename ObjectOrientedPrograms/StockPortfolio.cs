using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class StockPortfolio
    {
        public void StockDetails()
        {
            Console.WriteLine("Enter the number of stocks");
            int num = Convert.ToInt32(Console.ReadLine());
            Stock[] stocks = new Stock[num];
            for (int i=0;i<num;i++)
            {
                Console.WriteLine("Enter the stock namne, number of shares and share price");
                string stockName = Console.ReadLine();
                int nofShares = Convert.ToInt32(Console.ReadLine());
                double sharepPrice = Convert.ToDouble(Console.ReadLine());
                Stock stock = new Stock(stockName,nofShares,sharepPrice);
                stocks[i] = stock;
            }
            double totalValue = 0;

            for(int i=0;i<num;i++)
            {
                totalValue+= stocks[i].ValueOfStock();
                stocks[i].PrintValue();
            }

            Console.WriteLine("Total Value of all the Stocks owned: " + totalValue);

        }
    }
}
