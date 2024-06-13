namespace OOP_2_2_SS.Lab_4;

using System;
using System.IO;
using System.Collections.Generic;

class VowelConsonantCounter
{
    public VowelConsonantCounter()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 
        start:
        string filePath = "C:\\Users\\liser\\RiderProjects\\OOP_2_2_Sydoriuk\\OOP_2_2_SS\\Lab_4\\text.txt";
        string text = File.ReadAllText(filePath);
        
        char[] charArray = text.ToCharArray();
        List<char> charList = new List<char>(charArray);
        
        Console.WriteLine("Виберіть метод перевірки:");
        Console.WriteLine("1. Перевірити кількість символів за допомогою масиву");
        Console.WriteLine("2. Перевірити кількість символів за допомогою списку");
        int choice = ReadInteger();

        switch (choice)
        {
            case 1:
                CountVowelsAndConsonantsArray(charArray);
                goto start;
            case 2:
                CountVowelsAndConsonantsList(charList);
                goto start;
            default:
                Console.Write("Невiрний варіант рішення. Введiть '1' або '2': ");
                goto start;
        }
    }

    static void CountVowelsAndConsonantsArray(char[] chars)
    {
        int vowels = 0, consonants = 0;

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
        }
        Console.WriteLine("Голосні: " + vowels);
        Console.WriteLine("Приголосні: " + consonants);
    }

    static void CountVowelsAndConsonantsList(List<char> chars)
    {
        int vowels = 0, consonants = 0;

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
        }
        Console.WriteLine("Голосні: " + vowels);
        Console.WriteLine("Приголосні: " + consonants);
    }

    static bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) != -1;
    }

    static bool IsConsonant(char c)
    {
        return char.IsLetter(c) && !IsVowel(c);
    }
    static int ReadInteger()
    {
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Невiрний формат числа. Введiть integer: ");
        }
        return x;
    }
}
