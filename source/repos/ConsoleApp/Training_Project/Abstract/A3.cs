using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training_Project.Abstract
{
    public class A3 : Nokia
    {
        public override void Battery()
        {
            Console.WriteLine("A3 Model Battey");
        }

        public override void Display()
        {
            Console.WriteLine("A3 Model Display");
        }
    }
}
