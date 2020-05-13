using System;

namespace CSharpSample_Practice
{
    public class Methods_OverLoad
    {
        public void Additionover(int a, int b)
        {
            Console.WriteLine(a + b);

        }

        public void Additionover(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }

        public void Additionover(int a, int b, int c, int d)
        {
            Console.WriteLine(a + b + c + d);
        }
        public void Additionover(String s, int x)
        {
            Console.WriteLine(s + x);
        }
        public void Additionover(double a, double b)
        {
            Console.WriteLine(a+b);
        }
        public void Additionover(String S1, String S2)
        {
            Console.WriteLine(S1+S2);
        }

        public void Multi(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Multi(int x, int y, int z)
        {
            Console.WriteLine(x*y*z);
            Console.WriteLine(x*+(z-y));  
        }
       public void Multi(int x, int y, int z, int a)
        {
            Console.WriteLine((x+y)-(z*a));
        }


                   
    }
}
