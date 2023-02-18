using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class EvenOdd
    {
        public void IsEvenOdd(int num)
        {
            if (num == 0)
                Console.WriteLine("The given number " + num + " is neither Even nor Odd");
            else if (num % 2 == 0)
                Console.WriteLine("The given number " + num + " is Even");
            else
                Console.WriteLine("The given number " + num + " is Odd");
        }
    }
}
