using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using QualitasDigitalSpecFlowCSharp.Extensions;
using QualitasDigitalSpecFlowCSharp.WrapperFactory;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QualitasDigitalSpecFlowCSharp.src.Extensions
{
    /// <summary>
    /// Extends the functionality of the driver and web element classes
    /// </summary>
    public static class SeleniumExtensions
    {
        #region Find Element (IWebDriver)

        /// <summary>
        /// Uses the driver to find an element by class name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByClassName(this IWebDriver driver, string className)
        {
            try
            {
                var element = driver.FindElement(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by css selector string
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByCssSelector(this IWebDriver driver, string cssSelector)
        {
            try
            {
                var element = driver.FindElement(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector.Replace("'", "")}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector.Replace("'", "")}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by id
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementById(this IWebDriver driver, string id)
        {
            try
            {
                var element = driver.FindElement(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByLinkText(this IWebDriver driver, string linkText)
        {
            try
            {
                var element = driver.FindElement(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByName(this IWebDriver driver, string name)
        {
            try
            {
                var element = driver.FindElement(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element containing the link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByPartialLinkText(this IWebDriver driver, string partialLinkText)
        {
            try
            {
                var element = driver.FindElement(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by tag name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByTagName(this IWebDriver driver, string tagName)
        {
            try
            {
                var element = driver.FindElement(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by xpath
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByXPath(this IWebDriver driver, string xPath)
        {
            try
            {
                var element = driver.FindElement(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Element (IWebDriver)

        #region Find Element (IWebElement)

        /// <summary>
        /// Uses the driver to find an element by class name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByClassName(this IWebElement webElement, string className)
        {
            try
            {
                var element = webElement.FindElement(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by css selector string
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByCssSelector(this IWebElement webElement, string cssSelector)
        {
            try
            {
                var element = webElement.FindElement(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector.Replace("'", "")}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Css Selector: {cssSelector.Replace("'", "")}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by id
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementById(this IWebElement webElement, string id)
        {
            try
            {
                var element = webElement.FindElement(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByLinkText(this IWebElement webElement, string linkText)
        {
            try
            {
                var element = webElement.FindElement(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByName(this IWebElement webElement, string name)
        {
            try
            {
                var element = webElement.FindElement(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element containing the link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByPartialLinkText(this IWebElement webElement, string partialLinkText)
        {
            try
            {
                var element = webElement.FindElement(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by tag name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByTagName(this IWebElement webElement, string tagName)
        {
            try
            {
                var element = webElement.FindElement(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find an element by xpath
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a selenium web element</returns>
        public static IWebElement FindElementByXPath(this IWebElement webElement, string xPath)
        {
            try
            {
                var element = webElement.FindElement(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", "Element Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return element;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Element By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Element (IWebDriver)

        #region Find Elements (IWebDriver)

        /// <summary>
        /// Uses the driver to find elements by the class name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByClassName(this IWebDriver driver, string className)
        {
            try
            {
                var elements = driver.FindElements(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the css selector string
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByCssSelector(this IWebDriver driver, string cssSelector)
        {
            try
            {
                var elements = driver.FindElements(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector.Replace("'", "")}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector.Replace("'", "")}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the id
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsById(this IWebDriver driver, string id)
        {
            try
            {
                var elements = driver.FindElements(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByLinkText(this IWebDriver driver, string linkText)
        {
            try
            {
                var elements = driver.FindElements(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByName(this IWebDriver driver, string name)
        {
            try
            {
                var elements = driver.FindElements(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements containing the link text
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByPartialLinkText(this IWebDriver driver, string partialLinkText)
        {
            try
            {
                var elements = driver.FindElements(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the tag name
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByTagName(this IWebDriver driver, string tagName)
        {
            try
            {
                var elements = driver.FindElements(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the xpath
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByXPath(this IWebDriver driver, string xPath)
        {
            try
            {
                var elements = driver.FindElements(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Elements (IWebDriver)

        #region Find Elements (IWebElement)

        /// <summary>
        /// Uses the driver to find elements by the class name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="className">The class name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByClassName(this IWebElement webElement, string className)
        {
            try
            {
                var elements = webElement.FindElements(By.ClassName(className));
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Class Name: {className}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the css selector string
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByCssSelector(this IWebElement webElement, string cssSelector)
        {
            try
            {
                var elements = webElement.FindElements(By.CssSelector(cssSelector));
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector.Replace("'", "")}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Css Selector: {cssSelector.Replace("'", "")}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the id
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="id">The id</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsById(this IWebElement webElement, string id)
        {
            try
            {
                var elements = webElement.FindElements(By.Id(id));
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Id: {id}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="linkText">The link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByLinkText(this IWebElement webElement, string linkText)
        {
            try
            {
                var elements = webElement.FindElements(By.LinkText(linkText));
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Link Text: {linkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="name">The name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByName(this IWebElement webElement, string name)
        {
            try
            {
                var elements = webElement.FindElements(By.Name(name));
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Name: {name}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements containing the link text
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="partialLinkText">The partial link text</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByPartialLinkText(this IWebElement webElement, string partialLinkText)
        {
            try
            {
                var elements = webElement.FindElements(By.PartialLinkText(partialLinkText));
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Partial Link Text: {partialLinkText}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the tag name
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tagName">The tag name</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByTagName(this IWebElement webElement, string tagName)
        {
            try
            {
                var elements = webElement.FindElements(By.TagName(tagName));
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By Tag Name: {tagName}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Uses the driver to find elements by the xpath
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="xPath">The xpath</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByXPath(this IWebElement webElement, string xPath)
        {
            try
            {
                var elements = webElement.FindElements(By.XPath(xPath));
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", "Elements Found", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Find Elements By XPath: {xPath}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Find Elements (IWebElement)

        #region Basic Element Operations (IWebElement)

        /// <summary>
        /// Clicks the web element.
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ClickWhenReady(this IWebElement element)
        {
            try
            {
                element.Click();
                TestStepLog.GenerateTestStep("Click When Ready", "Element was Clicked", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Click When Ready", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Enters text into supported elements
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="value">The value</param>
        public static void EnterText(this IWebElement element, string value)
        {
            try
            {
                element.SendKeys(value);
                TestStepLog.GenerateTestStep($"Enter Text: {value}", "Text was entered", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Enter Text: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Clears the content of the element
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ClearElement(this IWebElement element)
        {
            try
            {
                element.Clear();
                TestStepLog.GenerateTestStep("Clear Element", "Element was cleared", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Clear Element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Performs a submit operation for the element
        /// </summary>
        /// <param name="element">The web element</param>
        public static void SubmitElement(this IWebElement element)
        {
            try
            {
                element.Submit();
                TestStepLog.GenerateTestStep("Submit Element", "Element was submitted", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Submit Element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the innertext of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a string with innertext</returns>
        public static string GetInnertext(this IWebElement element)
        {
            try
            {
                var returnVal = element.GetAttribute("innerText");
                TestStepLog.GenerateTestStep("Get Innertext from the element", "Element Innertext retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Innertext from the element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the href of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns></returns>
        public static string GetHref(this IWebElement element)
        {
            try
            {
                var returnVal = element.GetAttribute("href");
                TestStepLog.GenerateTestStep("Get Href from the element", "Element Href retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Href from the element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the src of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns></returns>
        public static string GetSrc(this IWebElement element)
        {
            try
            {
                var returnVal = element.GetAttribute("src");
                TestStepLog.GenerateTestStep("Get Src from the element", "Element Src retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Src from the element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the enabled state of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a boolean for enabled state</returns>
        public static bool IsEnabled(this IWebElement element)
        {
            try
            {
                var returnVal = element.Enabled;
                TestStepLog.GenerateTestStep("Determine element enabled state", "Element enabled state retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Determine element enabled state", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the displayed state of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a boolean for displayed state</returns>
        public static bool IsDisplayed(this IWebElement element)
        {
            try
            {
                var returnVal = element.Displayed;
                TestStepLog.GenerateTestStep("Determine element displayed state", "Element displayed state retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Determine element displayed state", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the selected state of the element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a boolean for selected state</returns>
        public static bool IsSelected(this IWebElement element)
        {
            try
            {
                var returnVal = element.Selected;
                TestStepLog.GenerateTestStep("Determine element selected state", "Element selected state retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Determine element selected state", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Selects an option from a Select Element by index
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="index">The index</param>
        public static void SelectByIndex(this IWebElement element, int index)
        {
            try
            {
                new SelectElement(element).SelectByIndex(index);
                TestStepLog.GenerateTestStep($"Select By Index: {index}", "Element selected by Index", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Select By Index: {index}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deselects an option from a Select Element by index
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="index">The index</param>
        public static void DeselectByIndex(this IWebElement element, int index)
        {
            try
            {
                new SelectElement(element).DeselectByIndex(index);
                TestStepLog.GenerateTestStep($"Deselect By Index: {index}", "Element deselected by Index", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Deselect By Index: {index}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Selects an option from a Select Element by text
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="text">The option text value</param>
        public static void SelectByText(this IWebElement element, string text)
        {
            try
            {
                new SelectElement(element).SelectByText(text);
                TestStepLog.GenerateTestStep($"Select By Text: {text}", "Element selected by Text", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Select By Text: {text}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deselects an option from a Select Element by text
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="text">The option text value</param>
        public static void DeselectByText(this IWebElement element, string text)
        {
            try
            {
                new SelectElement(element).DeselectByText(text);
                TestStepLog.GenerateTestStep($"Deselect By Text: {text}", "Element deselected by Text", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Deselect By Text: {text}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Selects an option from a Select Element by value
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="value">The value</param>
        public static void SelectByValue(this IWebElement element, string value)
        {
            try
            {
                new SelectElement(element).SelectByValue(value);
                TestStepLog.GenerateTestStep($"Select By Value: {value}", "Element selected by Value", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Select By Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deslects an option from a Select Element by value
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="value">The value</param>
        public static void DeselectByValue(this IWebElement element, string value)
        {
            try
            {
                new SelectElement(element).DeselectByValue(value);
                TestStepLog.GenerateTestStep($"Deselect By Value: {value}", "Element deselected by Value", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Deselect By Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Deselects all options from a Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        public static void DeselectAll(this IWebElement element)
        {
            try
            {
                new SelectElement(element).DeselectAll();
                TestStepLog.GenerateTestStep("Deselect all options from element", "Element deselected by Value", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Deselect all options from element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the currently selected option from a Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a Select web element</returns>
        public static IWebElement GetSelectedOption(this IWebElement element)
        {
            try
            {
                var returnVal = new SelectElement(element).SelectedOption;
                TestStepLog.GenerateTestStep("Get Selected Option", "Selected Option retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Selected Option", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all currently selected options from a Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a list of Select web elements</returns>
        public static IList<IWebElement> GetAllSelectedOptions(this IWebElement element)
        {
            try
            {
                var returnVal = new SelectElement(element).AllSelectedOptions;
                TestStepLog.GenerateTestStep("Get All Selected Options", "Selected Options retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get All Selected Options", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets the multiple select state of the Select Element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns>returns a bool for the multiple select state</returns>
        public static bool IsMultipleSelect(this IWebElement element)
        {
            try
            {
                var returnVal = new SelectElement(element).IsMultiple;
                TestStepLog.GenerateTestStep("Get Multiple Select state", "Multiple Select state retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return returnVal;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Multiple Select state", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion Basic Element Operations (IWebElement)

        #region Advanced Element Operations (IWebElement)

        /// <summary>
        /// Drags and Drops an element to a position on the screen
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="xPos">the x coordinate</param>
        /// <param name="yPos">the y coordinate</param>
        public static void DragAndDrop(this IWebElement element, int xPos, int yPos)
        {
            try
            {
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                Actions move = new Actions(driver);
                move.DragAndDropToOffset(element, xPos, yPos).Perform();
                TestStepLog.GenerateTestStep($"Drag and drop the element. xPos: {xPos}, yPos: {yPos}", "DragAndDrop completed.", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Drag and drop the element. xPos: {xPos}, yPos: {yPos}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Scrolls to a web element using javascript
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ScrollTo(this IWebElement element)
        {
            try
            {
                string js = $"window.scroll(0, {element.Location.Y});";
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                ((IJavaScriptExecutor)driver).ExecuteScript(js);
                TestStepLog.GenerateTestStep($"Scroll to the element at Y coordinate: {element.Location.Y}", "ScrollTo completed.", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Scroll to the element at Y coordinate: {element.Location.Y}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Clicks an element using javascript and the element id
        /// </summary>
        /// <param name="element">The web element</param>
        public static void ClickWithJavascriptById(this IWebElement element)
        {
            try
            {
                string js = $"document.getElementById('{element.GetAttribute("id")}').click();";
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                ((IJavaScriptExecutor)driver).ExecuteScript(js);
                TestStepLog.GenerateTestStep("Click Element With Javascript By Id", $"ClickWithJavascriptById executed.  Full script: {js}", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Click Element With Javascript By Id", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Wait for the visibility of an element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="cssSelector">The css selector string</param>
        /// <param name="timeLimit">the time limit in seconds</param>
        public static void WaitForVisibility(this IWebElement element, string cssSelector, int timeLimit = 30)
        {
            try
            {
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeLimit));
#pragma warning disable 618
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.CssSelector(cssSelector)));
#pragma warning restore 618
                TestStepLog.GenerateTestStep($"Wait For Visibility of element with css selector: {cssSelector.Replace("'", "")}", "WaitForVisibility completed", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Wait For Visibility of element with css selector: {cssSelector.Replace("'", "")}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Wait for the visibility of an element
        /// </summary>
        /// <param name="element">The web element</param>
        /// <param name="timeLimit">the time limit in seconds</param>
        public static void WaitForClickable(this IWebElement element, int timeLimit = 30)
        {
            try
            {
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeLimit));
#pragma warning disable 618
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
#pragma warning restore 618
                TestStepLog.GenerateTestStep("Wait For Clickability of element", "WaitForVisibility completed", "Success", BrowserFactory.Stopwatch.Elapsed);
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Wait For Clickability of element", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all Element properties, useful for logging
        /// </summary>
        /// <param name="element">The web element</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetAllElementProperties(this IWebElement element)
        {
            try
            {
                IWebDriver driver = ((IWrapsDriver)element).WrappedDriver;
                string js = "var items = {}; for (index = 0; index < arguments[0].attributes.length; ++index) { items[arguments[0].attributes[index].name] = arguments[0].attributes[index].value }; return items;";
                Dictionary<string, object> attributes = ((IJavaScriptExecutor)driver).ExecuteScript(js, element) as Dictionary<string, object>;
                TestStepLog.GenerateTestStep("Get All Element Properties", "GetAllElementProperties completed", "Success", BrowserFactory.Stopwatch.Elapsed);
                return attributes;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get All Element Properties", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets an element identifier for the test log test steps
        /// </summary>
        /// <param name="propertyDictionary">The property dictionary retrieved from GetAllElementProperties</param>
        /// <returns></returns>
        public static string GetElementIdentifierForTestLog(Dictionary<string, object> propertyDictionary)
        {
            if (propertyDictionary == null)
            {
                return "unknown value used.  Property dictionary is null";
            }
            if (propertyDictionary.ContainsKey("id"))
            {
                return $"id: {propertyDictionary["id"]}";
            }
            if (propertyDictionary.ContainsKey("class"))
            {
                return $"class: {propertyDictionary["class"]}";
            }
            if (propertyDictionary.ContainsKey("role"))
            {
                return $"role: {propertyDictionary["role"]}";
            }

            return $"unknown value: {propertyDictionary.First().Value as string}";
        }

        #endregion Advanced Element Operations (IWebElement)

        #region CSS Selectors (IWebDriver)

        /// <summary>
        /// Gets all elements by css selector
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetAllElements(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("*");
                TestStepLog.GenerateTestStep("Get All Elements", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get All Elements", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by hierarchy using a css selector.  EX: div, p | div p | div > p | div + p | p ~ ul
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="hierarchy">The hierarchy string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagHierarchy(this IWebDriver driver, string hierarchy)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector(hierarchy);
                TestStepLog.GenerateTestStep($"Get Elements By Tag Hierarchy: {hierarchy}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag Hierarchy: {hierarchy}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a target attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="attribute">the target attribute</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTargetAttribute(this IWebDriver driver, string attribute)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"[{attribute}]");
                TestStepLog.GenerateTestStep($"Get Elements With Target Attribute: {attribute}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Target Attribute: {attribute}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with the blank target attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithBlankTargetAttribute(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("[target = _blank]");
                TestStepLog.GenerateTestStep("Get Elements With Blank Target Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Blank Target Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an attribute containing a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeContainingValue(this IWebDriver driver, string attribute, string value)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"[{attribute}~={value}]");
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Containing Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Containing Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an attribute starting with a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeStartingWithValue(this IWebDriver driver, string attribute, string value)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"[{attribute}|={value}]");
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Starting With Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Starting With Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">the tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartingWithValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}[{attribute}^='{value}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With Value:{value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With Value:{value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute ending with a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeEndingWithValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}[{attribute}$='{value}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Ending With Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Ending With Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with one value and ending with a second value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="startsWith">The beginning of the value</param>
        /// <param name="endsWith">The end of the value</param>
        /// <returns></returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartAndEndingWithValues(this IWebDriver driver, string tag, string attribute, string startsWith, string endsWith)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}[{attribute}^='{startsWith}'][{attribute}$='{endsWith}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With: {startsWith} And Ending With: {endsWith}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With: {startsWith} And Ending With: {endsWith}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute containing a specified value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeContainingValue(this IWebDriver driver, string tag, string attribute, string value)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}[{attribute}*='{value}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Containing Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Containing Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that are active web links
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetActiveWebLinks(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("a:active");
                TestStepLog.GenerateTestStep("Get Active Web Links", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Active Web Links", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a checked state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithCheckedState(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:checked");
                TestStepLog.GenerateTestStep("Get Elements With Checked State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Checked State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a default state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDefaultState(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:default");
                TestStepLog.GenerateTestStep("Get Elements With Default State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Default State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a disabled state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDisabledState(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:disabled");
                TestStepLog.GenerateTestStep("Get Elements With Disabled State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Disabled State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have no children
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndNoChildren(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:empty");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And No Children", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And No Children", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an enabled state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithEnabledState(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:enabled");
                TestStepLog.GenerateTestStep("Get Elements With Enabled State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Enabled State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a first child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag"></param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstChild(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:first-child");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Child", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Child", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a first of type parent
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstTypeOfParent(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:first-of-type");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Type Of Parent", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Type Of Parent", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that are focused
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByFocus(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:focus");
                TestStepLog.GenerateTestStep("Get Elements By Focus", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements By Focus", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a value that's in range
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueInRange(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:in-range");
                TestStepLog.GenerateTestStep("Get Elements With Value In Range", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Value In Range", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an indeterminate state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithIndeterminateState(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:indeterminate");
                TestStepLog.GenerateTestStep("Get Elements With Indeterminate State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Indeterminate State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an invalid value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithInvalidValue(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:invalid");
                TestStepLog.GenerateTestStep("Get Elements With Invalid Value", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Invalid Value", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a last child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastChild(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:last-child");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Child", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Child", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a last of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastTypeOfParent(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:last-of-type");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Type Of Parent", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Type Of Parent", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that are links with an unvisited state
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetUnvisitedLinks(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("a:link");
                TestStepLog.GenerateTestStep("Get Unvisited Links", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Unvisited Links", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that lack a specific tag
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByNotTag(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($":not({tag})");
                TestStepLog.GenerateTestStep($"Get Elements By Not Tag: {tag}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Not Tag: {tag}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and child index
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndChildIndex(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:nth-child(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Child Index", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the reversed child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndReversedChildIndex(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:nth-last-child(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Reversed Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Reversed ChildIndex", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the child of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndChildIndex(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:nth-of-type(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Child Index", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the last child of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndReversedChildIndex(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:nth-last-of-type(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Reversed Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Reversed Child Index", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the only child of type
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndOnlyChildOfType(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:only-of-type");
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Only Child Of Type", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Only Child Of Type", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have an only child
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndOnlyChild(this IWebDriver driver, string tag)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector($"{tag}:only-child");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Only Child", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Only Child", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements without the required attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutRequiredAttribute(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:optional");
                TestStepLog.GenerateTestStep("Get Elements Without Required Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements Without Required Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have an out of range value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueOutOfRange(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:out-of-range");
                TestStepLog.GenerateTestStep("Get Elements With Value Out Of Range", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Value Out Of Range", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a placeholder value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithPlaceholderValue(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input::placeholder");
                TestStepLog.GenerateTestStep("Get Elements With Placeholder Value", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Placeholder Value", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have the read only attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithReadOnlyAttribute(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:read-only");
                TestStepLog.GenerateTestStep("Get Elements With Read Only Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Read Only Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements thatlack the read only attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutReadOnlyAttribute(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:read-write");
                TestStepLog.GenerateTestStep("Get Elements Without Read Only Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements Without Read Only Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with the required attribute
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithRequiredAttribute(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:required");
                TestStepLog.GenerateTestStep("Get Elements With Required Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Required Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements at the root
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementAtRoot(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector(":root");
                TestStepLog.GenerateTestStep("Get Elements At Root", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements At Root", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements selected by the user
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsSelectedByUser(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("::selection");
                TestStepLog.GenerateTestStep("Get Elements Selected By User", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements Selected By User", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a valid value
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValidValue(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("input:valid");
                TestStepLog.GenerateTestStep("Get Elements With Valid Value", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Valid Value", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all visited web links
        /// </summary>
        /// <param name="driver">The driver for this session</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetVisitedWebLinks(this IWebDriver driver)
        {
            try
            {
                var elements = driver.FindElementsByCssSelector("a:visited");
                TestStepLog.GenerateTestStep("Get Visited Web Links", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Visited Web Links", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion CSS Selectors (IWebDriver)

        #region CSS Selectors (IWebElement)

        /// <summary>
        /// Gets all elements by css selector
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetAllElements(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("*");
                TestStepLog.GenerateTestStep("Get All Elements", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get All Elements", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by hierarchy using a css selector.  EX: div, p | div p | div > p | div + p | p ~ ul
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="hierarchy">The hierarchy string</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagHierarchy(this IWebElement webElement, string hierarchy)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector(hierarchy);
                TestStepLog.GenerateTestStep($"Get Elements By Tag Hierarchy: {hierarchy}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag Hierarchy: {hierarchy}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a target attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="attribute">the target attribute</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTargetAttribute(this IWebElement webElement, string attribute)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"[{attribute}]");
                TestStepLog.GenerateTestStep($"Get Elements With Target Attribute: {attribute}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Target Attribute: {attribute}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with the blank target attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithBlankTargetAttribute(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"[target = _blank]");
                TestStepLog.GenerateTestStep("Get Elements With Blank Target Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Blank Target Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an attribute containing a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeContainingValue(this IWebElement webElement, string attribute, string value)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"[{attribute}~={value}]");
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Containing Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Containing Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an attribute starting with a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithAttributeStartingWithValue(this IWebElement webElement, string attribute, string value)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"[{attribute}|={value}]");
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Starting With Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Attribute: {attribute} Starting With Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">the tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartingWithValue(this IWebElement webElement, string tag, string attribute, string value)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}[{attribute}^='{value}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With Value:{value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With Value:{value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute ending with a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeEndingWithValue(this IWebElement webElement, string tag, string attribute, string value)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}[{attribute}$='{value}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Ending With Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Ending With Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute starting with one value and ending with a second value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="startsWith">The beginning of the value</param>
        /// <param name="endsWith">The end of the value</param>
        /// <returns></returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeStartAndEndingWithValues(this IWebElement webElement, string tag, string attribute, string startsWith, string endsWith)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}[{attribute}^='{startsWith}'][{attribute}$='{endsWith}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With: {startsWith} And Ending With: {endsWith}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Starting With: {startsWith} And Ending With: {endsWith}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a tag and attribute containing a specified value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <param name="attribute">The attribute</param>
        /// <param name="value">The value</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithTagAndAttributeContainingValue(this IWebElement webElement, string tag, string attribute, string value)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}[{attribute}*='{value}']");
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Containing Value: {value}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements With Tag: {tag} And Attribute: {attribute} Containing Value: {value}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that are active web links
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetActiveWebLinks(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("a:active");
                TestStepLog.GenerateTestStep("Get Active Web Links", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Active Web Links", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a checked state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithCheckedState(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:checked");
                TestStepLog.GenerateTestStep("Get Elements With Checked State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Checked State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a default state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDefaultState(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:default");
                TestStepLog.GenerateTestStep("Get Elements With Default State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Default State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a disabled state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithDisabledState(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:disabled");
                TestStepLog.GenerateTestStep("Get Elements With Disabled State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Disabled State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have no children
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndNoChildren(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:empty");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And No Children", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And No Children", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an enabled state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithEnabledState(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:enabled");
                TestStepLog.GenerateTestStep("Get Elements With Enabled State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Enabled State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a first child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag"></param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstChild(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:first-child");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Child", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Child", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a first of type parent
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndFirstTypeOfParent(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:first-of-type");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Type Of Parent", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And First Type Of Parent", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that are focused
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByFocus(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:focus");
                TestStepLog.GenerateTestStep("Get Elements By Focus", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements By Focus", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a value that's in range
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueInRange(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:in-range");
                TestStepLog.GenerateTestStep("Get Elements With Value In Range", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Value In Range", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an indeterminate state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithIndeterminateState(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:indeterminate");
                TestStepLog.GenerateTestStep("Get Elements With Indeterminate State", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Indeterminate State", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with an invalid value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithInvalidValue(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:invalid");
                TestStepLog.GenerateTestStep("Get Elements With Invalid Value", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Invalid Value", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a last child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastChild(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:last-child");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Child", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Child", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have a last of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndLastTypeOfParent(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:last-of-type");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Type Of Parent", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Last Type Of Parent", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that are links with an unvisited state
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetUnvisitedLinks(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("a:link");
                TestStepLog.GenerateTestStep("Get Unvisited Links", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Unvisited Links", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that lack a specific tag
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByNotTag(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($":not({tag})");
                TestStepLog.GenerateTestStep($"Get Elements By Not Tag: {tag}", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Not Tag: {tag}", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and child index
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndChildIndex(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:nth-child(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Child Index", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the reversed child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndReversedChildIndex(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:nth-last-child(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Reversed Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Reversed ChildIndex", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the child of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndChildIndex(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:nth-of-type(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Child Index", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the last child of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndReversedChildIndex(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:nth-last-of-type(2)");
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Reversed Child Index", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Reversed Child Index", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag and the index of the only child of type
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsBySameTagAndOnlyChildOfType(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:only-of-type");
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Only Child Of Type", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Same Tag: {tag} And Only Child Of Type", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements by tag that have an only child
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <param name="tag">The tag</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsByTagAndOnlyChild(this IWebElement webElement, string tag)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector($"{tag}:only-child");
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Only Child", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep($"Get Elements By Tag: {tag} And Only Child", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements without the required attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutRequiredAttribute(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:optional");
                TestStepLog.GenerateTestStep("Get Elements Without Required Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements Without Required Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have an out of range value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValueOutOfRange(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:out-of-range");
                TestStepLog.GenerateTestStep("Get Elements With Value Out Of Range", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Value Out Of Range", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have a placeholder value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithPlaceholderValue(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input::placeholder");
                TestStepLog.GenerateTestStep("Get Elements With Placeholder Value", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Placeholder Value", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements that have the read only attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithReadOnlyAttribute(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:read-only");
                TestStepLog.GenerateTestStep("Get Elements With Read Only Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Read Only Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements thatlack the read only attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithoutReadOnlyAttribute(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:read-write");
                TestStepLog.GenerateTestStep("Get Elements Without Read Only Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements Without Read Only Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with the required attribute
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithRequiredAttribute(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:required");
                TestStepLog.GenerateTestStep("Get Elements With Required Attribute", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Required Attribute", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements at the root
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementAtRoot(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector(":root");
                TestStepLog.GenerateTestStep("Get Elements At Root", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements At Root", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements selected by the user
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsSelectedByUser(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("::selection");
                TestStepLog.GenerateTestStep("Get Elements Selected By User", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements Selected By User", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all elements with a valid value
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetElementsWithValidValue(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("input:valid");
                TestStepLog.GenerateTestStep("Get Elements With Valid Value", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Elements With Valid Value", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        /// <summary>
        /// Gets all visited web links
        /// </summary>
        /// <param name="webElement">The web element to scope to</param>
        /// <returns>Returns a read only collection of selenium web elements</returns>
        public static IReadOnlyCollection<IWebElement> GetVisitedWebLinks(this IWebElement webElement)
        {
            try
            {
                var elements = webElement.FindElementsByCssSelector("a:visited");
                TestStepLog.GenerateTestStep("Get Visited Web Links", "Elements retrieved", "Success", BrowserFactory.Stopwatch.Elapsed);
                return elements;
            }
            catch (Exception e)
            {
                Logging.FailureReason = e.Message.Split(":").First();
                TestStepLog.GenerateTestStep("Get Visited Web Links", Logging.FailureReason, "Failure", BrowserFactory.Stopwatch.Elapsed);
                throw;
            }
        }

        #endregion CSS Selectors (IWebElement)
    }
}
