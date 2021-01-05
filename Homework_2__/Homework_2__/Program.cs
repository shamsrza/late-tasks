using System;

namespace Homework_2__
{
    class Program
    {
        static void Main(string[] args)
        {
        /* İstifadəçidən aşağıdaki şərtlərə uyğun İNGİLİSCƏ söz yazılması istənilsin:
           a) Söz 5 hərfdən ibarət olmalıdır.

           b) Sözdə "a" hərfindən istifadə olunmamalıdır.

           c) Sözdə ən azı bir ədəd "b" hərfi olmalıdır.

           d) Sözün sonunda mütləq nöqtə (".") olmalıdır.
        Əgər şərtlərdən biri pozularsa proqram yenidən başlasın, əks halda davam etsin.
        Sözdə olan bütün "u" hərflərini "k" ilə əvəz et.
        Sözdə olan bütün "z" hərflərini sil.
        Sözdə olan bütün "o" hərflərini böyük et ("O").  
        Sözdə olan bütün "L" hərflərini balaca et ("l").
        Sözün son hecasını ilk hecaya bitişdir.
        Məsələn: "urban" olmalıdır "banur". "ur" və "ban" hecalarında "ban" keçir önə. - BUNU DEDIYINIZ KIMI SKIP ELEDIM */

        START:
            Console.Write("Please enter 5-letter word: ");
            string word = Console.ReadLine();
            bool a = word.Contains('a');
            bool b = word.Contains('b');
            bool u = word.Contains('u');
            bool z = word.Contains('z');
            bool o = word.Contains('o');
            bool L = word.Contains('L');


           for (int i = 0; i < 1; i++)
            {
                if (word.Length == 6 && !a && b == true && word[word.Length - 1] == '.')
                {
                    if (u == true || z == true || o == true || L == true )
                    {
                        word = word.Replace('u', 'k');
                        word = word.Remove(word.IndexOf('z'));
                        word = word.Replace('o', 'O');
                        word = word.Replace('L', 'l');
                        Console.WriteLine(word);
                    }
       
                }
                else
                {
                    goto START;
                }
            }
                


        }
    }
}
