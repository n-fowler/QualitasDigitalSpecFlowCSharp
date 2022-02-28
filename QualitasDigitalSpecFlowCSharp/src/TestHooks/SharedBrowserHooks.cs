using NUnit.Framework;
using QualitasDigitalSpecFlowCSharp.Extensions;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using System;
using TechTalk.SpecFlow;

namespace QualitasDigitalSpecFlowCSharp.src.TestHooks
{
    [Binding]
    public sealed class SharedBrowserHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            BrowserFactory.InitBrowserHeadless(BrowserFactory.WebDriver.Chrome);
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            BrowserFactory.CloseAllDrivers();
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Logging.SetTestRunId();
            Logging.TestStartTime = DateTime.Now;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Logging.TestEndTime = DateTime.Now;
            BrowserFactory.ReportTestStatus(TestContext.CurrentContext);
        }
    }
}