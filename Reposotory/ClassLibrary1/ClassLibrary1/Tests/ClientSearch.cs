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
            var testSearch = "ilka@mailinator.com ";

            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes");

                var ClieantSearchpage = new ClientSearchPages(driver);

                ClieantSearchpage.FillOutSearchBox(testSearch);

                ClieantSearchpage.ClickSearchBtn();

                var element = driver.FindElement(By.XPath("your_xpath"));
                if (!string.IsNullOrEmpty(element.Text) && element.Text.Contains("your_text"))
                {

                }


            }
        }

    }
}
