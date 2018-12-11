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



namespace SeleniumWebDriverFirstTests.Pages.DroppableTests
{
    [TestFixture]
    public class DroppableTests
    {
        private IWebDriver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://demoqa.com/droppable/";
            Thread.Sleep(2000);
        }
        [Test]
        public void NavigateToDroppable()
        {
            IWebElement dropSource = _driver.FindElement(By.XPath("//*[@id=\"draggableview\"]/p"));
            IWebElement dropTarget = _driver.FindElement(By.Id("droppableview"));

            String classBefore = dropTarget.GetAttribute("class");
            Actions builder = new Actions(_driver);
            builder.DragAndDrop(dropSource, dropTarget).Perform();
            string classAfter = dropTarget.GetAttribute("class");
            Assert.AreNotEqual(classBefore, classAfter);





            



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
