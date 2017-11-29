using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {  
        }

        // HIGH LEVEL METHODS 
        public ContactHelper Create(Contact contact)
        {
            InitContactCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper Modify(int index, Contact contact)
        {
            SelectContact(index);
            ClickOnEditIcon(index);
            FillContactForm(contact);
            SumbitContactUpdation();
            return this;
        }

        public ContactHelper Remove(int contact)
        {
            SelectContact(contact);
            ClickOnRemoveButton();
            ConfirmContactRemoval();
            return this;   
        }

        // LOW LEVEL METHODS 
        private ContactHelper SelectContact(int contact)
        {
            driver.FindElement(By.XPath("(//tr[@name='entry']//input)[" + contact + "]")).Click();
            return this;
        }

        private ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        private ContactHelper FillContactForm(Contact contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            return this;
        }

        private ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }

        private ContactHelper ConfirmContactRemoval()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            return this;
        }

        private ContactHelper ClickOnRemoveButton()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        private ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        private void ClickOnEditIcon(int index)
        {
            driver.FindElement(By.XPath("(//tr[@name='entry'])[" + index + "]/td[8]/a")).Click();
        }

        private void SumbitContactUpdation()
        {
            driver.FindElement(By.XPath("(//input[@name='update'])[2]")).Click();
        }
    }
}
