using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sel_MSTest_1
{
    class LogInOut
    {
        internal static void UserLogIn(IWebDriver driver, string name)
        {
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id='identifierId']"));
            signIn.SendKeys(name);
            By loginButton = By.XPath("//*[@id='identifierNext']/span/span");
            driver.FindElement(loginButton).Click();
        }
        internal static void UserPassword(IWebDriver driver, string psWord)
        {
            driver.FindElement(By.XPath("//*[@id='password']//input[@name='password']")).SendKeys(psWord);
            TestSetupSettings.WaitForPage(driver, 10000, ("//*[@id='passwordNext']//span[text()='Next']"));
            driver.FindElement(By.XPath("//*[@id='passwordNext']//span[text()='Next']")).Click();
        }
        internal static void EmailLogOut(IWebDriver driver)
        {
            TestSetupSettings.WaitForPage(driver, 10000, ("//*[@title='Inbox']"));
            driver.FindElement(By.XPath("//*[@title='Inbox']")).Click();
            driver.FindElement(By.XPath("//a[starts-with(@aria-label, 'Google Account: Steve Testfield')]")).Click();
            driver.FindElement(By.XPath("//*[starts-with(@aria-label, 'Account Information')]//a[text()='Sign out']")).Click();
        }

    }
}
