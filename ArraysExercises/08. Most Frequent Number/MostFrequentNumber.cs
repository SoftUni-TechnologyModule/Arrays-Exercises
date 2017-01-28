using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        string nums = Console.ReadLine();

        ushort[] numsArray = nums.Split(' ').Select(ushort.Parse).ToArray();
        ushort len = (ushort)numsArray.Length;

        Console.WriteLine(GetMostFrequentNumber(numsArray, len)); 
    }

    static int GetMostFrequentNumber(ushort[] numsArray, ushort len)
    {
        ushort counter = 1;
        ushort bestCounter = 0;
        ushort element = 0;
            
        for (int i = 0; i < len-1; i++)
        {
            for (int r = i + 1; r < len; r++)
            {
                if (numsArray[i] == numsArray[r])
                {
                    counter++;                  
                }
                else
                {
                    continue;
                }
            }

            if (counter > bestCounter)
            {
                bestCounter = counter;
                element = numsArray[i];
            }

            counter = 1;
        }

        return element;
    }
}

