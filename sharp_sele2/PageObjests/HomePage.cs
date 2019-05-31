using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace sharp_sele2.PageObjests
{
    class HomePage
    {
        private FirefoxDriver driver;
        public String homeUrl = "https://www.bupa.com.au/";

        // Locators
        private static By menuAgeCare = By.Id("tab-52935a4d-064c-4a3c-9cbb-4f065960027f");
        private static By menuDetal = By.Id("tab-379a2db1-9086-411d-9708-79238015e016");
        private static By activeQuickLink = By.CssSelector("div[class='tab-pane is-active'] div.quick-links");
        public HomePage(FirefoxDriver driver)
        {
            this.driver = driver;
        }

        public void goToHome()
        {
            driver.Url = homeUrl;
        }

        public void clickMenu(String menuName)
        {
            By menu = null;
            switch (menuName)
            {
                case "Aged Care Homes":
                    menu = menuAgeCare;
                    break;
                case "Dental":
                    menu = menuDetal;
                    break;
                default:
                    throw new NotImplementedException(string.Format("Menu {0} not supported!", menuName));
            }
            driver.FindElement(menu).Click();
        }

        public string getActiveContent() {
                return driver.FindElement(activeQuickLink).Text;
            }

    }
}
