using System;

namespace LastHomeworks
{
    class Program
    {
        public static void Main(string[] args)
        {

            int sum = 0;
            Console.WriteLine("Enter count of numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your numbers: ");
            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                string number = Console.ReadLine();
                myArray[i] = Convert.ToInt32(number);
            }
            //Console.ReadLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine(sum);
        }

    }
}