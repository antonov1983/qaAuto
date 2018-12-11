using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriverFirstTests.Models
{
   public class RegisterUser
    {
        //public IWebElement HeaderMessage => this.Driver.FindElement(By.ClassName("entry-title"));
        public string HeaderMessage { get; set; }
        //public IWebElement FirstName => this.Driver.FindElement(By.Id("name_3_firstname"));
        public string FirstName { get; set; }
        //public IWebElement LastName => this.Driver.FindElement(By.Id("name_3_lastname"));
        public string LastName { get; set; }
        //public List<IWebElement> MatrialStatus => this.Driver.FindElements(By.Name("radio_4[]")).ToList();
        public List<bool> MatrialStatus { get; set; }

        //public List<IWebElement> Hobbies => this.Driver.FindElements(By.Name("checkbox_5[]")).ToList();
        public List<bool> Hobbies { get; set; }
        //public IWebElement Country => this.Driver.FindElement(By.Id("dropdown_7"));
        public string Country { get; set; }

        //public SelectElement CountryOption => new SelectElement(this.Country);
        
        //public IWebElement Month => this.Driver.FindElement(By.Id("mm_date_8"));
        public string Month { get; set; }
        //public SelectElement MonthOption => new SelectElement(this.Month);

        //public IWebElement Day => this.Driver.FindElement(By.Id("dd_date_8"));
        public string Day { get; set; }
        //public SelectElement DayOption => new SelectElement(this.Day);

        //public IWebElement Year => this.Driver.FindElement(By.Id("yy_date_8"));
        public string Year { get; set; }
        //public SelectElement YearOption => new SelectElement(this.Year);

        //public IWebElement Phone => this.Driver.FindElement(By.Id("phone_9"));
        public string Phone { get; set; }
        //public IWebElement UserName => this.Driver.FindElement(By.Id("username"));
        public string UserName { get; set; }
        //public IWebElement Email => this.Driver.FindElement(By.Id("email_1"));
        public string Email { get; set; }
        //public IWebElement UploadPicButton => this.Driver.FindElement(By.Id("profile_pic_10"));
        public string PathToLogo { get; set; }
        public string Description { get; set; }
        //public IWebElement Description => Wait.Until(d => d.FindElement(By.Id("description")));
        public string Password { get; set; }
        //public IWebElement Password => this.Driver.FindElement(By.Id("password_2"));
        public string ConfirmPasswor { get; set; }
        //public IWebElement ConfirmPassword => this.Driver.FindElement(By.Id("confirm_password_password_2"));

        //public IWebElement SubmitButton => this.Driver.FindElement(By.Name("pie_submit"));

        //public IWebElement RegistrationMessage => this.Driver.FindElement(By.ClassName("piereg_message"));

        //public IWebElement NameErrorMessage => this.Driver.FindElement(By.XPath(@"//*[@id=""pie_register""]/li[1]/div[1]/div[2]/span"));


        //public IWebElement PhoneErrorMessage => this.Driver.FindElement(By.XPath(@"//*[@id=""pie_register""]/li[6]/div/div/span"));
    }
}
