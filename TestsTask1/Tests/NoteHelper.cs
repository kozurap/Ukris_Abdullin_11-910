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
    public class NoteHelper : HelperBase
    {

        public NoteHelper (ApplicationManager manager ) : base (manager)
        {

        }

        public void CreateNote()
        {
            driver.FindElement(By.Id("qa-CREATE_NOTE")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            driver.FindElement(By.Id("qa-NAV_HOME")).Click();
        }

        public void EditNote()
        {
            driver.FindElement(By.XPath("//article[@id='qa-HOME_WIDGET_ScratchPad_5|0_0|0_G1GTT3|13']/section[2]/div/div[2]/textarea")).Click();
            driver.FindElement(By.XPath("//article[@id='qa-HOME_WIDGET_ScratchPad_5|0_0|0_G1GTT3|13']/section[2]/div/div[2]/textarea")).Clear();
            driver.FindElement(By.XPath("//article[@id='qa-HOME_WIDGET_ScratchPad_5|0_0|0_G1GTT3|13']/section[2]/div/div[2]/textarea"))
                .SendKeys("Hello, my name is George, I am from Philadelphia");
            driver.FindElement(By.Id("qa-NAV_HOME")).Click();
        }

        public void ClearTrashCan()
        {
            driver.FindElement(By.XPath("//nav[@id='qa-NAV']/div/ul/ul/div/div/div/div/div[8]/li/div")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("qa-SPACE_VIEW_ACTIONS_HEADER")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("qa-DIALOG_SUBMIT")).Click();
            driver.FindElement(By.XPath("//button[@id='qa-NAV_HOME']/span")).Click();
        }
    }
}
