using OpenQA.Selenium;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSpecFlowCSharp.PageObjects
{
    /// <summary>
    /// The Faq Page Object
    /// </summary>
    public class FaqPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// Faq Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/faq";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// The Header Title element
        /// </summary>
        public IWebElement HeaderContent => driver.FindElementByXPath("//*[@id='block-0872d1f64aa73dc210a0']/div/h1");

        /// <summary>
        /// The Sidebar Content element
        /// </summary>
        public IWebElement SidebarContent => driver.FindElementByXPath("//*[@id='block-5a5c2d60498a7ac2f90c']/div/h2");

        /// <summary>
        /// The Sidebar Links Element
        /// </summary>
        public List<IWebElement> SidebarLinks => driver.FindElementsByXPath("//*[@id='block-5a5c2d60498a7ac2f90c']/div/p/a").ToList();

        /// <summary>
        /// The Our Commitment Link element
        /// </summary>
        public IWebElement ContactUsLink => SidebarLinks[0];

        /// <summary>
        /// The Center Section element
        /// </summary>
        public IWebElement CenterSection => driver.FindElementById("block-07ad9bb3be93b9c67b17");

        /// <summary>
        /// The left title elements
        /// </summary>
        public List<IWebElement> LeftTitles => driver.FindElementsByXPath("//*[@id='block-07ad9bb3be93b9c67b17']/div/h3").ToList();

        /// <summary>
        /// The left body elements
        /// </summary>
        public List<IWebElement> LeftBodies => driver.FindElementsByXPath("//*[@id='block-07ad9bb3be93b9c67b17']/div/p").ToList();

        /// <summary>
        /// The right title elements
        /// </summary>
        public List<IWebElement> RightTitles => driver.FindElementsByXPath("//*[@id='block-156845d943225c44b8dd']/div/h3").ToList();

        /// <summary>
        /// The right body elements
        /// </summary>
        public List<IWebElement> RightBodies => driver.FindElementsByXPath("//*[@id='block-156845d943225c44b8dd']/div/p").ToList();

        #endregion Elements

        #region Methods

        /// <summary>
        /// Get a collection of Faq Page Titles
        /// </summary>
        /// <returns></returns>
        public static List<string> GetFaqPageTitles()
        {
            var faqPageActualTitles = new List<string>();
            
            foreach (var title in Page.Faq.LeftTitles)
            {
                faqPageActualTitles.Add(title.GetInnertext());
            }

            foreach (var title in Page.Faq.RightTitles)
            {
                faqPageActualTitles.Add(title.GetInnertext());
            }
            
            return faqPageActualTitles;
        }

        /// <summary>
        /// Get a collection of Faq Page Bodies
        /// </summary>
        /// <returns></returns>
        public static List<string> GetFaqPageBodies()
        {
            var faqPageActualBodies = new List<string>();
            
            foreach (var body in Page.Faq.LeftBodies)
            {
                faqPageActualBodies.Add(body.GetInnertext());
            }

            foreach (var body in Page.Faq.RightBodies)
            {
                faqPageActualBodies.Add(body.GetInnertext());
            }

            return faqPageActualBodies;
        }

        #endregion Methods
    }
}
