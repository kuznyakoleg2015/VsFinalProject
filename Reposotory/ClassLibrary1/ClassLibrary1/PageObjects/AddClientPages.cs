using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1.PageObjects
{
    public class AddClientPages
    {
        private IWebDriver _driver;
        public AddClientPages(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement AddClient => _driver.FindElement(By.PartialLinkText("Add Client"));
        private SelectElement TeacherDropdown => new SelectElement(_driver.FindElement(By.Name("teacherId")));
        private IWebElement CompanyImput => _driver.FindElement(By.Name("company"));
        private IWebElement FirstNameInput => _driver.FindElement(By.Name("firstName"));
        private IWebElement LastNameInput => _driver.FindElement(By.Name("lastName"));
        private SelectElement StateDropdown => new SelectElement(_driver.FindElement(By.Name("state")));
        private IWebElement ZipImput => _driver.FindElement(By.Name("zipCode"));
        private IWebElement SaveButton => _driver.FindElement(By.XPath("//button[@type='submit']"));
        private IWebElement PhoneImput => _driver.FindElement(By.Name("phoneNumber"));
        private IWebElement EmailImput => _driver.FindElement(By.Name("email"));



        public void ClickAddClient()
        {
            AddClient.Click();
        }

        public void FillOutClient(string company, string firstName, string lastName, string zipCode, string phoneNumber, string email)
        {

            CompanyImput.SendKeys(company);
            FirstNameInput.SendKeys(firstName);
            LastNameInput.SendKeys(lastName);
            ZipImput.SendKeys(zipCode);
            PhoneImput.SendKeys(phoneNumber);
            EmailImput.SendKeys(email);
        }
        public void TeacherId (string teacherId)
        {
            TeacherDropdown.SelectByText(teacherId);
        }
        public void SelectState(string state)
        {
            StateDropdown.SelectByText(state);
        }
        public void ClickSaveButton()
        {
            SaveButton.Click();
        }

    }
}
