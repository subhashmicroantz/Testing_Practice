﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace PracticeSpectFlow1
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario Mesg");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario Mesg");
        }
    }
}
