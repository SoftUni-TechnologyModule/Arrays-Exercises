using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        string nums = Console.ReadLine();

        int[] maxSequenceArray = nums.Split(' ').Select(int.Parse).ToArray();

        GetMaxSequenceOfIncreasingElements(maxSequenceArray);
    }

    static void GetMaxSequenceOfIncreasingElements(int[] nums)
    {
        int start = 0;
        int bestStart = 0;
        int len = 0;
        int bestLenght = 0;

        for (int pos = 1; pos < nums.Length; pos++)
        {
            if (nums[pos] - nums[pos - 1] >= 1)
            {
                len++;
                start = pos - len;

                if (len > bestLenght)
                {
                    bestLenght = len;
                    bestStart = start;
                }
            }
            else
            {
                len = 0;
            }
        }

        for (int i = bestStart; i <= (bestStart + bestLenght); i++)
        {
            Console.Write($"{nums[i]} ");
        }

        Console.WriteLine();
    }
}

