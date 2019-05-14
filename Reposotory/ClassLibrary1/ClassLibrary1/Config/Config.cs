using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PetCareTests.Configuration
{
    public class Config
    {
        public static string GetEnvironment()
        {
            return GetConfigValue("Environment");
        }

        public static string GetBrowser()
        {
            return GetConfigValue("Browser");
        }
        public static string GetUrl()
        {
            string key = "SSTURL." + GetEnvironment();
            return GetConfigValue(key);
        }
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }




}


