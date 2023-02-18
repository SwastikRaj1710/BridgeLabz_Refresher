using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class Swap
    {
        public void SwapTwo(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Value of first variable after Swap: " + a);
            Console.WriteLine("Value of second variable after Swap: " + b);
        }
    }
}
