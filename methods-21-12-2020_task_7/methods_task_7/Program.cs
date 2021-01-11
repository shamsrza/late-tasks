using System;

namespace methods_task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            date = date.AddDays(-2);
            date = date.AddHours(1);
            Console.WriteLine(date.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}
