using OpenQA.Selenium;
using QualitasDigitalSpecFlowCSharp.src.LocalConfiguration;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using System.Linq;

namespace QualitasDigitalSpecFlowCSharp.PageObjects
{
    /// <summary>
    /// The ScheduleConsultation Page Object
    /// </summary>
    public class ScheduleConsultationPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The Pricing and Services Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/schedule-consultation";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// Header Content element
        /// </summary>
        public IWebElement HeaderContent => driver.FindElementByXPath("//*[@id='block-540803d1406a17b6338b']/div/h1");

        /// <summary>
        /// Left Content element
        /// </summary>
        public IWebElement LeftContent => driver.FindElementByXPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/h2/em");

        /// <summary>
        /// Our Commitment Link element
        /// </summary>
        public IWebElement OurCommitmentLink => driver.FindElementByXPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/p/a[1]");

        /// <summary>
        /// Faq Link element
        /// </summary>
        public IWebElement FaqLink => driver.FindElementByXPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/p/a[2]");

        /// <summary>
        /// Terms And Conditions Link element
        /// </summary>
        public IWebElement TermsAndConditionsLink => driver.FindElementByXPath("//*[@id='block-6bcc55f9ff3b7b21fdea']/div/p/a[3]");

        /// <summary>
        /// Schedule Consultation Button element
        /// </summary>
        public IWebElement ScheduleConsultationButton => driver.GetElementsWithTagAndAttributeStartAndEndingWithValues("div", "id", Configuration.SitePrefix, "76").First();

        /// <summary>
        /// Schedule Consultation Button Link element
        /// </summary>
        public IWebElement ScheduleConsultationButtonLink => ScheduleConsultationButton.FindElementByTagName("a");

        #endregion Elements
    }
}
