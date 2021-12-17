using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class CreateNote : TestBase
    {
        [Test]
        public void CreateNoteTest()
        {
            app.Navigation.OpenHomePage();
            app.Navigation.GoToLoginForm();
            AccountData user = new AccountData("timur.122@yandex.ru", "UKRISstuff");
            app.Auth.Login(user);
            Thread.Sleep(10000);
            app.Note.CreateNote();
        }


    }
}
