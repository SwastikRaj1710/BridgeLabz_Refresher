using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Programs_11_to_15
{
    internal class ArrayAverage
    {
        public float Average(float[] arr)
        {
            float sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                sum += arr[i];
            }
            return sum/arr.Length;
        }
    }
}
