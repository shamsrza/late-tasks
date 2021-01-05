using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sortedNum = new int[5];
            int[] reversedNum = new int[5];
            int[] numbers = new int[5];
            Console.WriteLine("Eded daxil edin: ");

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            //sort
            for (int i = 0; i < 5; i++)
            {
                Array.Sort(numbers);
                sortedNum = numbers;
            }

            Console.WriteLine("Sorted: ");
            foreach (int val in numbers)
            {
                Console.WriteLine(val);
            }


            //reverse
            Console.WriteLine("Reversed: ");
            for (int i = 0; i < 5; i++)
            {
                Array.Reverse(sortedNum);
                reversedNum = sortedNum;
            }

            foreach (int val in sortedNum)
            {
                Console.WriteLine(val);
            }




        }

    }//Array.Reverse(numbers); 
}
