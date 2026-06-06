using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebAddressbookTests
{
    [SetUpFixture]
    public class TsetSuiteFixture
    {


        [SetUp]
        public void InitApplicationManager()
        {
            ApplicationManager app = ApplicationManager.GetInstance();
            app.navigator.GoToHomePage();
            app.auth.Login(new AccountDate("admin", "secret"));
        }

        [TearDown]

        public void StopApplicationManager()
        {
            ApplicationManager.GetInstance().Stop();
        }

    }
}