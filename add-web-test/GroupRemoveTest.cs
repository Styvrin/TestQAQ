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
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountDate("admin","secret"));
            navigationHelper.GoToGrouppage();
            groupHelper.SelectGroup(1);
            groupHelper.RemoveGroup();
            groupHelper.ReturnToGroups();
        }
    }
}
