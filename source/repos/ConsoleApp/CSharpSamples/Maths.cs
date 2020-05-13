using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples
{
   public class Maths
    {
        int x;
        int y;

        public Maths()
        {
            x = 130;
            y = 200;
        }

        public void MyAddition()
        {
            int z = x + y;
            Console.WriteLine(z);

        }

        public int Addition(int x, int y)
        {
            return  x + y;
        }



           

    }
}
