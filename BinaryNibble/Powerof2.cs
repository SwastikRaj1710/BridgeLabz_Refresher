using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNibble
{
    internal class Powerof2
    {
        public bool IsPowerof2(int num)
        {
            if (num == 0)
            {
                return false;
            }
            
            while(num!=1)
            {
                if(num%2!= 0)
                {
                    return false;
                }
                num /= 2;
            }
            return true;
        }
    }
}
