using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_sele2.PageObjests
{
    class BasePage
    {
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
