using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsUI.Configuration;

namespace TestsUI.Pages
{
    public abstract class BasePage
    {
        /// <summary>
        /// Driver to run the UI tests.
        /// </summary>
        protected IWebDriver Driver
        {
            get
            {
                return BaseUITest.Driver;
            }
        }

        /// <summary>
        /// Base URL used for the UI tests.
        /// </summary>
        protected string baseURL { get; set; }

        /// <summary>
        /// Default constructor.
        /// Initializes page objectos within DOM.
        /// </summary>
        public BasePage()
        {

           //Driver.Navigate().GoToUrl("http://www.google.com.br");
           // Driver.Manage().Window.Maximize();
            PageFactory.InitElements(BaseUITest.Driver, this);

            baseURL = "http://www.google.com/";
        }

        /// <summary>
        /// Runs a JS script on the current page.
        /// </summary>
        /// <param name="jsScript">The JS string that holds the script to be executed within the browser.</param>
        protected internal void ExecuteScript(string jsScript)
        {
            ((IJavaScriptExecutor)BaseUITest.Driver).ExecuteScript(jsScript);
        }
    }
}