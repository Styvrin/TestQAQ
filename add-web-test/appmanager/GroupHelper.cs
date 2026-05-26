using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        
        public GroupHelper(ApplicationManager manager) 
            : base(manager) 
        {
      
        }

        public GroupHelper Create(GruopDate gruop)
        {
            manager.navigator.GoToGrouppage();
            InitNewGroupCreation();
            FillGroupForm(gruop);
            SumbitGroupCreation();
            ReturnToGroups();
            return this;
        }

        public GroupHelper Modify(int p, GruopDate newData)
        {
            manager.navigator.GoToGrouppage();
            SelectGroup(p);
            InitGroupModification();
            FillGroupForm(newData);
            SumbitGroupModification();
            ReturnToGroups();

            return this;
        }

      

        public GroupHelper Remove(int p)
        {
            manager.navigator.GoToGrouppage();
            SelectGroup(p);
            RemoveGroup();
            ReturnToGroups();
            

            return this;

        }

        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper FillGroupForm(GruopDate gruop)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(gruop.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(gruop.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(gruop.Footer);
            return this;
        }
        public GroupHelper SumbitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ReturnToGroups()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + index + "]/input")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[5]")).Click();
            return this;
        }

        public GroupHelper SumbitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

    }
}
