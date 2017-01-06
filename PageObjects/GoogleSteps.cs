using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;
using TestsUI.Configuration;
using TestsUI.Pages;

namespace PageObjects
{
    [Binding]
    public class GoogleSteps : GooglePage

    {

        [Given(@"que eu esteja no site google")]
        public void DadoQueEuEstejaNoSiteGoogle()
        {
            GooglePage gPage = new GooglePage();
            gPage.NavigateToMainPage();
        }

        [Then(@"eu localizo o texto")]
        public void EntaoEuLocalizoOTexto()
        {
            string searchText = "Blog netcoders";
            string expectedTitle = ".NET Coders | Um dos maiores e mais ativos grupos de estudos de ...";

            GooglePage gPage = new GooglePage();

            gPage.Search(searchText);

            Assert.AreEqual(expectedTitle, gPage.firstResult.Text);
        }


    }
}
