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
    public class TestBase
    {
        protected ApplicationManager app;




        [SetUp]
        public void SetupTest()
        {
            app = ApplicationManager.GetInstance();
        }

        public static string GenerateRandomString(int v)
        {
            Random rnd = new Random();
            string str = "";
            for (int i = 0; i < v; i++)
            {
                str += Convert.ToChar(rnd.Next(48, 122));
            }
            return str;
        }
    }
}
