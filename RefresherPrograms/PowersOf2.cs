using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class PowersOf2
    {
        public void Power(int n)
        {
            for(int i=0; i<=n; i++)
            {
                Console.WriteLine("2 ^ " + i + " = " + Math.Pow(2,i));
            }
        }
    }
}
