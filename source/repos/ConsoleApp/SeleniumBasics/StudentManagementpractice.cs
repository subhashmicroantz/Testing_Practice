using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumBasics
{
    public class StudentManagementpractice
    {
        IWebDriver driver;

        public StudentManagementpractice()
        {
            driver = new ChromeDriver();
        }

        public void LoginVerifaction()
        {
            driver.Navigate().GoToUrl("http://karankitrainings.epizy.com");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //Login Function

            driver.FindElement(By.Id("id")).SendKeys("admin");
            driver.FindElement(By.Id("password")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@name='submit']")).Click();

            Thread.Sleep(3000);

            //

            //Logout Function

            driver.FindElement(By.LinkText("Logout")).Click();

            //driver.FindElement(By.);

            driver.Quit();

        }



    }
}

