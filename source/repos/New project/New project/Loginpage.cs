using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace New_project
{
    class Loginpage
    {
        private readonly IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void AssertTitle(string title)
        {
            string pageTitle = _driver.Title;
            pageTitle.Should().Be(title);
        }
    }
}
