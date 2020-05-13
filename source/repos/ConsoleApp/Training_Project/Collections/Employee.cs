using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Training_Project.Collections
{
   public class Employee
    {
        public string EmployeeName;
        public int EmployeeID;
        public string EmployeeRole;

        public Employee()
        {

        }

        public Employee(string Name, int ID, string Role )
        {
            EmployeeName = Name;
            EmployeeID = ID;
            EmployeeRole = Role;
        }
    }
}
