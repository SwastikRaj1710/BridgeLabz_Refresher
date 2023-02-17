using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class RemoveDuplicates
    {
        public void Duplicate(object[] arr)
        {
            int size = arr.Length;
            for(int i=0;i<size; i++)
            {
                for(int j=i+1;j<size;j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        for(int k=j;k<size-1;k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        size--;
                        j--;
                    }
                }
            }

            Console.WriteLine("Array after removal of duplicates");
            for(int i=0;i<size;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
