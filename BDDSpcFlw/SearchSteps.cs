using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace BDDSpcFlw
{
    [Binding]
    public class SearchSteps
    {
        public IWebDriver driver;
        [Given(@"Launch Firefox")]
        public void GivenLaunchFirefox()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\fsozy\Downloads\geckodriver-v0.26.0-win64", "geckodriver.exe");
            driver = new FirefoxDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }
        [Given(@"Navigate to Code Project")]
        public void GivenNavigateToCodeProject()
        {
            driver.Navigate().GoToUrl("https://www.codeproject.com/");
        }
        [When(@"Click on Search Our Articles")]
        public void WhenClickOnSearchOurArticles()
        {
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();
        }
        [When(@"Enter Testing")]
        public void WhenEnterTesting()
        {
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("testing");
        }
        [When(@"Click on Seach Button")]
        public void WhenClickOnSeachButton()
        {
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();
        }        [Then(@"Results should be visible and browser should close")]
        public void ThenResultsShouldBeVisibleAndBrowserShouldClose()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
