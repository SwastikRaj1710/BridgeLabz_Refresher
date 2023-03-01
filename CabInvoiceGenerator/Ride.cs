using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public int km;
        public int minute;

        public Ride(int km,int minute) 
        {
            this.km = km;
            this.minute = minute;
        }
    }
}
