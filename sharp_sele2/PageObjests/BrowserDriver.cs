using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
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
            // Default to Firefox driver
            FirefoxDriverService FFService = FirefoxDriverService.CreateDefaultService();
            driver = new FirefoxDriver(FFService);

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
            

            // Additional customizations
            driver.Manage().Window.Size = new Size(1920, 1080);
            return driver;
        }
    }
}
