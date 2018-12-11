namespace SeleniumWebDriverFirstTests
{
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using SeleniumWebDriverFirstTests.Factory;
    using SeleniumWebDriverFirstTests.Models;
    using SeleniumWebDriverFirstTests.Pages.DraggablePage;
    using SeleniumWebDriverFirstTests.Pages.RegistrationPage;
    using SeleniumWebDriverFirstTests.Pages.SideBarPage;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class RegisterInDemoQAChrome
    {
        private IWebDriver _driver;
        private DraggablePage _draggablePage;
        private SideBarPage _sideBarPage;
        private RegistrationPage _regPage;
        private RegisterUser user;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
           _draggablePage = new DraggablePage(_driver);
            _sideBarPage = new SideBarPage(_driver);
            _regPage = new RegistrationPage(_driver);
            user = UserFactory.ReigsterUser();
            _driver.Navigate().GoToUrl("http://demoqa.com/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                screenshot.SaveAsFile(Path.GetFullPath(@"..\..\..\screenshots\") + TestContext.CurrentContext.Test.Name + ".png", ScreenshotImageFormat.Png);
            }
            
            Thread.Sleep(100);
           _driver.Quit();
        }

        [Test]
        public void NavigateToregistrationPage()
        {
            _sideBarPage.RegistrationButton.Click();

            Assert.IsTrue(_regPage.HeaderMessage.Displayed);
            StringAssert.Contains("Registration", _regPage.HeaderMessage.Text);
            Thread.Sleep(2000);
            _driver.Quit();
        }

        [Test]
        public void RegistrateWithValidData()
        {
            //Arrange
            _regPage.NavigateTo();
            //change it on evry new Test
            user.FirstName = "Mnogo543e";
            user.UserName = "no755gfagtregist";
            user.Email = "to6000k76ao@abv.bg";
            //Act
            _regPage.FillRegistrationForm(user);
            Thread.Sleep(3000);
            //Assert
            
            Assert.IsTrue(_regPage.RegistrationMessage.Displayed);
            StringAssert.Contains("Thank you", _regPage.RegistrationMessage.Text);
            Thread.Sleep(2000);
            
            //Thread.Sleep(1000);
            //_driver.Quit();
        }
        [Test]
        public void RegistrateWithDifferentPassswordAndConfirmPassword()
        {
            //Arrange
            _regPage.NavigateTo();
            //change it on evry new Test
            user.FirstName = "Mnogo54bfsdvz3e";
            user.UserName = "no755gfdfvsdagagtregist";
            user.Email = "to600sdfgdh0k76ao@abv.bg";
            user.Password = "newStrong675453Password";
            //Act
            _regPage.FillRegistrationForm(user);
            Thread.Sleep(3000);
            //Assert
            
            Assert.IsTrue(_regPage.PasswordDismatch.Displayed);
            StringAssert.Contains("Fields do not match", _regPage.PasswordDismatch.Text);
            Thread.Sleep(2000);
            _driver.Quit();
        }
        [Test]
        public void RegistrateWithUserAlreadyExist()
        {
            //Arrange
            _regPage.NavigateTo();
            user.FirstName = "Mnogo543e";
            user.UserName = "no755gfagtregist";
            user.Email = "to6000k76ao@abv.bg";
            //Act
            _regPage.FillRegistrationForm(user);
            Thread.Sleep(3000);
            //Assert
            
            Assert.IsTrue(_regPage.RegistrationError.Displayed);
            StringAssert.Contains("Username already exists", _regPage.RegistrationError.Text);
            Thread.Sleep(2000);
            _driver.Quit();
        }
        [Test]
        [TestCase("","Georgiev")]
        [TestCase("", "Георгиев")]
        [TestCase("", "")]
        public void RegistrateWithoutName(string firstName,String lastName)
        {
            _regPage.NavigateTo();
            user.FirstName = firstName;
            user.LastName = lastName;
            _regPage.FillRegistrationFormWithout(user);
          
            Thread.Sleep(2000);
            Assert.IsTrue(_regPage.NameErrorMessage.Displayed);
            Assert.AreEqual("* This field is required", _regPage.NameErrorMessage.Text);
            Thread.Sleep(2000);
            //_driver.Quit();
        }

        [Test]
        public void RegistrateWithoutPhoneNumber()
        {
            _regPage.NavigateTo();
            user.Phone = "";
            _regPage.FillRegistrationForm(user);

            Assert.IsTrue(_regPage.PhoneErrorMessage.Displayed);
            Assert.AreEqual("* This field is required", _regPage.PhoneErrorMessage.Text);
            Thread.Sleep(2000);
            _driver.Quit();
        }
        [Test]
        public void RegistrateWithShortPhoneNumber()
        {
            _regPage.NavigateTo();
            user.Phone = "359";
            _regPage.FillRegistrationForm(user);

            Assert.IsTrue(_regPage.PasswordDismatch.Displayed);
            StringAssert.Contains("* Minimum 10 Digits starting with Country Code", _regPage.PasswordDismatch.Text);
            Thread.Sleep(2000);
            _driver.Quit();
        }
    }
}