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
        private IWebElement SSTloginPage => _driver.FindElement(By.Id("root"));
        private IWebElement SSTloginUsername => _driver.FindElement(By.Id("username"));
        private IWebElement SSTloginPassword => _driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => _driver.FindElement(By.CssSelector("#root > div > div > form > div:nth-child(3) > div > div > button"));
        private IWebElement LogOut => _driver.FindElement(By.LinkText("Logout"));
        


        public void FillOut(string username, string password)
        {
            SSTloginUsername.SendKeys(username);
            SSTloginPassword.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }

        public void ClickLogOut()
        {
            LogOut.Click();
        }
    }
}
