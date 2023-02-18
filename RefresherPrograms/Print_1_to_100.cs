using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class Print_1_to_100
    {
        public void Print(int n) 
        {
            if(n<=100)
            {
                Console.Write(n + " ");
                Print(n + 1);
            }
            return;
        }
    }
}
