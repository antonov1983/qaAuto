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



namespace SeleniumWebDriverFirstTests.Pages.Selectable
{
    [TestFixture]
    public class SelectableTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://demoqa.com/selectable/";
            Thread.Sleep(2000);
        }
        [Test]
        public void NavigateToSelectable()
        {
            IWebElement source1 = _driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[1]"));
            IWebElement source2 = _driver.FindElement(By.XPath("//*[@id=\"selectable\"]/li[4]"));
            //String classBefore = source1.GetAttribute("class");
            string colorStart = source1.GetCssValue("color");
            Actions builder = new Actions(_driver);
            builder.KeyDown(Keys.Control).Click(source1).Click(source2).Perform();
            Thread.Sleep(500);
            string colorEnd = source1.GetCssValue("color");
            
            Assert.AreNotEqual(colorStart, colorEnd);









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
