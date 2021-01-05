using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine();
        }
        public virtual void Walk()
        {
            Console.WriteLine();
        }
        public abstract void getInfo();
    }
}
