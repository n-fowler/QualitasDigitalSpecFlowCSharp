using OpenQA.Selenium;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using System.Collections.Generic;

namespace QualitasDigitalSpecFlowCSharp.PageObjects
{
    /// <summary>
    /// The NewsAndNotes Page Object
    /// </summary>
    public class NewsAndNotesPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The Pricing and Services Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/news-notes-qualitas";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// The article entry element
        /// </summary>
        public IReadOnlyCollection<IWebElement> Entries => driver.FindElementsByClassName("entry");

        #endregion Elements
    }
}
