using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }

        internal void Remove(int index)
        {
            manager.NavigationHelper.GoToGroupsPage();
            SelectGroup(index);
            RemoveGroup();
            ReturnToGroupsPage();
        }

        internal GroupHelper Modify(int index, GroupData group)
        {
            manager.NavigationHelper.GoToGroupsPage();
            SelectGroup(index);
            InitGroupModification();
            FillGroupForm(group);
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this;
        }

        public void SubmitGroupModification()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])")).Click();
        }

        public void InitGroupModification()
        {
            driver.FindElement(By.XPath("(//input[@name='edit'])[1]")).Click();
        }

        private void RemoveGroup()
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[1]")).Click();
        }

        private void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//span[@class='group']/input[@type='checkbox'])[" + index + "]")).Click();
        }

        public GroupHelper Create(GroupData group)
        {
            manager.NavigationHelper.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

    }
}
