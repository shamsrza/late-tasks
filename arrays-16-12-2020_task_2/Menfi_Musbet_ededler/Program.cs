using System;

namespace Menfi_Musbet_ededler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [10];
            int countNegative = 0;
            int countPositive = 0;
            Console.WriteLine("Menfi ve musbet edebler daxil edin: ");

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] < 0)
                {
                    countNegative++; 
                } 
                else if (numbers[i] > 0)
                {
                    countPositive++;
                }
            }
            Console.WriteLine($"Menfi: {countNegative}");
            Console.WriteLine($"Musbet: {countPositive}");
        }
    }
}
