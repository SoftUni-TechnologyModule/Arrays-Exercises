using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] firstLineWords = Console.ReadLine().Split(' ').ToArray();
        string[] secondLineWords = Console.ReadLine().Split(' ').ToArray();

        int min = Math.Min(firstLineWords.Length, secondLineWords.Length);
        int max = Math.Max(firstLineWords.Length, secondLineWords.Length);
        int wordsCounterLeft = 0;
        int wordsCounterRight = 0;

        for (int i = 0; i < min; i++)
        {
            if (firstLineWords[i] == secondLineWords[i])
                wordsCounterLeft++;
        }
        for (int i = max - 1; i >= 0; i--, min--)
        {

            if (firstLineWords.Length > secondLineWords.Length)
            {
                if (min > 0)
                {
                    if (firstLineWords[i] == secondLineWords[min - 1])
                        wordsCounterRight++;
                }
                else
                    break;
            }
            else
            {
                if (min > 0)
                {
                    if (secondLineWords[i] == firstLineWords[min - 1])
                        wordsCounterRight++;
                }
                else
                    break;
            }
        }
        if (wordsCounterLeft == 0 && wordsCounterRight == 0)
            Console.WriteLine("0");
        else if (wordsCounterLeft > wordsCounterRight)
            Console.WriteLine(wordsCounterLeft);
        else
            Console.WriteLine(wordsCounterRight);
    }
}
