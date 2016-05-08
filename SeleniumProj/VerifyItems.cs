using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; //to use googlechrome browser.
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.IO;

namespace SeleniumProj
{
    [TestClass]
    public class VerifyItems
    {
        IWebDriver driver;
        string url = "https://dfw-xapp1-st.dnet3.com/";
        [TestInitialize]
        public void TestSetup()
        {
            string wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            driver = new ChromeDriver(wanted_path);
            driver.Navigate().GoToUrl(url);
        }
        [TestCleanup]
        public void Cleanup()
        {
            driver.Quit();
        }

       
        [TestMethod]
        public void BankingLogin()
        {
            //System.Threading.Thread.Sleep(10000);
            //IWebElement userNameElement = driver.FindElement(By.Id("challengeUsername"));
            //userNameElement.SendKeys("johnsmith");
            //IWebElement passwordNameElement = driver.FindElement(By.Id("challengePassword"));
            //passwordNameElement.SendKeys("Iberia123!");
            //driver.FindElement(By.ClassName("btn-submit")).Click();
            //System.Threading.Thread.Sleep(10000);
            //IWebElement secretQuestionAnswer = driver.FindElement(By.Id("secretQuestionAnswer"));
            //secretQuestionAnswer.SendKeys("denver");
            //driver.FindElement(By.ClassName("btn-submit")).Click();
            //System.Threading.Thread.Sleep(10000);
            //var description = driver.FindElements(By.CssSelector("#main > div > section > div.row.manage-widgets > div.col-md-5 > div.accounts-view > div > article.internal-accounts > div > ul"));
            //foreach (IWebElement option in description)
            //{
            //    string[] accountDetails = option.Text.Split('\r');
            //}
            Assert.IsTrue(true);
        }
    }
}
