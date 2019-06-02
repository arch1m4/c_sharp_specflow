using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Drawing;

// TODO: Move this class out of PageObjects directory
namespace sharp_sele2.PageObjests
{
    class BrowserDriver
    {
        // Return web driver according to environment variable
        public IWebDriver GetDriver()
        {
            IWebDriver driver;
            // Get environment varaible for browser type
            String driverType = System.Environment.GetEnvironmentVariable("SELENIUM_DRIVER_TYPE");
            if (driverType == "Chrome")
            {
                ChromeDriverService ChromeService = ChromeDriverService.CreateDefaultService();
                driver = new ChromeDriver(ChromeService);
            }
            else if (driverType == "Remote")
            {
                FirefoxOptions options = new FirefoxOptions();
                options.PlatformName = "Linux";
                String URI = System.Environment.GetEnvironmentVariable("SELENIUM_GRID_URI");
                driver = new RemoteWebDriver(new Uri(URI), options.ToCapabilities());
            }
            else
            {
                // Default to Firefox driver
                var firefoxOptions = new FirefoxOptions();
                // TODO: add headless arg so the test scripts can be run in UIless env such as Docker
                // firefoxOptions.AddArguments(new List<string>() { "no-sandbox", "headless", "disable-gpu" });
                // FirefoxDriverService FFService = FirefoxDriverService.CreateDefaultService();
                driver = new FirefoxDriver(firefoxOptions);
            }
            // Additional customizations
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
