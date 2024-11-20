using System;
using System.Linq;

namespace MedianOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 5, 7, 9, 15, 23 };
            int[] arr2 = new int[] { 3, 4, 6, 11, 17, 29 };
            Console.WriteLine(MedianOfTwoNaive(arr1, arr2));
            Console.WriteLine(MedianOfTwoMergeSort(arr1, arr2));
            //Console.WriteLine(MedianOfTwoBinarySearch(arr1, arr2));
        }

        // Bad
        static double MedianOfTwoNaive(int[] arr1, int[] arr2)
        {
            // Concat the two arrays
            int[] arr3 = arr1.Concat(arr2).ToArray();
            Array.Sort(arr3);

            // return the median
            if (arr3.Length % 2 == 0)
            {
                // Number of total elements is even
                return (arr3[(arr3.Length/2)] + arr3[(arr3.Length/2 - 1)]) / 2.0;
            }
            else
            {
                // Number of total elements is odd
                return arr3[(arr3.Length / 2)];
            }
            throw new Exception("Unexpected Input");
        }

        // Better
        static double MedianOfTwoMergeSort(int[] arr1, int[] arr2)
        {
            int middle1 = 0;
            int middle2 = 0;

            int median = 0;
            int medianLeft = 0;

            for (int i = 0; i <= (arr1.Length + arr2.Length) / 2; i++)
            {
                medianLeft = median;

                if(middle1 != arr1.Length && middle2!= arr2.Length)
                {
                    if (arr1[middle1] > arr2[middle2])
                    {
                        median = arr2[middle2];
                        middle2++;
                    }
                    else
                    {
                        median = arr1[middle1];
                        middle1++;
                    }
                }
                if(middle1 > arr1.Length)
                {
                    median = arr2[middle2];
                    middle2++;
                }
                if (middle2 > arr2.Length)
                {
                    median = arr1[middle1];
                    middle1++;
                }
            }
            if ((arr1.Length + arr2.Length) % 2 == 0)
            {
                // Number of total elements is even
                return (median + medianLeft) / 2.0;
            }
            else
            {
                // Number of total elements is odd
                return median;
            }

            throw new Exception("Not implemented");
        }

        // Best
        static double MedianOfTwoBinarySearch(int[] arr1, int[] arr2)
        {
            return 1;
            throw new Exception("Not implemented");
        }
    }
}
