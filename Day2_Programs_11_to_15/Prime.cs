using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class Prime
    {
        public int[] PrimeArray(int[] arr)
        {
            int[] ans = new int[arr.Length];
            Console.WriteLine("\nPrime numbers are: ");
            for(int i=0;i<arr.Length;i++)
            {
                if (IsPrime(arr[i]))
                {
                    Console.Write(arr[i] + " ");
                }
            }
            return ans;
        }

        public bool IsPrime(int n)
        {
            if(n==0 || n==1)
                return false;
            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
