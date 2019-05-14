using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1.PageObjects
{
    class SSTloginPages
    {
        private IWebDriver _driver;
        public SSTloginPages(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement SSTloginUsername => _driver.FindElement(By.Id("username"));
        private IWebElement SSTloginPassword => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.LinkText("Login"));
        private IWebElement Nav => _driver.FindElement(By.CssSelector("ul.nav navbar-nav"));
        private IWebElement LocatingAdmin => _driver.FindElement(By.ClassName("dropdown-toggle"));
        private IWebElement LogOut => _driver.FindElement(By.ClassName("dropdown-menu"));


        public void FillOut(string username, string password)
        {
            SSTloginUsername.SendKeys(username);
            SSTloginPassword.SendKeys(password);
        }
        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
        public void ClickAdminBtn()
        {
            LocatingAdmin.Click();
        }
        public void ClickLogOut()
        {
            LogOut.Click();
        }
    }
}
