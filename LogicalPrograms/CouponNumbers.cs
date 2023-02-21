using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {

        public int CountRandom(List<int> l)
        {
            int count = 0;
            while(l.Count > 0)
            {
                count++;
                int random = GetRandomNumber(l);
                if(l.Contains(random))
                {
                    l.Remove(random);
                }
            }
            return count;
        }

        public static int GetRandomNumber(List<int> l)
        {
            Random random = new Random();
            int num = random.Next(0,l.Max()+1);
            return num;
        }
    }
}
