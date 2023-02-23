using System;

namespace BubbleSortGenerics // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 4, 5, 7, 6, 9, 4, 1, 1, 3, 4, 50, 56, 41 };
            var sortedArr = BubbleSort(arr);
            Console.WriteLine("Sorterd Array:");
            foreach(int i in sortedArr)
            {
                Console.Write(i + " ");
            }
        }

        public static IEnumerable<T> BubbleSort<T>(IEnumerable<T> array) where T : IComparable
        {
            T[] arr = array.ToArray();
            T temp;
            int size = arr.Length;
            for(int i=0; i < size-1; i++)
            {
                for(int j=0; j<size-1-i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        temp  = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}