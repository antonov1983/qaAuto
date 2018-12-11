namespace SeleniumWebDriverFirstTests.Pages.RegistrationPage
{
    using OpenQA.Selenium;
    using System.IO;
    
    using OpenQA.Selenium.Support.UI;
    using System.Collections.Generic;
    using System.Linq;
    using SeleniumWebDriverFirstTests.Models;

    public partial class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver)
            : base(driver)
        {
        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
        }
       
        
        public void FillRegistrationForm(RegisterUser user)
        {


            Type(FirstName, user.FirstName);
            Type(LastName,user.LastName);
            //this.MatrialStatus[1].Click();
            //this.Hobbies[0].Click();
            //this.Hobbies[1].Click();
            FillCheckAndRadioOptions(MatrialStatus, user.MatrialStatus);
            FillCheckAndRadioOptions(Hobbies, user.Hobbies);
                
            CountryOption.SelectByText(user.Country);
            MonthOption.SelectByValue(user.Month);
            DayOption.SelectByText(user.Day);
            YearOption.SelectByValue(user.Year);
            Type(Phone,user.Phone);
            Type(UserName, user.UserName);
            Type(Email, user.Email);
            UploadPicButton.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(user.PathToLogo);
            Type(Description, user.Description);
            Type(Password, user.Password);
            Type(ConfirmPassword, user.ConfirmPasswor);
            SubmitButton.Click();
        }
        public void FillRegistrationFormWithout(RegisterUser user)
        {


            Type(FirstName, user.FirstName);
            Type(LastName, user.LastName);
            //this.MatrialStatus[1].Click();
            //this.Hobbies[0].Click();
            //this.Hobbies[1].Click();
            //FillCheckAndRadioOptions(MatrialStatus, user.MatrialStatus);
            //FillCheckAndRadioOptions(Hobbies, user.Hobbies);

            //CountryOption.SelectByText(user.Country);
            //MonthOption.SelectByValue(user.Month);
            //DayOption.SelectByText(user.Day);
            //YearOption.SelectByValue(user.Year);
            //Type(Phone, user.Phone);
            //Type(UserName, user.UserName);
            //Type(Email, user.Email);
            //UploadPicButton.Click();
            //Driver.SwitchTo().ActiveElement().SendKeys(user.PathToLogo);
            //Type(Description, user.Description);
            //Type(Password, user.Password);
            //Type(ConfirmPassword, user.ConfirmPasswor);
            //SubmitButton.Click();
        }
        public void FillCheckAndRadioOptions(List<IWebElement> elements,List<bool> optionValues)
        {
           for (int i = 0; i < elements.Count; i++)
            {
                if(optionValues[i]==true)
                {
                    elements[i].Click();
                }
                    
                 
            }
        }
    }
}
