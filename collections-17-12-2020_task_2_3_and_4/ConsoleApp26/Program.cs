using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp26
{

    class Program
    {
        static void Main(string[] args)
        {
            //TASK 2
            /* Queue<string> fruits = new Queue<string>();
             fruits.Enqueue("apple");
             fruits.Enqueue("orange");
             fruits.Enqueue("lemon");
             fruits.Enqueue("melon");
             fruits.Enqueue("kiwi");
             fruits.Enqueue("banana");
             fruits.Enqueue("cherry");
             fruits.Enqueue("mango");
             fruits.Enqueue("pineapple");
             fruits.Enqueue("strawberry");
             fruits.Enqueue("grape");


             if (fruits.Count > 10)
             {
                 fruits.Dequeue();
                 fruits.Enqueue("avocado");               
             }

             foreach (var item in fruits)
             {
                 Console.WriteLine(item);
             } */




            // ***********   ************   **************   ***************



            //TASK 3
            /* List<int> numbers = new List<int>();
            
            Console.WriteLine("Please enter 10 different numbers: ");
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine())); 
            }


            for (int i = 0; i < 5 ; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[^(i + 1)];
                numbers[^(i + 1)] = temp;
            }
            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            } */



            // ***********   ************   **************   ***************


            
            //TASK 4
            /* HashSet<int> numbers = new HashSet<int>();
            Console.WriteLine("Please enter 5 different numbers: ");
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
            */
        }

    }        
}
