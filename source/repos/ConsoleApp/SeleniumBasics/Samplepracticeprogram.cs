using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasics
{
    public class Samplepracticeprogram

    {
        public void practice()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://crossbrowsertesting.github.io/");
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Selenium Example Page")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Go To Page 2")).Click();
            Thread.Sleep(3000);




            driver.Quit();
        }
    }

}
