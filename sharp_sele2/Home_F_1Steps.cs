using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

using sharp_sele2.PageObjests;
using NUnit.Framework;

namespace sharp_sele2
{
    [Binding]
    public class Home_F_1Steps
    {
        private static FirefoxDriver driver;
        private static HomePage page;

        [BeforeScenario]
        public void ScenarioSetup()
        {
            Console.WriteLine(System.AppContext.BaseDirectory);
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
            //IWebDriver driver = new FirefoxDriver();
            //driver.Url = "https://www.bupa.com.au/";

            page = new HomePage(driver);
        }

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            
            page.goToHome();
        }
        
        [Given(@"I click on menu (.*)")]
        public void GivenIClickOnMenu(string menu)
        {
            //driver.FindElement(By.Id("tab-52935a4d-064c-4a3c-9cbb-4f065960027f")).Click();
            //Console.WriteLine(menu);
            page.clickMenu(menu);
        }
        
        [Then(@"I should see menu conains (.*)")]
        public void ThenIShouldSeeMenuConains(string content)
        {
            string activeText = page.getActiveContent();
            StringAssert.Contains(content, activeText);
            Console.WriteLine(activeText);            
        }

        [AfterScenario]
        public void ScenarioTearDown()
        {
            driver.Close();
        }
    }
}
