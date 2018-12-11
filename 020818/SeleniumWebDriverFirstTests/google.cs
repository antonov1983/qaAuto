using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;



namespace SeleniumWebDriverFirstTests
{
    [TestFixture]
    public class google
    {
        private IWebDriver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://google.bg";
            Thread.Sleep(2000);
        }
        [Test]
        public void NavigateGoogleAndSearch()
        {
            
            
           
            
            IWebElement searchTextBox = _driver.FindElement(By.Id("lst-ib"));
            
            searchTextBox.Click();
            
            
            searchTextBox.SendKeys("Selenium");

            
            Thread.Sleep(1500);
           
            IWebElement searchButton = _driver.FindElement(By.XPath("//*[@id=\"sbtc\"]/div[2]/div[2]/div[1]/div/ul/li[11]/div/span[2]/span/input"));
            searchButton.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(_driver.Url.Equals("https://www.seleniumhq.org/"));



        }
        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(1000);
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                screenshot.SaveAsFile(Path.GetFullPath(@"..\..\..\screenshots\") + TestContext.CurrentContext.Test.Name + ".png", ScreenshotImageFormat.Png);
            }
            _driver.Close();
            _driver.Quit();
        }
    }
}
