using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace sharp_sele2.PageObjests
{
    class HomePageLocator
    {
        // Page element locator should go here
        public static By menuAgeCare = By.Id("tab-52935a4d-064c-4a3c-9cbb-4f065960027f");
        public static By menuDetal = By.Id("tab-379a2db1-9086-411d-9708-79238015e016");
        public static By activeQuickLink = By.CssSelector("div[class='tab-pane is-active'] div.quick-links");
    }
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
            homeURL = "https://www.bupa.com.au/";
        }

        public void ClickMenu(String menuName)
        {
            By menu = null;
            switch (menuName)
            {
                case "Aged Care Homes":
                    menu = HomePageLocator.menuAgeCare;
                    break;
                case "Dental":
                    menu = HomePageLocator.menuDetal;
                    break;
                default:
                    throw new NotImplementedException(string.Format("Menu {0} not supported!", menuName));
            }
            driver.FindElement(menu).Click();
        }

        public string GetActiveContent() {
                return driver.FindElement(HomePageLocator.activeQuickLink).Text;
            }

    }
}
