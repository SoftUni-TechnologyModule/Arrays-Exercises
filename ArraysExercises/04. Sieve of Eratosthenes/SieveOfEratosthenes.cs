using System;
using System.Collections.Generic;
using System.Linq;

class SieveOfEratosthenes
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        GetAndPrintPrimeNumbers(input);
    }

    private static void GetAndPrintPrimeNumbers(int input)
    {
        bool[] isPrime = new bool[input + 1];

        for (int i = 2; i <= input; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i <= input; i++)
        {
            if (!isPrime[i])
            {
                continue;
            }
            Console.Write($"{i} ");
            for (int r = i + i; r <= input; r += i)
            {
                isPrime[r] = false;
            }
        }

        Console.WriteLine();
    }
}
