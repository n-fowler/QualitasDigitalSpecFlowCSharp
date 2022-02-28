using OpenQA.Selenium;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using QualitasDigitalSpecFlowCSharp.src.Extensions;
using System.Linq;

namespace QualitasDigitalSpecFlowCSharp.PageObjects
{
    /// <summary>
    /// The PricingAndServices Page Object
    /// </summary>
    public class PricingAndServicesPage
    {
        private IWebDriver driver = BrowserFactory.Driver;

        /// <summary>
        /// The Pricing and Services Url
        /// </summary>
        public const string Url = "https://www.qualitasdigital.com/pricing-services";

        #region Elements

        /// <summary>
        /// The Logo Image element
        /// </summary>
        public IWebElement LogoImage => driver.FindElementByClassName("logo-image");

        /// <summary>
        /// The Header Title element
        /// </summary>
        public IWebElement HeaderTitle => driver.FindElementByXPath("//*[@id='block-19f417ec60a63ba7c692']/div/h1");

        /// <summary>
        /// The Left Subtitle element
        /// </summary>
        public IWebElement Subtitle => driver.FindElementByXPath("//*[@id='block-82a19843bee36801ceff']/div/h2");

        /// <summary>
        /// The Our Commitment Link element
        /// </summary>
        public IWebElement OurCommitmentLink => driver.FindElementByXPath("//*[@id='block-82a19843bee36801ceff']/div/p/a");

        /// <summary>
        /// The Additional Test Coverage Title element
        /// </summary>
        public IWebElement AdditionalTestCoverageTitle => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/h2[1]");

        /// <summary>
        /// The Additional Test Coverage Body Text element
        /// </summary>
        public IWebElement AdditionalTestCoverageBodyText => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/p[1]");

        /// <summary>
        /// The Framework Updates Title element
        /// </summary>
        public IWebElement FrameworkUpdatesTitle => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/h2[2]");

        /// <summary>
        /// The Framework Updates Upgrades Body Text element
        /// </summary>
        public IWebElement FrameworkUpdatesUpgradesBodyText => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/p[2]");

        /// <summary>
        /// The Framework Updates Custom Tailored Body Text element
        /// </summary>
        public IWebElement FrameworkUpdatesCustomTailoredBodyText => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/p[3]");

        /// <summary>
        /// The Process Automation Title element
        /// </summary>
        public IWebElement ProcessAutomationTitle => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/h2[3]");

        /// <summary>
        /// The Process Automation Body Text element
        /// </summary>
        public IWebElement ProcessAutomationBodyText => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/p[4]");

        /// <summary>
        /// The Dashboards Title element
        /// </summary>
        public IWebElement DashboardsTitle => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/h2[4]");

        /// <summary>
        /// The Dashboards On Premise Body Text element
        /// </summary>
        public IWebElement DashboardsOnPremiseBodyText => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/p[5]");

        /// <summary>
        /// The Dashboards Saas Body Text element
        /// </summary>
        public IWebElement DashboardsSaasBodyText => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/p[6]");

        /// <summary>
        /// The Dashboards Disclaimer Body Text element
        /// </summary>
        public IWebElement DashboardsDisclaimerBodyText => driver.FindElementByXPath("//*[@id='block-54c775ec01e945af9697']/div/p[7]");

        /// <summary>
        /// The Training Title element
        /// </summary>
        public IWebElement TrainingTitle => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/h2[1]");

        /// <summary>
        /// The Training Body Text element
        /// </summary>
        public IWebElement TrainingBodyText => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/p[1]");

        /// <summary>
        /// The Coaching Title element
        /// </summary>
        public IWebElement CoachingTitle => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/h2[2]");

        /// <summary>
        /// The Coaching Body Text element
        /// </summary>
        public IWebElement CoachingBodyText => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/p[2]");

        /// <summary>
        /// The Roadmaps Title element
        /// </summary>
        public IWebElement RoadmapsTitle => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/h2[3]");

        /// <summary>
        /// The Roadmaps Body Text element
        /// </summary>
        public IWebElement RoadmapsBodyText => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/p[3]");

        /// <summary>
        /// The Trusted Advisor Title element
        /// </summary>
        public IWebElement TrustedAdvisorTitle => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/h2[4]");

        /// <summary>
        /// The Trusted Advisor Body Text element
        /// </summary>
        public IWebElement TrustedAdvisorBodyText => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/p[4]");

        /// <summary>
        /// The Technical CoFounder title element
        /// </summary>
        public IWebElement TechnicalCoFounderTitle => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/h2[5]");

        /// <summary>
        /// The Technical CoFounder Body Text element
        /// </summary>
        public IWebElement TechnicalCoFounderBodyText => driver.FindElementByXPath("//*[@id='block-beb271dbce1faba38f10']/div/p[5]");

        #endregion Elements
    }
}
