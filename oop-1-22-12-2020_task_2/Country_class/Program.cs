using System;

namespace Country_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Country countryInfo = new Country()
            {
                name = "Poland",
                capital = "Warsaw",
                population = 37846611,
                seaName = "Baltic"
            };

            //if (seaName == null)
            //    seaName = "There is no sea";
            seaName ??= "There is no sea";

            Console.WriteLine(countryInfo.name);
            Console.WriteLine(countryInfo.capital);
            Console.WriteLine(countryInfo.population);
            Console.WriteLine(countryInfo.seaName);
            //Console.WriteLine(countryInfo.seaName?? "There is no sea");

        }
    }
}
