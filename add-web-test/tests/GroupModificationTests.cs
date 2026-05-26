using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {

            GruopDate newData = new GruopDate("loma", "zizi");
            newData.Footer = "qir";


            app.Groups.Modify(1, newData);

        }
    }
}
