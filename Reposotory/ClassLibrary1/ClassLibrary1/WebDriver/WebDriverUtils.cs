using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using PetCareTests.Configuration;

namespace PetCareTests.WebDriver
{
    public class WebDriverUtils
    {
        public static IWebDriver CreateWebDriver()
        {
            string browser = Config.GetBrowser();
            if (browser == "Chrome")
            {
                return new ChromeDriver();
            }
            else if (browser == "FireFox")
            {
                return new FirefoxDriver();
            }
            else
            {
                throw new InvalidOperationException("Browser is not Supported");
            }
        }
    }
}
