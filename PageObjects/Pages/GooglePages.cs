using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 
namespace TestsUI.Pages
{
    public class GooglePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "lst-ib")]
        public IWebElement txtSearch { get; set; }
 
        [FindsBy(How = How.Name, Using = "btnG")]
        public IWebElement btnSearch { get; set; }
 
        [FindsBy(How = How.CssSelector, Using = "#rso a:nth-child(1)")]
        public IWebElement firstResult { get; set; }
 
        /// <summary>
        /// Goes to Google's main URL.
        /// </summary>
        public void NavigateToMainPage()
        {
            Driver.Navigate().GoToUrl(baseURL);
        }
 
        /// <summary>
        /// Query a search to Google's official page.
        /// </summary>
        // <param name="text">The text to be searched.</param>
        public void Search(string text)
        {
            txtSearch.SendKeys(text);
            btnSearch.Click();
 
            // Waits for browser result.
            Thread.Sleep(3000);
        }
    }
}