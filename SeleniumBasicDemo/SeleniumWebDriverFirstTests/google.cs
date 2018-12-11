using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using NUnit.Framework;
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
            //IWebElement searchTextBox = _driver.FindElement(By.Id("lst-ib"));
            searchTextBox.Click();
            //searchTextBox.Clear();
            
            searchTextBox.SendKeys("Selenium");

            //Actions builder = new Actions(_driver);
            //builder.SendKeys(Keys.Enter);
            Thread.Sleep(1500);
           //IWebElement searchButton = _driver.FindElement(By.ClassName("lsb"));
            IWebElement searchButton = _driver.FindElement(By.XPath("//*[@id=\"sbtc\"]/div[2]/div[2]/div[1]/div/ul/li[11]/div/span[2]/span/input"));
            searchButton.Click();
            Thread.Sleep(2000);
            Assert.IsTrue(_driver.Url.Equals("https://www.seleniumhq.org/"));



        }
        [TearDown]
        public void Osvobodi()
        {
            Thread.Sleep(3000);
            _driver.Close();
            _driver.Quit();
        }
    }
}
