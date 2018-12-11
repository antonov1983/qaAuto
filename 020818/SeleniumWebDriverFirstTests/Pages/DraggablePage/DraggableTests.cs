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



namespace SeleniumWebDriverFirstTests.Pages.DraggablePage
{
    [TestFixture]
    public class DraggableTests
    {
        private IWebDriver _driver;
        private string startLocation;
        private string endLocation;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://demoqa.com/draggable/";
            Thread.Sleep(2000);
        }
        [Test]
        public void NavigateToDroppable()
        {
            IWebElement dropSource = _driver.FindElement(By.Id("draggable"));

             startLocation = dropSource.Location.X.ToString() + " " + dropSource.Location.Y.ToString();
          

            
            Actions builder = new Actions(_driver);
            builder.DragAndDropToOffset(dropSource,200,100).Perform();
            Thread.Sleep(1000);
            endLocation = dropSource.Location.X.ToString() + " " + dropSource.Location.Y.ToString();

            
            Assert.AreNotEqual(startLocation, endLocation);









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
