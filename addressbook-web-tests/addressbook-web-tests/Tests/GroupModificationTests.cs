using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests.Tests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData group = new GroupData();
            group.Name = "MOFIDIED NAME";
            group.Header = "MODOFIED HEADER";
            group.Footer = "MODIFIED FOOTER";

            app.Groups.Modify(1, group);
        }
    }
}
