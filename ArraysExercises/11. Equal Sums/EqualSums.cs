using System;
using System.Linq;

class EqualSums
{
    static void Main()
    {
        long[] numsArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        CheckForEqualSum(numsArray);
    }

    static void CheckForEqualSum(long[] numsArray)
    {
        long leftSum = 0L;
        long rightSum = 0L;
        int arrayLength = numsArray.Length;       
        //bool equalFound = false;

        if (arrayLength == 1)
        {
            Console.WriteLine("0");
            return;
        }

        for (int i = 0; i < arrayLength; i++)
        {
            leftSum += numsArray[i];
            
            for (int r = i + 2; r < arrayLength; r++)
            {
                rightSum += numsArray[r];
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine(i + 1);
                return;
            }

            rightSum = 0;
        }

        Console.WriteLine("no");
        //if (!equalFound)
        //{
        //    Console.WriteLine("no");
        //}
    }
}

