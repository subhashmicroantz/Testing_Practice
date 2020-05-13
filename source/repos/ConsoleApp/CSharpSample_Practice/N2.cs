using System;

namespace CSharpSample_Practice
{
    public class N2 : Nokia
    {
        public override void Battery()
        {
            Console.WriteLine("N2 : Battery");
        }
        public override void Display()
        {
            Console.WriteLine("N2 : Display");
        }
    }
}