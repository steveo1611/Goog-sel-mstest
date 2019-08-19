using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Sel_MSTest_1
{
    class TestSetupSettings
    {
        internal static IWebDriver ChrmDriverSetup()
        {
            ChromeOptions options = new ChromeOptions();
            // switch between below lines for when I do not use incognito version
            // options.AddArguments(@"C:\source\selenium-chrome\");
            options.AddArguments(@"C:\source\selenium-chrome\", "--incognito");
            IWebDriver driver = new ChromeDriver(options);
            return driver;
        }
        internal static object WaitForPage(IWebDriver driver, int waitTime, string elementWaitingOn)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(NotFoundException), typeof(InvalidOperationException));
            IWebElement element = wait.Until(d => driver.FindElement(By.XPath(elementWaitingOn)));
            return element;
        }
        internal static string name()
        {
            return "testfieldsteve";

        }
        internal static string psWord()
        {
            return "J0hn3:16";
        }
        internal static string bodyText()
        {
            return "Body test: this is a test of info in the body of email";
        }

    }
}
