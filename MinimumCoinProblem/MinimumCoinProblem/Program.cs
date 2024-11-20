using System;
using System.Collections.Generic;

namespace MinimumCoinProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] denomination = { 50, 20, 20, 10, 10, 10, 5, 5, 2, 1, 1, 1, 1, 1 };
            int sum = 68;
            minimumCoins(denomination, sum);
        }

        static void minimumCoins(int[] denomination, int sum)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < denomination.Length; i++)
            {
                if (sum >= denomination[i])
                {
                    sum -= denomination[i];
                    result.Add(denomination[i]);
                }
            }

            Console.Write( "Final result is " );

            foreach (var coin in result)
            {
                Console.Write(coin + ", ");
            }
        }
    }
}
