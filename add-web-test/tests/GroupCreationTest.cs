using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.navigator.GoToHomePage();
            //Class Login
            app.auth.Login(new AccountDate("admin", "secret"));
            app.navigator.GoToGrouppage();
            app.Groups.InitNewGroupCreation();
            //Обязательные поля для GruopDate 
            GruopDate gruop = new GruopDate("NameSer","HeadLov");
            // Не обязательные поля для GruopDate
            gruop.Footer = "Ololo";
            app.Groups.FillGroupForm(gruop);
            app.Groups.SumbitGroupCreation();
            app.Groups.ReturnToGroups();
         
        }
    }
}
