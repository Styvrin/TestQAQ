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
            navigationHelper.GoToHomePage();
            //Class Login
            loginHelper.Login(new AccountDate("admin", "secret"));
            navigationHelper.GoToGrouppage();
            groupHelper.InitNewGroupCreation();
            //Обязательные поля для GruopDate 
            GruopDate gruop = new GruopDate("NameSer","HeadLov");
            // Не обязательные поля для GruopDate
            gruop.Footer = "Ololo";
            groupHelper.FillGroupForm(gruop);
            groupHelper.SumbitGroupCreation();
            groupHelper.ReturnToGroups();
         
        }
    }
}
