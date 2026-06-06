using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // prepare
            app.auth.Logout();
            //action
            AccountDate account = new AccountDate("admin", "secret");
            app.auth.Login(account);
            //verification
            Assert.IsTrue(app.auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInValidCredentials()
        {
            // prepare
            app.auth.Logout();
            //action
            AccountDate account = new AccountDate("admin", "limonka");
            app.auth.Login(account);
            //verification
            Assert.IsFalse(app.auth.IsLoggedIn(account));
        }
    }
}
