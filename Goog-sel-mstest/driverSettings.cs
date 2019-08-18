using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Goog_sel_mstest
{
    [TestClass]
    public class DriverSettings
    {
        [TestMethod]
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
        }
    }
