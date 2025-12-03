using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
      
        [SetUp]
        public void SetupTest()
        {    
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void GroupCreationTest()
        {
            OpenPage();
            //Class Login
            Login(new AccountDate("admin", "secret"));
            GoToGrouppage();
            InitNewGroupCreation();
            //Обязательные поля для GruopDate 
            GruopDate gruop = new GruopDate("NameSer","HeadLov");
            // Не обязательные поля для GruopDate
            gruop.Footer = "Ololo";
            FillGroupForm(gruop);
            SumbitGroupCreation();
            ReturnToGroups();
         
        }

        private void ReturnToGroups()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }

        private void SumbitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        private void FillGroupForm(GruopDate gruop)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(gruop.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(gruop.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(gruop.Footer);
        }

        private void InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        private void GoToGrouppage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        private void Login(AccountDate account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        private void OpenPage()
        {
            // Opne home page
            driver.Navigate().GoToUrl(baseURL);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
