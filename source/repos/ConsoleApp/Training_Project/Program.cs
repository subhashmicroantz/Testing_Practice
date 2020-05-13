using CSharp_Training_Project;
using CSharp_Training_Project.Abstract;
using CSharp_Training_Project.Collections;
using CSharp_Training_Project.polymorphism;
using CSharp_Training_Project.propety;
using System;
using System.Collections.Generic;

namespace Training_Project
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            //PROPORTIES

            proporties prop = new proporties();
            prop.Name = "BBBBB";
           
            Console.WriteLine(prop.Name);
                
            //COLLECTIONS
            /*
                        List<String> car = new List<String>();
                        car.Add("S1");
                        car.Add("S2");
                        car.Add("S3");
                        car.Add("S4");

                        Console.WriteLine(car[0]);

                        List<String> Car1= new List<string>() { "S1", "S2", "S3", "S4", "S5", "S6" };
                        Car1.Add("s7");
                        Car1.Add("S8");


                        Console.WriteLine(Car1.Count);

                        Console.WriteLine(Car1[4]);

                        foreach (var item in Car1)
                        {
                            Console.WriteLine(item);
                        }
            
            List<Employee> EmpiList = new List<Employee>();

            Employee Emp1 = new Employee("subbu", 101, "Tester");
            EmpiList.Add(Emp1);

            Employee Emp2 = new Employee("Subhash", 102, "Tester");
            EmpiList.Add(Emp2);


            foreach (var item in EmpiList)
            {
                Console.WriteLine(item.EmployeeName);
                Console.WriteLine(item.EmployeeID);
                Console.WriteLine(item.EmployeeRole);
                Console.WriteLine(" ------------------------------------------ ");
            }
            
    */




            //Constructers cc = new Constructers();
            //Constructers cc1 = new Constructers("AUDI");
            //Constructers cc2 = new Constructers("Benz");
            //Constructers cc3 = new Constructers("HONDA");
            //Access_Modifier AM = new Access_Modifier();
            //Derived AM1 = new Derived();
            //AM1.Method3();

            //   derived2 callConst = new derived2();

            //            Jagur J; // Object define
            //#
            //            J = new jague_Espac(); // Class initialize

            //            J.ModelDetails();

            //Nokia Mobile;

            //Mobile = new A1();


        }
    }
}
