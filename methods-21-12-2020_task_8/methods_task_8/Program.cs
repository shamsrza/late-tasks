using System;

namespace methods_task_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1988,10,29);
            Console.WriteLine($"Year: {birthday.Year}\nMonth: {birthday.Month}\nDay: {birthday.Day}");
            Console.WriteLine($"{birthday.ToString("dd.MM.yyyy")} = {Age(birthday)}");
        }

        private static int Age(DateTime birthday)
        {
            int age = 0;
            age = DateTime.Now.Year - birthday.Year ;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age = age - 1;

            return age;
        }
    }
    
}
