using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriverFirstTests.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) 
            : base (driver)
        {
        }

        public string URL => this.URL + "droppable/";

        public void NavigateTo()
        {
            this.Driver.Url = this.URL;
        }
    }
}
