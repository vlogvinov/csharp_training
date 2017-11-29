using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests.Tests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            Contact contact = new Contact();
            contact.Firstname = "Vladimir MODIFIED";
            contact.Middlename = "Middlername MODIFIED";
            contact.Lastname = "Logvinov MODIFIED";
            contact.Nickname = "vlogvinov MODIFIED";
            contact.Title = "Mr. MODIFIED";
            contact.Company = "Valtech MODIFIED";

            app.Contacts.Modify(1, contact);
        }
    }
}
