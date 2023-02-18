using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class ZeroesAtEnd
    {
        public void MoveZeroes(int[] arr)
        {
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]!=0)
                {
                    arr[count++] = arr[i];
                }
            }
            while(count<arr.Length)
            {
                arr[count++] = 0;
            }
            Console.WriteLine("Updated Array");
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
