using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace WebAddressbookTests
{
    public class NavigationHelper
    {
        private IWebDriver driver;
        public NavigationHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/");
        }

        public void GoToGrouppage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
