
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitContactCreation();
            Contact contact = new Contact();
                contact.Firstname = "Vladimir";
                contact.Middlename = "Middlername";
                contact.Lastname = "Logvinov";
                contact.Nickname = "vlogvinov";
                contact.Title = "Mr.";
                contact.Company = "Valtech";
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnToHomePage();
        }
    }
}
