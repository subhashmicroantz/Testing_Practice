using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training_Project.Abstract
{
   public class A1: Nokia
    {
        public override void Battery()
        {
            Console.WriteLine("Model A1 Battery");
        }

        public override void Display()
        {
            Console.WriteLine("Model A1 Display");
        }
    }
} 
