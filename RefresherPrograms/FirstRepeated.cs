using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class FirstRepeated
    {
        public int Repeated(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i=0;i<arr.Length;i++)
            {
                if (set.Contains(arr[i]))
                    return arr[i];
                else
                    set.Add(arr[i]);
            }
            return -1;
        }
    }
}
