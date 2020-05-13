using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Basic_Concepts
{
    class Variables
    {
        static void Main(string[] args)
        {
            string name = "Subhash";
            Console.WriteLine(name);

            int myNum = 15;
            Console.WriteLine(myNum);

            string firstname = "Lanka";
            string secondname = "Subhash";
            string fullname = firstname + secondname;

            Console.WriteLine(fullname);

            AdditionMethod(20,30);
            Multi();
        }

        static void AdditionMethod()
        {
            int x = 2, y = 3;
            int z = x + y;

            Console.WriteLine(z);
        }

        static void AdditionMethod(int xVal, int yVal)
        {
            int x = xVal, y = yVal;
            int z = x + y;
            Console.WriteLine(z);
        }


        static void Multi()
        {
            int x = 2, y = 6;
            int z = x * y;
            Console.WriteLine(z);

        }



         
           
         
}

}
