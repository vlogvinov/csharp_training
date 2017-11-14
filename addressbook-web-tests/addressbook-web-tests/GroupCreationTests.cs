using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests {

        private IWebDriver driver;
        private string baseURL;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://addressbook/";

        }

        [Test]
        public void GroupCreationTest()
        {
                driver.Navigate().GoToUrl("http://addressbook/");
                driver.FindElement(By.Name("user")).Click();
                driver.FindElement(By.Name("user")).Clear();
                driver.FindElement(By.Name("user")).SendKeys("admin");
                driver.FindElement(By.Name("pass")).Click();
                driver.FindElement(By.Name("pass")).Clear();
                driver.FindElement(By.Name("pass")).SendKeys("secret");
                driver.FindElement(By.XPath("//form[@id='LoginForm']/input[3]")).Click();
                driver.FindElement(By.LinkText("groups")).Click();
                driver.FindElement(By.Name("new")).Click();
                driver.FindElement(By.Name("group_name")).Click();
                driver.FindElement(By.Name("group_name")).Clear();
                driver.FindElement(By.Name("group_name")).SendKeys("NEW");
                driver.FindElement(By.Name("group_header")).Click();
                driver.FindElement(By.Name("group_header")).Clear();
                driver.FindElement(By.Name("group_header")).SendKeys("HEADER");
                driver.FindElement(By.Name("group_footer")).Click();
                driver.FindElement(By.Name("group_footer")).Clear();
                driver.FindElement(By.Name("group_footer")).SendKeys("FOOTER");
                driver.FindElement(By.Name("submit")).Click();
                driver.FindElement(By.LinkText("group page")).Click();
                driver.FindElement(By.LinkText("Logout")).Click();
        }
        [TearDown]
        public void TeardownTest()
        {
                driver.Quit();
        }
    }
}
