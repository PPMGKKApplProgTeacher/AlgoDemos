using System;
using System.Collections.Generic;

namespace EgyptianFractions
{
    class Program
    {
        static void Main(string[] args)
        {

            long numerator = 50;
            long denominator = 295;

            string egyptFraction = EgyptianFractions(numerator, denominator);
            Console.Write(numerator + "/" + denominator + " = " + egyptFraction);
        }

        static string EgyptianFractions(long numerator, long denominator)
        {
            string str = "";
            string strLoop = "";

            List<long> result = EgyptianFractionsRecursive(numerator, denominator, new List<long>());
            List<long> resultLoop = EgyptianFractionsLoop(numerator, denominator);


            foreach (long num in result)
            {
                str += "1/" + num.ToString() + " + ";
            }
            foreach (long num in resultLoop)
            {
                strLoop += "1/" + num.ToString() + " + ";
            }

            string strCopy = str.Substring(0, str.Length - 3);
            string strLoopCopy = str.Substring(0, str.Length - 3);

            return ("\n Recursive result: " + strCopy + "\n Loop Result: " + strLoopCopy);

        }

        private static List<long> EgyptianFractionsLoop(long numerator, long denominator)
        {
            List<long> output = new List<long>();
            while (numerator > 0)
            {
                long currDenominator = (long)Math.Ceiling((double)denominator / numerator);
                for (int i = 2; i < int.MaxValue; i++)
                {
                    if ( (double) 1 / i < (double) denominator / numerator)
                    {
                        currDenominator = i;
                    }
                }
                output.Add(currDenominator);
                numerator = numerator * currDenominator - denominator;
                denominator = currDenominator * denominator;
            }
            return output;
        }

        private static List<long> EgyptianFractionsRecursive(long numerator, long denominator, List<long> list)
        {
            if (numerator == 0)
            {
                return list;
            }

            long newDenominator = (long)Math.Ceiling( (double)denominator / numerator );
            
            list.Add(newDenominator);

            Console.WriteLine("current denominator is " + newDenominator);

            long outNumrator = numerator * newDenominator - denominator;
            long outDenominator = newDenominator * denominator;

            Console.WriteLine("next fraction is " + outNumrator + "/" + outDenominator);

            list = EgyptianFractionsRecursive(outNumrator, outDenominator, list);

            return list;
        }
    }
}
