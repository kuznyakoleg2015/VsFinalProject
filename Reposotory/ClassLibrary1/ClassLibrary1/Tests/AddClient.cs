using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ClassLibrary1.PageObjects;
using Shouldly;
using Bogus;

namespace ClassLibrary1.Tests
{
    [TestFixture]
    public class AddClient
    {
        [Test]
        public void AddClientTest()
        {
            var faker = new Faker();
            var customerFirstName = faker.Name.FirstName();
            var customerLastName = faker.Name.LastName();
            var customerPhoneNumber = faker.Phone.PhoneNumber("##########");
            var customerEmail = faker.Internet.Email();



            using (var driver = new ChromeDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes");

                var AddClientPage = new AddClientPages(driver);
                AddClientPage.FillOutClient(customerFirstName, customerLastName, customerPhoneNumber, customerEmail);


                AddClientPage.TeacherId("Teacher One");
                AddClientPage.SelectState("Iowa");
                AddClientPage.ClickSaveButton();
            }
        }

    }
}