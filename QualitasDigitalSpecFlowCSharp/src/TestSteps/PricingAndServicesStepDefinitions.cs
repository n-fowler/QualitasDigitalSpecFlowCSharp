using NUnit.Framework;
using QualitasDigitalSpecFlowCSharp.PageObjects;
using QualitasDigitalSpecFlowCSharp.src.TestData;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using TechTalk.SpecFlow;

namespace QualitasDigitalSpecFlowCSharp.src.TestSteps
{
    [Binding]
    public class PricingAndServicesStepDefinitions
    {
        [Given(@"\[The Pricing and Services Page is being visited]")]
        public void GivenThePricingAndServicesPageIsBeingVisited()
        {
            BrowserFactory.GoToPage(PricingAndServicesPage.Url);
        }

        [When(@"\[The Pricing and Services Page is visited]")]
        public void WhenThePricingAndServicesPageIsVisited()
        {
            BrowserFactory.WaitForPageLoad(10);
        }

        [Then(@"\[The Pricing and Services Logo is present]")]
        public void ThenThePricingAndServicesLogoIsPresent()
        {
            Assert.IsTrue(Page.PricingAndServices.LogoImage.Displayed, "Page.PricingAndServices.LogoImage.Displayed");
        }

        [Then(@"\[The Pricing and Services Content is present]")]
        public void ThenThePricingAndServicesContentIsPresent()
        {
            //Validate header
            Assert.AreEqual(PricingAndServicesPageTestData.PricingAndServicesTitle, Page.PricingAndServices.HeaderTitle.GetInnertext());

            //Validate left subsection
            Assert.AreEqual(PricingAndServicesPageTestData.PricingAndServicesSubtitle, Page.PricingAndServices.Subtitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.OurCommitmentLink, Page.PricingAndServices.OurCommitmentLink.GetHref());

            //Validate middle subsection
            Assert.AreEqual(PricingAndServicesPageTestData.AdditionalTestCoverageTitle, Page.PricingAndServices.AdditionalTestCoverageTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.AdditionalTestCoverageBodyText, Page.PricingAndServices.AdditionalTestCoverageBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesTitle, Page.PricingAndServices.FrameworkUpdatesTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesUpgradesBodyText, Page.PricingAndServices.FrameworkUpdatesUpgradesBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.FrameworkUpdatesCustomTailoredBodyText, Page.PricingAndServices.FrameworkUpdatesCustomTailoredBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.ProcessAutomationTitle, Page.PricingAndServices.ProcessAutomationTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.ProcessAutomationBodyText, Page.PricingAndServices.ProcessAutomationBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsTitle, Page.PricingAndServices.DashboardsTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsOnPremiseBodyText, Page.PricingAndServices.DashboardsOnPremiseBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsSaasBodyText, Page.PricingAndServices.DashboardsSaasBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.DashboardsDisclaimerBodyText, Page.PricingAndServices.DashboardsDisclaimerBodyText.GetInnertext());

            //Validate right subsection
            Assert.AreEqual(PricingAndServicesPageTestData.TrainingTitle, Page.PricingAndServices.TrainingTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TrainingBodyText, Page.PricingAndServices.TrainingBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.CoachingTitle, Page.PricingAndServices.CoachingTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.CoachingBodyText, Page.PricingAndServices.CoachingBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.RoadmapsTitle, Page.PricingAndServices.RoadmapsTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.RoadmapsBodyText, Page.PricingAndServices.RoadmapsBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TrustedAdvisorTitle, Page.PricingAndServices.TrustedAdvisorTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TrustedAdvisorBodyText, Page.PricingAndServices.TrustedAdvisorBodyText.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TechnicalCoFounderTitle, Page.PricingAndServices.TechnicalCoFounderTitle.GetInnertext());
            Assert.AreEqual(PricingAndServicesPageTestData.TechnicalCoFounderBodyText, Page.PricingAndServices.TechnicalCoFounderBodyText.GetInnertext());
        }
    }
}
