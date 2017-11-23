using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            Contact contact = new Contact();
                contact.Firstname = "Vladimir";
                contact.Middlename = "Middlername";
                contact.Lastname = "Logvinov";
                contact.Nickname = "vlogvinov";
                contact.Title = "Mr.";
                contact.Company = "Valtech";

            app.Contacts.Create(contact);
        }
    }
}
