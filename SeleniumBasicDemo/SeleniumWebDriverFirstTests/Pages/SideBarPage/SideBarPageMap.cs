using System.Threading;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumWebDriverFirstTests.Pages.DraggablePage;
using SeleniumWebDriverFirstTests.Pages.RegistrationPage;
using SeleniumWebDriverFirstTests.Pages.SideBarPage;
using System;
using System.IO;
using System.Reflection;


namespace SeleniumWebDriverFirstTests.Pages.SideBarPage
{
    public partial class SideBarPage
    {
     
        public IWebElement RegistrationButton => this.Driver.FindElement(By.Id("menu-item-374"));

        public IWebElement DraggableButton => this.Driver.FindElement(By.Id("menu-item-140"));
    }
}
