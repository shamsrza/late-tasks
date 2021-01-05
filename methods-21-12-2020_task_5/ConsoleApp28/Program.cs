using System;

namespace ConsoleApp28
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Plus obj = new Plus()
            {
                data = 5
            };

            ChangeData(ref obj);
            Console.WriteLine(obj.data);


            static void ChangeData(ref Plus _obj)
            {
                _obj.data = 15;
            }
        }
    }
}
