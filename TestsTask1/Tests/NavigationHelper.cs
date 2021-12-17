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
    public class NavigationHelper : HelperBase
    {

        private string baseURL;
        public NavigationHelper(ApplicationManager manager, string baseURL)
                    : base(manager)
        {
            this.baseURL = baseURL;
        }


        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl("https://evernote.com/intl/ru/");
        }

        public void GoToLoginForm()
        {
            driver.FindElement(By.LinkText("Уже есть аккаунт? Войдите")).Click();
        }
    }
}
