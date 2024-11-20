using System;
using System.Linq;


//Given an array of non-negative integers,
//the task is to find the minimum number of elements
//such that their sum
//should be greater than the sum of the rest of the elements of the array.

//Example: 

//    Input: arr[] = [3, 1, 7, 1]
//    Output: 1
//    Explanation: Smallest subset is { 7 }.
//    Sum of this subset is greater than the sum of all other elements
//    left after removing subset {7} from the array


//      Input:  arr[] = [2, 1, 2]
//    Output: 2
//    Explanation: Smallest subset is { 2, 1 }.
//    Sum of this subset is greater than the sum of all other elements
//    left after removing subset {2 , 1} from the array


namespace SmallestSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 1, 2 };

            int output = SmallestSubset(input);
            Console.WriteLine(output);
        }

        static int SmallestSubset(int[] input)
        {
            int counter = 0;
            int halfSum = input.Sum()/2;
            int currSum = 0;
            int[] sortedArray = input.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < sortedArray.Length; i++)
            {
                counter++;
                currSum += sortedArray[i];
                if (currSum > halfSum)
                {
                    break;
                }
            }
            return counter;
        }
    }
}
