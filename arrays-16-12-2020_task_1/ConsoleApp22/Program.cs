using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] words = new string[2,3];
           
            Console.WriteLine("Please enter 6 words: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    words[i, j] = Console.ReadLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (words[i,j].Contains("one"))
                    {
                        
                        Console.WriteLine(words[i, j]);

                    }
                }
                
            }

        }//Men tapşirigin heca hissesini ötürdüm, cunki nece edeceyimi bilmirem ve zehmet olmasa onu misal uzerinde bize izah edin.
    }
}
