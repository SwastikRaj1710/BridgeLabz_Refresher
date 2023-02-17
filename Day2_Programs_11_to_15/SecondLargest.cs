using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class SecondLargest
    {
        public int FindSecondLargest(int[] arr)
        {
            int size = arr.Length;
            if (size < 2)
                return -1;
            Array.Sort(arr);
            for(int i=size-2;i>=0;i--)
            {
                if (arr[i] != arr[size-1])
                    return arr[i];
            }
            return -1;
        }
    }
}
