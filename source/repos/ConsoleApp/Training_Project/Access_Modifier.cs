using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training_Project
{
   public class Access_Modifier
    {
        public Access_Modifier()
        {
            Console.WriteLine("Constructer1");
        }
        private void Method1()
        {
            Console.WriteLine("Method1");
        }
        protected void Method2()
        {
            Method1();
            Console.WriteLine("Method2");
        }
    }
}
