using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training_Project
{
   public class Derived : Access_Modifier
    {
        public Derived()
        {
            Console.WriteLine("Constructer2");
        }
        public void Method3()
        {
            Method2();
            Console.WriteLine("Method3");
        }

    }
}
