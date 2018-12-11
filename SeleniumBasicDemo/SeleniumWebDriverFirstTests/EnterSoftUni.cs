﻿namespace SeleniumWebDriverFirstTests
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class EnterSoftUni
    {
        IWebDriver driver;
        [Test]
        public void NavigateToSoftUni()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            driver.Url = "http://softuni.bg";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement loginButton = wait.Until<IWebElement>((w) =>
            {
                return w.FindElement(By.LinkText("Вход"));
            });
            IWebElement courses= wait.Until<IWebElement>((w) =>
            {
                return w.FindElement(By.XPath("//*[@id=\"header-nav\"]/div[1]/ul/li[2]/a/span"));
            });
            courses.Click();
            IWebElement courseQA = wait.Until<IWebElement>((w) =>
            {
                return w.FindElement(By.XPath("//*[@id=\"header-nav\"]/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/ul/div[1]/ul/li/a"));
            });
            courseQA.Click();
            IWebElement qaText = wait.Until<IWebElement>((w) =>
            {
                return w.FindElement(By.XPath("/html/body/div[3]/header/h1"));
            });
            // StringAssert("QA Automation", qaText.Text);
            StringAssert.Contains("QA Automation", qaText.Text);
            
        }
        [TearDown]
        public void Osvobodi()
        {
            Thread.Sleep(3000);
            driver.Close();
            driver.Quit();
        }

    }
}