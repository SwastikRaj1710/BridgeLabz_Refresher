using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Triplets
    {
        public int FindTriplets(int[] array)
        {
            Console.WriteLine("The triplets having sum equal to zero are:");
            int count = 0;
            Array.Sort(array);
            for(int i=0;i<array.Length;i++)
            {
                if (i > 0 && array[i] == array[i - 1]) 
                    continue;
                for (int j=i+1;j<array.Length;j++)
                {
                    if (j > i + 1 && array[j] == array[j - 1]) 
                        continue;
                    for (int k=j+1;k<array.Length;k++)
                    {
                        if (k > j + 1 && array[k] == array[k - 1])
                            continue;
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            count++;
                            Console.WriteLine(array[i] + " " + array[j] + " " + array[k]);
                        }
                    }
                }
            }
            return count;
        }
    }
}
