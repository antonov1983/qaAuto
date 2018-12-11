namespace SeleniumWebDriverFirstTests.Pages.RegistrationPage
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System.Collections.Generic;
    using System.Linq;

    public partial class RegistrationPage
    {
        public IWebElement HeaderMessage => this.Driver.FindElement(By.ClassName("entry-title"));

        public IWebElement FirstName => this.Driver.FindElement(By.Id("name_3_firstname"));

        public IWebElement LastName => this.Driver.FindElement(By.Id("name_3_lastname"));

        public List<IWebElement> MatrialStatus => this.Driver.FindElements(By.Name("radio_4[]")).ToList();

        public List<IWebElement> Hobbies => this.Driver.FindElements(By.Name("checkbox_5[]")).ToList();

        public IWebElement Country => this.Driver.FindElement(By.Id("dropdown_7"));

        public SelectElement CountryOption => new SelectElement(this.Country);

        public IWebElement Month => this.Driver.FindElement(By.Id("mm_date_8"));

        public SelectElement MonthOption => new SelectElement(this.Month);

        public IWebElement Day => this.Driver.FindElement(By.Id("dd_date_8"));

        public SelectElement DayOption => new SelectElement(this.Day);

        public IWebElement Year => this.Driver.FindElement(By.Id("yy_date_8"));

        public SelectElement YearOption => new SelectElement(this.Year);

        public IWebElement Phone => this.Driver.FindElement(By.Id("phone_9"));

        public IWebElement UserName => this.Driver.FindElement(By.Id("username"));

        public IWebElement Email => this.Driver.FindElement(By.Id("email_1"));

        public IWebElement UploadPicButton => this.Driver.FindElement(By.Id("profile_pic_10"));

        public IWebElement Description => Wait.Until(d => d.FindElement(By.Id("description")));

        public IWebElement Password => this.Driver.FindElement(By.Id("password_2"));

        public IWebElement ConfirmPassword => this.Driver.FindElement(By.Id("confirm_password_password_2"));

        public IWebElement SubmitButton => this.Driver.FindElement(By.Name("pie_submit"));

        public IWebElement RegistrationMessage => this.Driver.FindElement(By.ClassName("piereg_message"));
        public IWebElement RegistrationError => this.Driver.FindElement(By.ClassName("piereg_login_error"));
        public IWebElement PasswordDismatch => this.Driver.FindElement(By.ClassName("legend_txt"));
        public IWebElement NameErrorMessage => this.Driver.FindElement(By.XPath(@"//*[@id=""pie_register""]/li[1]/div[1]/div[2]/span"));
       

        public IWebElement PhoneErrorMessage => this.Driver.FindElement(By.XPath(@"//*[@id=""pie_register""]/li[6]/div/div/span"));
       
    
    }
    
 
}
