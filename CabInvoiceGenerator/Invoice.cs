using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Invoice
    {
        public int TotalFare(int km, int minute)
        {
            int totalFare = 5;
            totalFare += 10*km + minute;
            return totalFare;
        }
    }
}
