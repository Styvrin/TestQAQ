using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;

        public ApplicationManager()
        {

            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook";
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this);
            groupHelper = new GroupHelper(this);
        }

        public IWebDriver Driver 
        {
            get
            {
                return driver;
            }
                }
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper auth
        {
            get 
            { 
                return loginHelper; 
            }
        }

        public NavigationHelper navigator
        {
            get
            {
                return navigationHelper;
            }
        }
        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

    }
}
