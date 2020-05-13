using System;
using TechTalk.SpecFlow;

namespace FirstSpecflowProject.Stepdefs
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            // ScenarioContext.Current.Pendin
            Console.WriteLine("AAAAAAA"+p0);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("BBB");
        }
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Console.WriteLine("CCCCC" + p0);
        }
    }
}
