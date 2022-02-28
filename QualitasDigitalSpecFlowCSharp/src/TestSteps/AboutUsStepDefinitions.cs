using NUnit.Framework;
using QualitasDigitalSpecFlowCSharp.PageObjects;
using QualitasDigitalSpecFlowCSharp.src.TestData;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using TechTalk.SpecFlow;

namespace QualitasDigitalSpecFlowCSharp.src.TestSteps
{
    [Binding]
    public sealed class AboutUsStepDefinitions
    {
        [Given(@"\[The About Us Page is being visited]")]
        public void GivenTheAboutUsPageIsBeingVisited()
        {
            BrowserFactory.GoToPage(AboutUsPage.Url);
        }

        [When(@"\[The About Us Page is visited]")]
        public void WhenTheAboutUsPageIsVisited()
        {
            BrowserFactory.WaitForPageLoad(10);
        }

        [Then(@"\[The About Us Logo is present]")]
        public void ThenTheAboutUsLogoIsPresent()
        {
            Assert.IsTrue(Page.AboutUs.LogoImage.Displayed, "Page.AboutUs.LogoImage.Displayed");
        }

        [Then(@"\[The About Us Content is present]")]
        public void ThenTheAboutUsContentIsPresent()
        {
            //Validate About Us Section
            Assert.AreEqual(AboutUsPageTestData.HeaderTitle, Page.AboutUs.HeaderTitle.GetInnertext());
            Assert.AreEqual(AboutUsPageTestData.AboutUsTitle, Page.AboutUs.Title.GetInnertext());
            StringAssert.Contains(AboutUsPageTestData.AboutUsImageSrc, Page.AboutUs.Image.GetSrc());
            Assert.AreEqual(AboutUsPageTestData.AboutUsBodyText, Page.AboutUs.BodyText.GetInnertext());
            Assert.AreEqual(AboutUsPageTestData.OurServicesLink, Page.AboutUs.OurServicesLink.GetHref());
            Assert.AreEqual(AboutUsPageTestData.ScheduleConsultationLink, Page.AboutUs.ScheduleConsultationLink.GetHref());
        }
    }
}
