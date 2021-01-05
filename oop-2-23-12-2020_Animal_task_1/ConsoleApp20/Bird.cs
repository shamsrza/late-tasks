using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    class Bird : Animal
    {
        
        public void Fly()
        {
            Console.WriteLine();
        }

        public override void getInfo()
        {
            Console.WriteLine("This is bird");
        }
        public override void Walk()
        {
            Console.WriteLine("Bird is jumping");
        }

        
        

    }
}
