using NUnit.Framework;
using WebAddressbookTests.Tests;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTest()
        {
            app = TestSuiteFixture.app;
        }
    }
}
