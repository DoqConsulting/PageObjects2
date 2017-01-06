using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsUI.Configuration;
using TestsUI.Pages;

namespace TestsUI.TestCases
{
    [TestFixture]
    public class SearchTest : BaseUITest
    {
        [Test]
        public void UserCanSearchBlogNETCoders()
        {
            string searchText = "Blog netcoders";
            string expectedTitle = ".NET Coders | Um dos maiores e mais ativos grupos de ...";

            GooglePage gPage = new GooglePage();
            gPage.NavigateToMainPage();
            gPage.Search(searchText);

            Assert.AreEqual(expectedTitle, gPage.firstResult.Text);
        }
    }
}