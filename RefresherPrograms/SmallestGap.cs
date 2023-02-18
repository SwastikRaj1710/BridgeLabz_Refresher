using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class SmallestGap
    {
        public int minGap(int[] arr)
        {
            int minGap = int.MaxValue;
            for(int i=0;i<arr.Length-1;i++) 
            {
                minGap = Math.Min(minGap, Math.Abs(arr[i] - arr[i + 1]));
            }
            return minGap;
        }
    }
}
