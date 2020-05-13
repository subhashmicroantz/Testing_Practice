using System;

namespace Selenium_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeStudentManagement Smlist = new PracticeStudentManagement();

            Smlist.Sudentloginpage();
            Smlist.Studentlogin();
            Smlist.Courseview();
            Smlist.SubjectView();
            Smlist.Add_Course();
            Smlist.Delete_Course();
           // Smlist.Studentlogout();
            Smlist.Quit();


        }
    }
}
