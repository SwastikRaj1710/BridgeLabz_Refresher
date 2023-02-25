using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    internal class Stock
    {
        public string name;
        public int noOfShares;
        public double price;

        public Stock(string stockName, int nShares, double stockPrice)
        {
            name = stockName;
            noOfShares = nShares;
            price = stockPrice;
        }
        public double ValueOfStock()
        {
            double total = this.noOfShares * this.price;
            return total;
        }

        public void PrintValue()
        {
            Console.WriteLine("Value of " + this.name + " = " + this.ValueOfStock());
        }

    }
}
