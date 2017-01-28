using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        char[] word = Console.ReadLine().ToLower().ToArray();
        char[] alphabet = new char[26];

        FillingAlphabetArray(alphabet);
        GetLettersIndex(word, alphabet);
    }

    static char[] FillingAlphabetArray(char[] alphabet)
    {
        char firstLetter = 'a';

        for (int i = 0; i < alphabet.Length; i++, firstLetter++)
        {
            alphabet[i] = firstLetter;
        }

        return alphabet;
    }

    static void GetLettersIndex(char[] word, char[] alphabet)
    {
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

