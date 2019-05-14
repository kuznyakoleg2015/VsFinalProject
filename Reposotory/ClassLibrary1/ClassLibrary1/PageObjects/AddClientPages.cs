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

        private IWebElement AddClient => _driver.FindElement(By.LinkText("Add Client"));
        private SelectElement TeacherDropdown => new SelectElement(_driver.FindElement(By.Name("teacherId")));
        private IWebElement CompanyImput => _driver.FindElement(By.Name("company"));
        private IWebElement FirstNameInput => _driver.FindElement(By.Name("firstName"));
        private IWebElement LastNameInput => _driver.FindElement(By.Name("lastName"));
        private SelectElement StateDropdown => new SelectElement(_driver.FindElement(By.Name("state")));
        private IWebElement ZipImput => _driver.FindElement(By.Name("zipCode"));
        private IWebElement SaveButton => _driver.FindElement(By.TagName("button"));

        internal void FillOutClient(string customerFirstName, string customerLastName, string customerPhoneNumber, string customerEmail)
        {
            throw new NotImplementedException();
        }

        private IWebElement PhoneImput => _driver.FindElement(By.Name("phoneNumaber"));
        private IWebElement EmailImput => _driver.FindElement(By.Name("email"));



        public void ClickAddClient()
        {
            AddClient.Click();
        }

        public void FillOutClient(string company, string firstName, string lastNmae, string zipCode, string phoneNumber, string email)
        {

            CompanyImput.SendKeys(company);
            FirstNameInput.SendKeys(firstName);
            LastNameInput.SendKeys(lastNmae);
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
