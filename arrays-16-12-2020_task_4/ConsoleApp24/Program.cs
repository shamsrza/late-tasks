using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[5];
            Console.WriteLine("Please enter 5 words: ");
            for (int i= 0; i < words.Length; i++)
            {
                words[i] = Console.ReadLine();
            }

            Console.WriteLine();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains('a') && words[i].Contains('o'))
                {
                    if (words[i].IndexOf('a') < words[i].IndexOf('o'))
                    {
                        Console.WriteLine(words[i].ToUpper());
                    }
                    else if (words[i].IndexOf('a') > words[i].IndexOf('o'))
                    {
                        Console.WriteLine(words[i].ToLower());
                    }
                }
                else if (words[i].Contains('a'))
                {
                    Console.WriteLine(words[i].ToUpper());
                }
                else if (words[i].Contains('o'))
                {
                    Console.WriteLine(words[i].ToLower());
                }
            }
        }
    }
}