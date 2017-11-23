using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData();
            group.Name = "NEW";
            group.Header = "Header";
            group.Footer = "Footer";

            app.Groups.Create(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData();
            group.Name = "";
            group.Header = "";
            group.Footer = "";
   
            app.Groups.Create(group);
        }
    }
}
