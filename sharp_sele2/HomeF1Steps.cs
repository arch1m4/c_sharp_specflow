using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using SharpSele.PageObjests;
using NUnit.Framework;

namespace SharpSele
{
    [Binding]
    public class HomeF1Steps
    {
        // TODO: should add context objects to manage test status
        private IWebDriver driver;
        private static HomePage page;

        [BeforeScenario]
        public void ScenarioSetup()
        {
            
            driver = new BrowserDriver().GetDriver();
            page = new HomePage(driver);
        }

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            page.GoToHome();
        }
        
        [Given(@"I click on menu (.*)")]
        public void GivenIClickOnMenu(string menu)
        {
            page.ClickMenu(menu);
        }
        
        [Then(@"I should see menu contains (.*)")]
        public void ThenIShouldSeeMenuConains(string content)
        {
            String activeText = page.GetActiveContent();
            StringAssert.Contains(content, activeText);      
        }

        [AfterScenario]
        public void ScenarioTearDown()
        {
            driver.Quit();
        }
    }
}
