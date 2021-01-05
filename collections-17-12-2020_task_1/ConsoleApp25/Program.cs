using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            dict1.Add("Hormetli istifadeci! Zehmet olmasa olke adi qeyd edin: ", "Hormetli istifadeci! Zehmet olmasa olkeye aid paytaxt qeyd edin: ");

            List<string> list = new List<string>();
            
            for (int i = 0; i < 10; i++)
            {

                foreach (KeyValuePair<string, string> kvp1 in dict1)
                {
                    Console.WriteLine(kvp1.Key);
                    list.Add(Console.ReadLine());
                }

                foreach (KeyValuePair<string, string> kvp1 in dict1)
                {
                    Console.WriteLine(kvp1.Value);
                    list.Add(Console.ReadLine());
                }

            }

            Dictionary<string, string> dict3 = new Dictionary<string, string>();
            dict3.Add("Hormetli istifadeci! Zehmet olmasa paytaxtini tapmaq istediyiniz olkenin adini qeyd edin: ", "Baki");
            foreach (KeyValuePair<string, string> kvp2 in dict3)
            {
                Console.WriteLine(kvp2.Key);
                string ask = Console.ReadLine();

                if (ask == "Azerbaycan")
                {
                    Console.WriteLine(kvp2.Value);
                    Console.ReadLine();
                }
                else if (ask == "all")
                {
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            Console.WriteLine("Yeni paytaxt axtarılsın? Y/N");
            string newRequest = Console.ReadLine();
            if (newRequest == "Y")
            {
                Console.WriteLine("Hormetli istifadeci! Zehmet olmasa yeni axtaris ucun olke adini qeyd edin: ");
                Console.ReadLine();
            }
            else if (newRequest == "N")
            {

            }

        }
    }
}
