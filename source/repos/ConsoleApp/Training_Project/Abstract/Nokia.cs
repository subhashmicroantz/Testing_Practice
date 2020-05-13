using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training_Project.Abstract
{
   public abstract class Nokia
    {
        public void OS()
        {
            Console.WriteLine("Display Nokia OS");
        }

        public abstract void Battery();


        public abstract void Display();
       
        public void Charger()
        {
            Console.WriteLine("Nokia Charger");
        }
    }
}
