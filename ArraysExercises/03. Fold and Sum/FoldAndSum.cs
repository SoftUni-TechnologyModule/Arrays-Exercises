using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int len = nums.Length / 2;
        int[] firstRow = new int[len];
        int[] secondRow = new int[len];
        int[] sum = new int[len];

        int index = len / 2 - 1;

        GetFirstRow(index, len, nums, firstRow);
        GetSecondRow(len, nums, secondRow);
        GetAndPrintResult(len, sum, firstRow, secondRow);  
    }

    static void GetAndPrintResult(int len, int[] sum, int[] firstRow, int[] secondRow)
    {
        for (int i = 0; i < len; i++)
        {
            sum[i] = firstRow[i] + secondRow[i];
        }

        Console.WriteLine(string.Join(" ", sum));
    }

    static int[] GetSecondRow(int len, int[] nums, int[] secondRow)
    {
        for (int i = 0; i < len; i++)
        {
            secondRow[i] = nums[len / 2 + i];
        }

        return secondRow;
    }

    static int[] GetFirstRow(int index, int len, int[] nums, int[] firstRow)
    {
        for (int i = 0; i < len; i++)
        {
            if (i < len / 2)
            {
                firstRow[index] = nums[i];
                index--;
            }
            else if (i >= len / 2)
            {
                index++;
                firstRow[i] = nums[nums.Length - 1 - index];
            }
        }

        return firstRow;
    }
}

