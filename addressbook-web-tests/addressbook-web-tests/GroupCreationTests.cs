using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {

        [Test]
        public void GroupCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData();
                group.Name = "NEW";
                group.Header = "Header";
                group.Footer = "Footer";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
        }
    }
}
