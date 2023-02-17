using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class ArrayDeletion
    {
        public void Delete(int[] arr, int x)
        {
            x = x - 1;
            int i;
            int size = arr.Length;
            for(i=0;i<size; i++)
            {
                if (i == x)
                    break;
            }

            if(i<size)
            {
                size--;
                for(int j=i;j<size;j++)
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
