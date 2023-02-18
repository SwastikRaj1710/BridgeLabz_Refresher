using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            int n1 = year, count = 0;
            while(n1!=0)
            {
                count++;
                n1 = n1 / 10;
            }
            if (count != 4)
            {
                Console.WriteLine("The entered year is invalid");
                Environment.Exit(0);
            }
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
