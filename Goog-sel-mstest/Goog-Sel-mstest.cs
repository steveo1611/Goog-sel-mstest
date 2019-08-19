using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Sel_MSTest_1
{
    [TestClass]
    public class GoogSelMstest
    {
        [ClassInitialize]
 
        public static void DrvSetup(TestContext testContext)  //***?????
        {
            IWebDriver driver = TestSetupSettings.ChrmDriverSetup();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Navigate().GoToUrl("https://www.google.com/gmail");
            driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public  void LogIn_UserName_Gmail_ConectToMailBox_Test(IWebDriver driver)
        {
            LogInOut.UserLogIn(driver, TestSetupSettings.name());

        }

        [TestMethod]
        public  void LogIn_PassWord_Gmail_ConectToMailBox_Test(IWebDriver driver)
        {
            LogInOut.UserPassword(driver, TestSetupSettings.psWord());
        }
        [TestMethod]
        public  void Email_Compose_Gmail_Test(IWebDriver driver)
        {
            Email.UserEmailCompose(driver, TestSetupSettings.name(), TestSetupSettings.bodyText());
        }
        [TestMethod]
        public  void Email_Validate_RecievedMail_Test(IWebDriver driver)
        {
            Email.UserEmailCompose(driver, TestSetupSettings.name(), TestSetupSettings.bodyText());
        }
        [TestMethod]
        public  void Email_LogOut_Test(IWebDriver driver)
        {
            LogInOut.EmailLogOut(driver);
        }
    }
}

