using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class RemoveDuplicates
    {
        public void Duplicate(object[] arr)
        {
            /*int size = arr.Length;
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
            }*/

            HashSet<object> dup = new HashSet<object>();
            foreach (object item in arr)
            {
                dup.Add(item);
            }

            Console.WriteLine("Array after removal of duplicates");

            foreach (object item in dup)
            {
                Console.WriteLine(item);
            }

            /*
            for(int i=0;i<size;i++)
            {
                Console.WriteLine(arr[i]);
            }*/
        }
    }
}
