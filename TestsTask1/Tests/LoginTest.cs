using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Serialization;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Login : TestBase
    {
        /*public static IEnumerable<AccountData> AccountDataFromXmlFile()
        {
            return (List<AccountData>)new XmlSerializer(typeof(List<AccountData>))
                .Deserialize(new StreamReader(@"C:\Users\elena\Desktop\x\TestGen\TestGen\bin\Release\netcoreapp3.1\accounts.xml"));
        }*/
        [Test]
        public void LoginTest()
        {
            AccountData user = new AccountData("timur.122@yandex.ru", "UKRISstuff");
            app.Navigation.OpenHomePage();
            app.Navigation.GoToLoginForm();
            app.Auth.Login(user);
            Assert.AreEqual(user.Username, app.Auth.test.Username);
            Assert.AreEqual(user.Password, app.Auth.test.Password);
        }
    }
}

