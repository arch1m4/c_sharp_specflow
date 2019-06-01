using OpenQA.Selenium;
using System;

namespace sharp_sele2.PageObjests
{
    class BasePage
    {
        // Variable and functions shared for all pages goes here

        protected IWebDriver driver;
        protected String homeURL;

        public BasePage (IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToHome()
        {
            driver.Url = homeURL;
        }
    }
}
