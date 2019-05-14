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
    public class SSTlogin
    {
        [Test]
        public void SSTloginTest()
        {
            var testUsername = "admin";
            var testPassword = "2VLu=j^ykC";
            

            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes");

                var SSTloginPage = new SSTloginPages(driver);

                SSTloginPage.FillOut(testUsername, testPassword);

                SSTloginPage.ClickLoginButton();

                SSTloginPage.ClickAdminBtn();

                SSTloginPage.ClickLogOut();

                
            }
        }
        
    }
}
        