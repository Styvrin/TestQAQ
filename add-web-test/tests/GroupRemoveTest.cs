using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemoveTests : TestBase
    {
      
        [Test]
        public void GroupRemoveTest()
        {
            app.navigator.GoToHomePage();
            app.auth.Login(new AccountDate("admin","secret"));
            app.navigator.GoToGrouppage();
            app.Groups.SelectGroup(1);
            app.Groups.RemoveGroup();
            app.Groups.ReturnToGroups();
        }
    }
}
