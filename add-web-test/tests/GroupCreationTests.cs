using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;


namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            //Обязательные поля для GruopDate 
            GruopDate gruop = new GruopDate("lopatka", "HeadLov");
            // Не обязательные поля для GruopDate
            gruop.Footer = "Ololo";

            app.Groups.Create(gruop);

        }

        [Test]
        public void EmptyGroupCreationTest()
        {
           
            GruopDate gruop = new GruopDate("", "");
            gruop.Footer = "";

            app.Groups.Create(gruop);
              

        }
    }
}
