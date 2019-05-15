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
            var testUsername2 = "admin";
            var testPassword2 = "2VLu=j^ykC";

            var faker = new Faker();
            var customerFirstName = faker.Name.FirstName();
            var customerLastName = faker.Name.LastName();
            var customerPhoneNumber = faker.Phone.PhoneNumber("##########");
            var customerEmail = faker.Internet.Email();



            using (var driver = new ChromeDriver())
            {

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                driver.Navigate().GoToUrl("https://nitro.duckdns.org/sst-classes");

                var SSTloginPage = new SSTloginPages(driver);

                SSTloginPage.FillOut(testUsername2, testPassword2);

                SSTloginPage.ClickLoginButton();

                

                var AddClientPage = new AddClientPages(driver);
                AddClientPage.ClickAddClient();
	            var companyName = "MyCompany";
	            var zipCode = "60640";
				AddClientPage.FillOutClient(companyName, customerFirstName, customerLastName, zipCode, customerPhoneNumber, customerEmail);


                AddClientPage.TeacherId("Teacher One");
                AddClientPage.SelectState("Iowa");
                AddClientPage.ClickSaveButton();

                var clientSearchPage = new ClientSearchPages(driver);
                clientSearchPage.GetResultsTableRowText().ShouldContain(customerFirstName);
                clientSearchPage.GetResultsTableRowText().ShouldContain(customerLastName);
            }
		}

    }
}