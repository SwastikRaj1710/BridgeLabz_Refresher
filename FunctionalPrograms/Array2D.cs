using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    internal class Array2D
    {
        public void Print2DArray(object[,] array)
        {
            Console.WriteLine("The elements of the 2D Array are:");
            for(int i=0;i<array.GetLength(0);i++)
            {
                for(int j = 0; j < array.GetLength(1);j++)
                {
                    Console.WriteLine(array[i,j]);
                }
            }
        }
    }
}
