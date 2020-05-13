using System;

namespace CSharpSample_Practice
{
    public abstract class Nokia
    {
        public void OS()
        {
            Console.WriteLine("Nokia : OS" );
        }

        public abstract void Battery();

        public abstract void Display();

        public void Screen()
        {
            Console.WriteLine("Nokia : SCreen");
        }
       
    }
}