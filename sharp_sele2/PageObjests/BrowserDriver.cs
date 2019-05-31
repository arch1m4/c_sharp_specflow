using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: Move this class out of PageObjects directory
namespace sharp_sele2.PageObjests
{
    class BrowserDriver
    {
        // Return web driver according to environment variable
        public IWebDriver GetDriver()
        {
            String driverType = System.Environment.GetEnvironmentVariable("SELENIUM_DRIVER_TYPE");
            if (driverType == "Chrome")
            {
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                return new ChromeDriver(service);
            }
            // Default to Firefox driver
            else
            {
                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                return new FirefoxDriver(service);
            }
        }
    }
}
