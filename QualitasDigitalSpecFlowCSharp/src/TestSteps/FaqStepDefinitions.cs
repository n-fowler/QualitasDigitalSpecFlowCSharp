using NUnit.Framework;
using QualitasDigitalSpecFlowCSharp.PageObjects;
using QualitasDigitalSpecFlowCSharp.src.TestData;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using TechTalk.SpecFlow;
using System.Collections.Generic;

namespace QualitasDigitalSpecFlowCSharp.src.TestSteps
{
    [Binding]
    public class FaqStepDefinitions
    {
        [Given(@"\[The Faq Page is being visited]")]
        public void GivenTheFaqPageIsBeingVisited()
        {
            BrowserFactory.GoToPage(FaqPage.Url);
        }

        [When(@"\[The Faq Page is visited]")]
        public void WhenTheFaqPageIsVisited()
        {
            BrowserFactory.WaitForPageLoad(10);
        }

        [Then(@"\[The Faq Logo is present]")]
        public void ThenTheFaqLogoIsPresent()
        {
            Assert.IsTrue(Page.Faq.LogoImage.Displayed, "Page.Faq.LogoImage.Displayed");
        }

        [Then(@"\[The Faq Content is present]")]
        public void ThenTheFaqContentIsPresent()
        {
            //Validate header
            Assert.AreEqual(FaqPageTestData.FaqTitle, Page.Faq.HeaderContent.GetInnertext());

            //Validate left subsection
            Assert.AreEqual(FaqPageTestData.FaqSubtitle, Page.Faq.SidebarContent.GetInnertext());
            Assert.AreEqual(FaqPageTestData.ContactUsLink, Page.Faq.ContactUsLink.GetHref());

            //Validate middle subsection
            var faqPageExpectedTitles = new List<string>
            {
                FaqPageTestData.TitleOne,
                FaqPageTestData.TitleTwo,
                FaqPageTestData.TitleThree,
                FaqPageTestData.TitleFour,
                FaqPageTestData.TitleFive,
                FaqPageTestData.TitleSix,
                FaqPageTestData.TitleSeven,
                FaqPageTestData.TitleEight,
                FaqPageTestData.TitleNine,
                FaqPageTestData.TitleTen,
                FaqPageTestData.TitleEleven,
                FaqPageTestData.TitleTwelve,
                FaqPageTestData.TitleThirteen,
                FaqPageTestData.TitleFourteen,
                FaqPageTestData.TitleFifteen
            };

            var faqPageExpectedBodies = new List<string>
            {
                FaqPageTestData.BodyOne,
                FaqPageTestData.BodyTwo,
                FaqPageTestData.BodyThree,
                FaqPageTestData.BodyFour,
                FaqPageTestData.BodyFive,
                FaqPageTestData.BodySix,
                FaqPageTestData.BodySeven,
                FaqPageTestData.BodyEight,
                FaqPageTestData.BodyNine,
                FaqPageTestData.BodyTen,
                FaqPageTestData.BodyEleven,
                FaqPageTestData.BodyTwelve,
                FaqPageTestData.BodyThirteen,
                FaqPageTestData.BodyFourteen,
                FaqPageTestData.BodyFifteen,
                string.Empty //Section has one empty body
            };

            var faqPageActualTitles = FaqPage.GetFaqPageTitles();
            var faqPageActualBodies = FaqPage.GetFaqPageBodies();

            CollectionAssert.AreEqual(faqPageExpectedTitles, faqPageActualTitles);
            CollectionAssert.AreEqual(faqPageExpectedBodies, faqPageActualBodies);
        }
    }
}
