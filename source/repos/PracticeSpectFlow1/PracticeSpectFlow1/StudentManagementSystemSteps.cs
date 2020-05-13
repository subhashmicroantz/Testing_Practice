using System;
using TechTalk.SpecFlow;

namespace PracticeSpectFlow1
{
    [Binding]
    public class StudentManagementSystemSteps
    {
        [Given(@"I have entered username as ""(.*)""")]
        public void GivenIHaveEnteredUsernameAs(string Username)
        {
            Console.WriteLine("UserName");
        }
        
        [Given(@"I have entered password as ""(.*)""")]
        public void GivenIHaveEnteredPasswordAs(string Password)
        {
            Console.WriteLine("Password");
        }
        
        [When(@"I press submit button")]
        public void WhenIPressSubmitButton()
        {
            Console.WriteLine("Submitted");   
        }
        
        [Then(@"I Can able to login successfully")]
        public void ThenICanAbleToLoginSuccessfully()
        {
            Console.WriteLine("Login Successfully");
        }

        [Then(@"Im unable to login successfully")]
        public void ThenImUnableToLoginSuccessfully()
        {
            Console.WriteLine("Login Unsuccessfull");
        }

    }


}
