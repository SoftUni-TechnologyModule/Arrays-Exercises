using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        char[] word = Console.ReadLine().ToLower().ToArray();

        GetLettersIndex(word);
    }

    static void GetLettersIndex(char[] word)
    {
        char[] alphabet = new char[26];
        char firstLetter = 'a';

        for (int i = 0; i < alphabet.Length; i++, firstLetter++)
        {
            alphabet[i] = firstLetter;
        }

        for (int i = 0; i < word.Length; i++)
        {
            for (int r = 0; r < alphabet.Length; r++)
            {
                if (word[i] == alphabet[r])
                {
                    Console.WriteLine($"{word[i]} -> {r}");
                    break;
                }
            }
        }
    }
}

