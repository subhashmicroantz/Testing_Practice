using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Stepdefs
{
    [Binding]
    public sealed class Login_StepDef
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext context;

        public Login_StepDef(ScenarioContext injectedContext)
        {  
            context = injectedContext;
        }

        [Given(@"I have entererd user name as '(.*)'")]
        public void GivenIHaveEntererdUserNameAs(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [Given(@"I have entererd password as '(.*)'")]
        public void GivenIHaveEntererdPasswordAs(string p0)
        {
           // ScenarioContext.Current.Pending();
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"I should be login successfully")]
        public void ThenIShouldBeLoginSuccessfully()
        {
           // ScenarioContext.Current.Pending();
        }

    }
}
