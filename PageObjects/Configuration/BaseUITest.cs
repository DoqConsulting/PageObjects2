using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;

namespace TestsUI.Configuration
{
    [Binding]
    public abstract class BaseUITest
    {
        public static IWebDriver Driver { get; private set; }

        [BeforeTestRun]
        public static void SetupTest()
        {
            if (BaseUITest.Driver == null)
            {
                Driver = new ChromeDriver();
            }

            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
            Driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(30));

            Driver.Manage().Window.Maximize();
        }

        [AfterTestRun]
        public static void TeardownTest()
        {
            try
            {
                Driver.Dispose();
                Driver = null;
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}