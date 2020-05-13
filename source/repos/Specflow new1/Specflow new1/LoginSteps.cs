using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Specflow_new1
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver;

        

        [Given(@"I have entererd user name as '(.*)'")]
        public void GivenIHaveEntererdUserNameAs(string username)

        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://karankitrainings.epizy.com/pages/login.php");

            driver.FindElement(By.Id("id")).SendKeys(username); 
        }
        
        [Given(@"I have entererd password as '(.*)'")]
        public void GivenIHaveEntererdPasswordAs(string password)
        {
            driver.FindElement(By.Id("password")).SendKeys(password);
        }
        
        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
        
        [Then(@"I should be login successfully")]
        public void ThenIShouldBeLoginSuccessfully()
        {
            driver.Quit();
        }
    }
}
