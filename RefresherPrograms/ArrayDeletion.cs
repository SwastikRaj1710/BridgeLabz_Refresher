using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class ArrayDeletion
    {
        public void Delete(int[] arr, int x)
        {
            x = x - 1;
            int size = arr.Length;

            if(x<size)
            {
                size--;
                for(int j=x;j<size;j++)
                {
                    arr[j] = arr[j+1];
                }
            }
            Console.WriteLine("Array after deletion");
            for(int j=0;j<size;j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}
