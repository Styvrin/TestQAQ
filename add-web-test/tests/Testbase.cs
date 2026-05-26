using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;


namespace WebAddressbookTests
{
    public class TestBase
    {
        

        protected ApplicationManager app;
        [SetUp]
        public void SetupTest()
        {
           app = new ApplicationManager();

            app.navigator.GoToHomePage();
            app.auth.Login(new AccountDate("admin", "secret"));
        }
         
        [TearDown]
        public void TeardownTest()
        {

            app.Stop();
        }
     
      
    }
}
