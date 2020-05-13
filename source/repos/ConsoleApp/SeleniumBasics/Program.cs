using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentManagement sm;
            sm = new StudentManagement();
            sm.VerifyLoginLogin();
            sm.CourseCreation();
            sm.VerifyLogOut();
            sm.QuitDriver();

           // StudentManagementpractice obj = new StudentManagementpractice();
            //obj.LoginVerifaction();

            //Samplepracticeprogram scp = new Samplepracticeprogram();
            //scp.practice();


        }
    }
}
