using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ClassLibrary1.PageObjects;
using Shouldly;


namespace ClassLibrary1.Tests
{
    [TestFixture]
    public class ClientSearch
    {
        [Test]
        public void ClientSearchTest()
        {
            var TestUsername = "admin";
            var TestPassword = "2VLu=j^ykC";
            var testSearch = "ilka@mailinator.com";

            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes");

                var SSTloginPage = new SSTloginPages(driver);
                var ClientSearchPage = new ClientSearchPages(driver);

                SSTloginPage.FillOut(TestUsername, TestPassword);

                SSTloginPage.ClickLoginButton();

                ClientSearchPage.FillOutSearchBox(testSearch);

                ClientSearchPage.ClickSearchBtn();
                ClientSearchPage.GetResultsTableRowText().ShouldContain(testSearch);
            }
        }

    }
}
