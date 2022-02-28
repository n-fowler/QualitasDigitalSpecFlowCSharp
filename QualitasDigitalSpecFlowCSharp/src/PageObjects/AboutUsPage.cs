using OpenQA.Selenium;
using QualitasDigitalSpecFlowCSharp.src.LocalConfiguration;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSpecFlowCSharp.PageObjects
{
    /// <summary>
    /// The AboutUs Page Object
    /// </summary>
    public class AboutUsPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The AboutUs Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/about-us";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// The About Us Header section
        /// </summary>
        public IWebElement HeaderSection => driver.FindElementById("block-8d07de855042f0a5360c");

        /// <summary>
        /// The About Us Header Title element
        /// </summary>
        public IWebElement HeaderTitle => driver.FindElementByXPath("//*[@id='block-8d07de855042f0a5360c']/div/h1");

        /// <summary>
        /// The About Us SubSection Title element
        /// </summary>
        public IWebElement Title => driver.FindElementByXPath("//*[@id='block-54dfc3255ea4a1352072']/div/h2");

        /// <summary>
        /// The About Us Sidebar element
        /// </summary>
        public List<IWebElement> Sidebar => driver.FindElementsByXPath("//*[@id='block-54dfc3255ea4a1352072']/div/p").ToList();

        /// <summary>
        /// The About Us Body element
        /// </summary>
        public IWebElement BodyText => Sidebar[0];

        /// <summary>
        /// The SideBar Links element
        /// </summary>
        public List<IWebElement> SidebarLinks => Sidebar[1].FindElementsByTagName("a").ToList();

        /// <summary>
        /// The About Us Our Services Link element
        /// </summary>
        public IWebElement OurServicesLink => SidebarLinks[0];

        /// <summary>
        /// The About Us Schedule Consultation Link element
        /// </summary>
        public IWebElement ScheduleConsultationLink => SidebarLinks[1];

        /// <summary>
        /// The About Us Image Subsection
        /// </summary>
        public IWebElement AboutUsImageSection => driver.FindElementById("block-5347679b4da120838be3");

        /// <summary>
        /// The About Us Image element
        /// </summary>
        public IWebElement Image => AboutUsImageSection.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "67")
            .First().FindElementByTagName("img");

        #endregion Elements
    }
}
