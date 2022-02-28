using NUnit.Framework;
using QualitasDigitalSpecFlowCSharp.PageObjects;
using QualitasDigitalSpecFlowCSharp.src.TestData;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSpecFlowCSharp.src.TestSteps
{
    [Binding]
    public class ContactUsStepDefinitions
    {
        [Given(@"\[The Contact Us Page is being visited]")]
        public void GivenTheContactUsPageIsBeingVisited()
        {
            BrowserFactory.GoToPage(ContactUsPage.Url);
        }

        [When(@"\[The Contact Us Page is visited]")]
        public void WhenTheContactUsPageIsVisited()
        {
            BrowserFactory.WaitForPageLoad(10);
        }

        [Then(@"\[The Contact Us Logo is present]")]
        public void ThenTheContactUsLogoIsPresent()
        {
            Assert.IsTrue(Page.ContactUs.LogoImage.Displayed, "Page.ContactUs.LogoImage.Displayed");
        }

        [Then(@"\[The Contact Us Content is present]")]
        public void ThenTheContactUsContentIsPresent()
        {
            //Validate Title
            Assert.AreEqual(ContactUsPageData.HeaderContent, Page.ContactUs.HeaderContent.GetInnertext());

            //Validate left section
            Assert.AreEqual(ContactUsPageData.LeftContent, Page.ContactUs.SidebarContent.GetInnertext());
            Assert.AreEqual(ContactUsPageData.OurCommitmentLink, Page.ContactUs.OurCommitmentLink.GetHref());
            Assert.AreEqual(ContactUsPageData.FaqLink, Page.ContactUs.FaqLink.GetHref());
            Assert.AreEqual(ContactUsPageData.TermsAndConditionsLink, Page.ContactUs.TermsAndConditionsLink.GetHref());

            //Validate right section

            //There should be a first name field
            Assert.NotNull(Page.ContactUs.FirstNameField, "Page.ContactUs.FirstNameField != null");

            //There should be a last name field
            Assert.NotNull(Page.ContactUs.LastNameField, "Page.ContactUs.LastNameField != null");

            //There should be an email field
            Assert.NotNull(Page.ContactUs.EmailField, "Page.ContactUs.EmailField != null");

            /*There should be a series of checkboxes with the following organization: 
                Additional Test Coverage
                Framework Updates
                Process Automation
                Dashboards
                Training
                Coaching
                Road maps
                Trusted Advisor
                Technical Co-Founder
                Other* (Include additional detail below)
            */

            var options = Page.ContactUs.CheckboxSection.FindElementsByTagName("div").ToList();
            var expectedOptions = new List<string>
            {
                "Additional Test Coverage",
                "Framework Updates",
                "Process Automation",
                "Dashboards",
                "Training",
                "Coaching",
                "Road maps",
                "Trusted Advisor",
                "Technical Co-Founder",
                "Other* (Include additional detail below)"
            };

            for (int i = 0; i < options.Count; i++)
            {
                //Verify the checkbox
                Assert.AreEqual("checkbox", options[i].FindElementByTagName("label").FindElementByTagName("input").GetDomProperty("type"));
                Assert.AreEqual(expectedOptions[i], options[i].FindElementByTagName("label").FindElementByTagName("input").GetDomProperty("value"));
            }

            //There should be an additional message field
            Assert.NotNull(Page.ContactUs.AdditionalMessageTextArea, "Page.ContactUs.AdditionalMessageTextArea != null");

            //There should be a submit button
            Assert.NotNull(Page.ContactUs.SubmitButton, "Page.ContactUs.SubmitButton != null");
            Assert.AreEqual("submit", Page.ContactUs.SubmitButton.GetDomProperty("type"));
            Assert.AreEqual("Submit", Page.ContactUs.SubmitButton.GetDomProperty("value"));
        }
    }
}
