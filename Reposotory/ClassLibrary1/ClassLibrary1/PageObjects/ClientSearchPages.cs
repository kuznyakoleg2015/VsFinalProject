using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1.PageObjects
{
    class ClientSearchPages
    {

        private IWebDriver _driver;
        public ClientSearchPages(IWebDriver driver)
        {
            _driver = driver;
        }

		
	    private IWebElement SearchBox => _driver.FindElement(By.Id("q"));
		
		private IWebElement SearchBtn => _driver.FindElement(By.ClassName("btn btn-primary"));
       
        public void FillOutSearchBox(string q)
        {
            SearchBox.SendKeys(q);
        }
        public void ClickSearchBtn()
        {
            SearchBtn.Click();
        }
        
    }
}
