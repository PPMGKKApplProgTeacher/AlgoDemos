// We are given an array of numbers
// We need to find a majorant element
// Majorant element is an element that
// occurs more than 50%  of the times


using System;

namespace Majorant
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 11, 11, 55, 55, 84, 55, 99, 54, 55, 55, 35, 55, 40, 25, 21, 98, 41 };
            int[] input2 = { 0, 1, 0, 1, 0, 2 };
            int? majorant = CalculateMajorant(input2);
            Console.WriteLine("Majorant: " + majorant);
        }

        private static int? CalculateMajorant(int[] input)
        {
            int? candidate = null;
            int currentCounter = 0;

            foreach (int currentNumber in input)
            {
                if (currentCounter == 0)
                {
                    candidate = currentNumber;
                }
                if (currentNumber == candidate)
                {
                    currentCounter++;
                }
                else
                {
                    currentCounter--;
                }
            }

            currentCounter = 0;

            foreach (var currentNumber in input)
            {
                if(currentNumber == candidate)
                {
                    currentCounter++;
                }
            }

            if (currentCounter > input.Length / 2)
            {
                return candidate;
            }
            else
            {
                return null;
            }
        }
    }
}
