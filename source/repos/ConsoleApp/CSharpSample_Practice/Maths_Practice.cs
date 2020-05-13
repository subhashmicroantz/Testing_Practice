using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpSamples
{
    public class Maths_Practice
    {
        public int i;
        public int x;
        public int y;
        public int z;
        public string str;

        public void DefaultMethod()
        {
            Console.WriteLine("Subash name");
        }

        internal void MethodP()
        {
            throw new NotImplementedException();
        }

        public void MethodP(string name)
        {
            Console.WriteLine("My Name is " + name);
        }


        public void MethodA(string name2)
        {
            Console.WriteLine(name2);
        }

        public void MethodValuex(int xval)
        {
            x = xval;
            Console.WriteLine(x);

        }
        public void MethodValuey(int yval)
        {
            y = yval;
            Console.WriteLine(y);
        }

        public void MethodAdd()
        {
            int z = x + y;
            Console.WriteLine(z);
        }



    }
}
