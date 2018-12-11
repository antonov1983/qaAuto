using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SeleniumWebDriverFirstTests.Models;

namespace SeleniumWebDriverFirstTests.Factory
{
    public static class UserFactory
    {
        public static RegisterUser ReigsterUser()
        {
            var _user = new RegisterUser();
            _user.FirstName = "Tony";
            _user.LastName = "Qa";
            _user.MatrialStatus = new List<bool>() { false, true, false };
            _user.Hobbies = new List<bool>() { true, false, false };
            _user.Country = "Bulgaria";
            _user.Month = "2";
            _user.Day = "22";
            _user.Year = "1995";
            _user.Phone = "3999999999";
            _user.UserName = "probvamToziUserName3344";
            _user.Email = "oribenemail@abv.bg";
            _user.Description = "napishi neshto da vidq kak e testa";
            _user.PathToLogo = Path.GetFullPath(@"..\..\..\logo.jpg");
            _user.Password = "myVeriSecretPasswor1234";
            _user.ConfirmPasswor= "myVeriSecretPasswor1234";
            return _user;
        }
    }
}
