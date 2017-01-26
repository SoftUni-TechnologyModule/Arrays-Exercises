using System;
using System.Collections.Generic;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        string firstLetters = Console.ReadLine();
        string secondLetters = Console.ReadLine();

        string[] firstArray = firstLetters.Split(' ').ToArray();
        string[] secondArray = secondLetters.Split(' ').ToArray();

        PrintEqualLetters(firstArray, secondArray);
        
    }

    static void PrintEqualLetters(string[] firstArray, string[] secondArray)
    {
        if (CheckIsLettersEqual(firstArray, secondArray) && firstArray.Length == secondArray.Length)
        {
            Console.WriteLine(string.Join("", firstArray) + "\n" + string.Join("", secondArray));
        }
        else if (CheckIsLettersEqual(firstArray, secondArray) && firstArray.Length < secondArray.Length)
        {
            Console.WriteLine(string.Join("", firstArray) + "\n" + string.Join("", secondArray));
        }
        else if (CheckIsLettersEqual(firstArray, secondArray) && firstArray.Length > secondArray.Length)
        {
            Console.WriteLine(string.Join("", secondArray) + "\n" + string.Join("", firstArray));
        }
        else
        {
            PrintNotEqualArrays(firstArray, secondArray);
        }
    }

    static void PrintNotEqualArrays(string[] firstArray, string[] secondArray)
    {
        if (firstArray[0].CompareTo(secondArray[0]) == 1)
        {
            Console.WriteLine(string.Join("", secondArray) + "\n" + string.Join("", firstArray));
        }
        else
        {
            Console.WriteLine(string.Join("", firstArray) + "\n" + string.Join("", secondArray));
        }
    }

    static bool CheckIsLettersEqual(string[] firstArray, string[] secondArray)
    {
        int minLenght = Math.Min(firstArray.Length, secondArray.Length);
        bool isEqual = false;
        for (int i = 0; i < minLenght; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                isEqual = true;
            }
            else
            {
                break;
            }
        }

        return isEqual;
    }
}

