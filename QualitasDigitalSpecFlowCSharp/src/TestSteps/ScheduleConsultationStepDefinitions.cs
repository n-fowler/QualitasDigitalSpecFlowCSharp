using NUnit.Framework;
using QualitasDigitalSpecFlowCSharp.PageObjects;
using QualitasDigitalSpecFlowCSharp.src.TestData;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using TechTalk.SpecFlow;

namespace QualitasDigitalSpecFlowCSharp.src.TestSteps
{
    [Binding]
    public class ScheduleConsultationStepDefinitions
    {
        [Given(@"\[The Schedule Consultation Page is being visited]")]
        public void GivenTheScheduleConsultationPageIsBeingVisited()
        {
            BrowserFactory.GoToPage(ScheduleConsultationPage.Url);
        }

        [When(@"\[The Schedule Consultation Page is visited]")]
        public void WhenTheScheduleConsultationPageIsVisited()
        {
            BrowserFactory.WaitForPageLoad(10);
        }

        [Then(@"\[The Schedule Consultation Logo is present]")]
        public void ThenTheScheduleConsultationLogoIsPresent()
        {
            Assert.IsTrue(Page.ScheduleConsultation.LogoImage.Displayed, "Page.ScheduleConsultation.LogoImage.Displayed");
        }

        [Then(@"\[The Schedule Consultation Content is present]")]
        public void ThenTheScheduleConsultationContentIsPresent()
        {
            //Validate Title
            Assert.AreEqual(ScheduleConsultationPageData.HeaderContent, Page.ScheduleConsultation.HeaderContent.GetInnertext());

            //Validate left section
            Assert.AreEqual(ScheduleConsultationPageData.LeftContent, Page.ScheduleConsultation.LeftContent.GetInnertext());
            Assert.AreEqual(ScheduleConsultationPageData.OurCommitmentLink, Page.ScheduleConsultation.OurCommitmentLink.GetHref());
            Assert.AreEqual(ScheduleConsultationPageData.FaqLink, Page.ScheduleConsultation.FaqLink.GetHref());
            Assert.AreEqual(ScheduleConsultationPageData.TermsAndConditionsLink, Page.ScheduleConsultation.TermsAndConditionsLink.GetHref());

            //Validate right section
            Assert.AreEqual(ScheduleConsultationPageData.ScheduleConsultationButtonLink, Page.ScheduleConsultation.ScheduleConsultationButtonLink.GetHref());
        }
    }
}
