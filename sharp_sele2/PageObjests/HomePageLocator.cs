using OpenQA.Selenium;

namespace SharpSele.PageObjests
{
    public class HomePageLocator
    {
        // Page element locator should go here
        public static By menuAgeCare = By.Id("tab-52935a4d-064c-4a3c-9cbb-4f065960027f");
        public static By menuDetal = By.Id("tab-379a2db1-9086-411d-9708-79238015e016");
        public static By activeQuickLink = By.CssSelector("div[class='tab-pane is-active'] div.quick-links");
    }
}
