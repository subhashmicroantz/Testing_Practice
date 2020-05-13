using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumBasics
{
    public class StudentManagement
    {

        IWebDriver driver;

        public StudentManagement()
        {
            driver = new ChromeDriver();
            //driver = new InternetExplorerDriver();
        }

        public void VerifyLoginLogin()
        {
            
            driver.Navigate().GoToUrl("http://karankitrainings.epizy.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Login functionality
            driver.FindElement(By.Id("id")).SendKeys("admin");
            driver.FindElement(By.Id("password")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@name='submit']")).Click();

        }         

        /* Creating new Course*/
        public void CourseCreation()
        {
            //Addings Short course name
            driver.FindElement(By.CssSelector("#cshort")).SendKeys("C# Selenium");

            //Adding Full course name
            driver.FindElement(By.XPath("//input[@id='cfull']")).SendKeys("C# Selenium Automation");

            //Click Create Course
            driver.FindElement(By.ClassName("btn")).Click();

            Thread.Sleep(3000);

            //Handle Alert Message
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            
        }

        public void VerifyCourseAndDelete()
        {

        }

        /* Logut Student Management*/
        public void VerifyLogOut()
        {
            Thread.Sleep(2000);

            //Logout Functionality
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        /* To Close WebDriver */
        public void QuitDriver()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }

    }
}
