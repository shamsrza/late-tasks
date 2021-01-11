using System;

namespace methods_task_6
{
    class Program
    {
        static void Main(string[] args)
        {

            ChangeData(out int a, out int b, out int c, out int d);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }

        static void ChangeData(out int x, out int y, out int z, out int k)
        {
            x = 2;
            y = 4;
            z = 6;
            k = 8;
        }
    }
}
