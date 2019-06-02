using OpenQA.Selenium;
using System;

namespace SharpSele.PageObjests
{
    public class BasePage
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
