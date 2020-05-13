using System;

namespace CSharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MethodCls obj = new MethodCls();

            obj.DefaultMethod();

            obj.MethodP("Vijay");

            obj.MethodA("viji");

            obj.MethodValuex(10);
            obj.MethodValuey(5);
            obj.MethodAdd();

            Maths newobj = new Maths();
            
            newobj.MyAddition();

            int returnVal = newobj.Addition(20, 30);

            Console.WriteLine(returnVal);



        }

        }
    }
