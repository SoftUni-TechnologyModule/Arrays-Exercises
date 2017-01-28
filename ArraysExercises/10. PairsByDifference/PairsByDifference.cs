using System;
using System.Collections.Generic;
using System.Linq;

class PairsByDifference
{
    static void Main()
    {
        string inputNums = Console.ReadLine();

        int[] numsArray = inputNums.Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());

        Console.WriteLine(CountPairsByDifference(numsArray, difference));
    }

    static int CountPairsByDifference(int[] numsArray, int difference)
    {
        int arrayLenght = numsArray.Length;
        int differenceCounter = 0;

        for (int i = 0; i < arrayLenght - 1; i++)
        {
            for (int r = i + 1; r < arrayLenght; r++)
            {
                if (Math.Abs(numsArray[i] - numsArray[r]) == difference)
                {
                    differenceCounter++;
                }
            }
        }

        return differenceCounter;
    }
}

