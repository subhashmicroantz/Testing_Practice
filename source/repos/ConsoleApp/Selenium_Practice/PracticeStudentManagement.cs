using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_Practice
{
    public class PracticeStudentManagement
    {

        // IWebDriver driver = new ChromeDriver();
        // IWebDriver driver = new ChromeDriver();
        // IWebDriver driver = new FirefoxDriver();
        IWebDriver driver = new ChromeDriver();






        
        

        public void Sudentloginpage()

        {

            //Open Student Trainig WebPage

            driver.Navigate().GoToUrl("http://karankitrainings.epizy.com");
            //driver.Manage().Window.Maximize();
            driver.Manage().Window.Maximize();
            //driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
           

            Thread.Sleep(3000);

        }


        //Verify Login Functionality

        public void Studentlogin() 
        {
            driver.FindElement(By.Id("id")).SendKeys("admin");
            //driver.FindElement(By.Id("id")).SendKeys("admin");
            driver.FindElement(By.Id("password")).SendKeys("admin");
            
            driver.FindElement(By.XPath("//input[@name='submit']")).Click();
            driver.FindElement(By.LinkText("View")).Click();
           
            Thread.Sleep(2000);

        }



        ////Verify Courses 
        public void Courseview()
        {
           // driver.FindElement(By.ClassName("View")).Click();
            driver.FindElement(By.LinkText("View")).Click();
            Thread.Sleep(2000);
        }

        //Verify Subject
        public void SubjectView()
        {
            IWebElement subject = driver.FindElement(By.LinkText("Subject"));

            subject.Click();

           


            Thread.Sleep(2000);
        }

        

        // Verify Add Courses
        public void Add_Course()
        {
            driver.FindElement(By.LinkText("Course")).Click();
            driver.FindElement(By.LinkText("Add Course")).Click();
           // driver.FindElement(By.LinkText("Add Subject")).Click();
            driver.FindElement(By.Id("cshort")).SendKeys("MyCourse");
            driver.FindElement(By.Id("cfull")).SendKeys("MyCourseSelenium");
            driver.FindElement(By.XPath("//input[@class='btn btn-primary']")).Submit();
            Thread.Sleep(3000);

            HandleAlert();
        }


       


        //Delete Course FromList
        public void Delete_Course()
        {
            driver.FindElement(By.LinkText("View")).Click();
            driver.FindElement(By.XPath("//table//tr/td[5]/a[2]")).Click();

            //var list = driver.FindElements(By.XPath("//table//tr/td[5]/a[2]"));

            //foreach (var item in list)
            //{
            //    driver.FindElement(By.XPath("//table//tr/td[5]/a[2]")).Click();
            //    Thread.Sleep(2000);
            //    HandleAlert();
            //}

       
        }

        public void HandleAlert()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                Console.WriteLine("Alert Message :" + alert.Text);
                alert.Accept();
            }   // try 
            catch (NoAlertPresentException Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            
        }


        
        //Verift Add_Subject
      ////  public void AddSubject()
      //  {
      //      //    driver.FindElement(By.LinkText("Subject")).Click();
      //      //    driver.FindElement(By.LinkText("Add Subject")).Click();
      //     //driver.FindElement(By.XPath("//select[@'classform - control']"))
            
      //  //    //
      //  }


        //Verift View_Subject


        // View Student
        public void View_Student()
        {
            driver.FindElement(By.LinkText("View Students")).Click();
            //driver.FindElement(By.LinkText("View")).Click();
            //driver.FindElement(By.LinkText("View")).Click();

        }

        //LogOut Functionality


        public void Studentlogout() 
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }



        //Quit

        public void Quit()
        {


            driver.Quit();


        }

        

    }
}
