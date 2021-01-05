using System;

namespace Homework_15_Dec
{
    class Program
    {
        static void Main(string[] args)
        {
        /*a = 3 rəqəmli ədəd daxil edin (rəqəm sayı 3 olmazsa proqram yeni rəqəm istəsin)
         b = 5 rəqəmli ədəd daxil edin (rəqəm sayı 5 olmazsa proqram yeni rəqəm istəsin)
         a-nın İLK 2 rəqəmini, b-nin isə SON 4 rəqəmini string kimi birləşdirib daha sonra rəqəmə çevirin.
         Alınan ədədin son 3 rəqəmindən ilk 3 rəqəmini çıxın.
         Nəticə mənfi olarsa proqram başdan başlamalıdır.
         Misal üçün:
         a = 142; b = 25152;

         a-nın ilk 2 rəqəmi: 14. b-nin son 3 rəqəmi: 5152.

         String kimi birləşdirdikdə 145152 alırıq. Daha sonra aldığımız ədədin son 3 rəqəmindən ilk 3 rəqəmini çıxırıq:

         145152: son 3 rəqəmi: 152 ilk 3 rəqəmi: 145

         145-152=-7. Cavab mənfi alındığı üçün proqram yenidən çalışmalıdır.
         */


            START:
            tryAgain1:
            Console.Write("Please enter 3-digits number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int attemptLimit = 1;
            
            for (int i = 0; i < attemptLimit; i++)
            {
                if (num1 >= 100 && num1 <= 999)
                {
                   Console.Write("Correct!");
                }
                else if (num1 < 100 || num1 > 999)
                {
                    Console.Write("Invalid Number. Please try again: ");
                } else
                {
                    goto tryAgain1;
                }
                Console.ReadLine();
            }

            tryAgain2:
            Console.Write("Please enter 5-digits number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < attemptLimit; i++)
            {
                if (num2 >= 10000 && num2 <= 99999)
                {
                    Console.Write("Correct!");
                } else if (num2 < 10000 || num2 > 99999) 
                {
                    Console.Write("Invalid Number. Please try again: ");
                }
                else
                {
                   goto tryAgain2;
                }
                Console.ReadLine();
            }

            string a = num1.ToString();
            a = a.Remove(2, 1);
            Console.WriteLine(a);

            string b = num2.ToString();
            b = b.Substring(1);
            Console.WriteLine(b);

            var s = String.Concat(a, b);
            //Console.WriteLine(s);

            int resultNum = Int32.Parse(s);
            Console.WriteLine(resultNum);
            resultNum = (resultNum % 1000) - ((resultNum - (resultNum % 1000)) / 1000);
            if ( resultNum > 0)
            {
                Console.WriteLine(resultNum);
            }
            else
            {
                goto START;
            }

            Console.ReadLine();

        }

    }
    }
