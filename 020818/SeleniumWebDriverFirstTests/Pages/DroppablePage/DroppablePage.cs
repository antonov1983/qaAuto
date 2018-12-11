using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumWebDriverFirstTests.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string URL => this.URL + "droppable/";

        public void NavigateTo()
        {
            this.Driver.Url = this.URL;
        }
    }
}
