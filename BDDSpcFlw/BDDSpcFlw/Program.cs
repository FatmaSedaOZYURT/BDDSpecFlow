using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
namespace BDDSpcFlw
{
    class Program
    {
        static void Main()
        {
           // SearchTest();
        }
        [Test]
        public void SearchTest()
        {
            //Launch Browser                                                           FireFox arama motoronunun driver linki      ve       driver ın kendisi...
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\fsozy\Downloads\geckodriver-v0.26.0-win64", "geckodriver.exe");
            IWebDriver driver = new FirefoxDriver(service);

            //Navigate to URL https://www.codeproject.com/
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            driver.Navigate().GoToUrl("https://www.codeproject.com/");

            //Click on Search Search
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();


            //Enter Testing
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("testing");

          

            //Click on Search Button 
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();

            driver.Dispose();
            driver.Quit();
        }
    }
}
