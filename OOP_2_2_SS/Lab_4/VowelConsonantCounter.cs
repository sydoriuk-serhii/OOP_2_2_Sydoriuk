namespace OOP_2_2_SS.Lab_4;

using System;
using System.IO;
using System.Collections.Generic;

class VowelConsonantCounter
{
    static void CountVowelsAndConsonantsText(char[] chars)
    {
        int vowels = 0, consonants = 0, otherChars = 0;

        foreach (char c in chars)
        {
            if (IsVowel(c))
            {
                vowels++;
            }
            else if (IsConsonant(c))
            {
                consonants++;
            }
            else
            {
                otherChars++;
            }
        }
    }

    
    public VowelConsonantCounter()
    {
        string text =
            File.ReadAllText(
                "C:\\\\Users\\\\liser\\\\RiderProjects\\\\OOP_2_2_Sydoriuk\\\\OOP_2_2_SS\\\\Lab_4\\\\text.txt");

        List<char> chars = new List<char>(text.ToCharArray());
        char[] charstext = text.ToCharArray();
        var results = CountVowelsAndConsonants(chars);
        Console.WriteLine("Vowels: " + results.Vowels);
        Console.WriteLine("Consonants: " + results.Consonants);
        Console.WriteLine("OtherChars: " + results.OtherChars);
    }

    public (int Vowels, int Consonants, int OtherChars) CountVowelsAndConsonants(List<char> chars)
    {
        int vowels = 0, consonants = 0, otherChars = 0;

        foreach (char c in chars)
        {
            if (IsVowel(c))
            {
                vowels++;
            }
            else if (IsConsonant(c))
            {
                consonants++;
            }
            else
            {
                otherChars++;
            }
        }

        return (vowels, consonants, otherChars);
    }

    static bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) != -1;
    }

    static bool IsConsonant(char c)
    {
        return char.IsLetter(c) && !IsVowel(c);
    }
}