using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training_Project.Abstract
{
    public class A2 : Nokia
    {
        public override void Display()
        {
            Console.WriteLine("A2 Model Display");
        }

        public override void Battery()
        {
            Console.WriteLine("A2 Model Battery");
        }
    }
}
