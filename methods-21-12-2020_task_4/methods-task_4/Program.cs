using System;
using System.Collections.Generic;

namespace methods_task_4
{
    public class Program
    {

        public static void Main(string[] args)
        {

            List<string> wordsList = new List<string>();
            List<string> list2 = new List<string>();
            string s = "";
            char c = 'y';

        firstRequest:
            Console.WriteLine();
            Console.WriteLine("Zehmet olmasa sozler daxil edin.");
            for (int i = 0; i < 3; i++)
            {
                s = Console.ReadLine();
                wordsList.Add(s);
            }
            
            Console.WriteLine("Daha 3 soz yazmaq isteyirsiz? Y/N");
            ConsoleKey pressedKey = Console.ReadKey().Key;
            if (pressedKey == ConsoleKey.Y)
            {
                goto firstRequest;
            }
            else if (pressedKey == ConsoleKey.N)
            {
                Console.WriteLine();
                Console.WriteLine("Zehmet olmasa bir herf daxil edin.\nEger secim etmek istemirsinizse  ~ duymesini secin.");
                if (pressedKey == ConsoleKey.Oem3)
                {

                }
                else if (pressedKey != ConsoleKey.Oem3)
                {
                    c = char.Parse(Console.ReadLine());
                }
                else
                {

                }

            }

            foreach (string item in wordsList)
            {
                Console.WriteLine($"{item} - {item.GetLetterCount(c)}");

            }

        }

    } 

}
