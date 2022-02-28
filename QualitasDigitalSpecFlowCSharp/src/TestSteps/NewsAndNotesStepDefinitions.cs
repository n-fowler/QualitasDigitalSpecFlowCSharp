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
    public class NewsAndNotesStepDefinitions
    {
        [Given(@"\[The News and Notes Page is being visited]")]
        public void GivenTheNewsAndNotesPageIsBeingVisited()
        {
            BrowserFactory.GoToPage(NewsAndNotesPage.Url);
        }

        [When(@"\[The News and Notes Page is visited]")]
        public void WhenTheNewsAndNotesPageIsVisited()
        {
            BrowserFactory.WaitForPageLoad(10);
        }

        [Then(@"\[The News and Notes Logo is present]")]
        public void ThenTheNewsAndNotesLogoIsPresent()
        {
            Assert.IsTrue(Page.NewsAndNotes.LogoImage.Displayed, "Page.NewsAndNotes.LogoImage.Displayed");
        }

        [Then(@"\[The News and Notes Content is present]")]
        public void ThenTheNewsAndNotesContentIsPresent()
        {
            /* The content here will change often over time so verify that an article is showing and that it can be opened. */

            //There should be at least one article
            Assert.IsTrue(Page.NewsAndNotes.Entries.Count >= 1, "Page.NewsAndNotes.Entries.Count >= 1");

            //It should have a date
            Assert.IsNotNull(Page.NewsAndNotes.Entries.First().FindElementByClassName("date-wrapper"),
                "Page.NewsAndNotes.Entries.First().FindElementByClassName('date-wrapper') != null");

            //It should have clickable title
            var entryLink = Page.NewsAndNotes.Entries.First().FindElementByClassName("entry-title").FindElementByTagName("a");
            Assert.IsNotNull(entryLink, "entryLink != null");
            Assert.AreNotEqual("", entryLink.GetHref(), "The entry article link was empty but shouldn't have been");
            Assert.AreNotEqual("", entryLink.GetInnertext(), "The entry article text was empty but shouldn't have been");

            //It should have a clickable category
            var entryCategory = Page.NewsAndNotes.Entries.First().FindElementByClassName("blog-categories").FindElementByTagName("a");
            Assert.IsNotNull(entryCategory, "entryCategory != null");
            Assert.AreNotEqual("", entryCategory.GetHref(), "The entry category link was empty but shouldn't have been");
            Assert.AreNotEqual("", entryCategory.GetInnertext(), "The entry category text was empty but shouldn't have been");

            //It should have a summary body
            var entryExcerpt = Page.NewsAndNotes.Entries.First().FindElementByClassName("entry-excerpt").FindElementByTagName("p");
            Assert.IsNotNull(entryExcerpt, "entryExcerpt != null");
            Assert.AreNotEqual("", entryExcerpt.GetInnertext(), "The entry excerpt text was empty but shouldn't have been");
        }
    }
}
