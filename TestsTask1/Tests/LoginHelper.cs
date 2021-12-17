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
    public class LoginHelper : HelperBase
    {
        public AccountData test;
        public LoginHelper(ApplicationManager manager)
            : base(manager)
        {
        }

        public AccountData GetCreatedAccountData()
        {
            string login = driver.FindElement(By.Id("username")).GetAttribute("value");
            string password = driver.FindElement(By.Id("password")).GetAttribute("value");
            return new AccountData(login, password);
        }
        
        public void Login(AccountData user)
        {
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys(user.Username);
            driver.FindElement(By.Id("loginButton")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(user.Password);
            test = GetCreatedAccountData();
            driver.FindElement(By.Id("loginButton")).Click();
        }

        public void Logout()
        {
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='timur.122@yandex.ru'])[1]/following::*[name()='svg'][1]")).Click();
            driver.FindElement(By.XPath("//a[@id='qa-ACCOUNT_DROPDOWN_LOGOUT']/div/span/span")).Click();
        }
    }
}
