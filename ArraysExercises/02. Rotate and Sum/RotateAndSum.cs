using System;
using System.Linq;

class RotateAndSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int turns = int.Parse(Console.ReadLine());       
        int[] sum = new int[nums.Length];

        for (int i = 0; i < turns; i++)
        {
            int temp = nums[nums.Length - 1];
            for (int j = nums.Length - 1; j >= 1; j--)
            {
                nums[j] = nums[j - 1];
            }

            nums[0] = temp;

            for (int q = 0; q < nums.Length; q++)
            {
                sum[q] += nums[q];
            }
        }

        Console.WriteLine(string.Join(" ", sum));
    }
}

