using System;

namespace methods_task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            AddData(ref a);
            Console.WriteLine(a);
            
        }

        public static void AddData(ref int x)
        {
            x = x + 10;
        }
    }
}
