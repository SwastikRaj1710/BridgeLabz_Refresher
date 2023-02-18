using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class LargestAmong3
    {
        public int Largest(int n1, int n2, int n3) 
        {
            return Math.Max(Math.Max(n1, n2), n3);
        }
    }
}
