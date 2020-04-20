using NUnit.Framework;

using OpenQA.Selenium;

using Selenium1.Framework;

namespace Selenium1.Tests
{
    public abstract class BaseTest
    {
        protected readonly IWebDriver Driver;

        protected BaseTest()
        {
            Driver = Selenium.GetDriver(Settings.Driver);
            Driver.Navigate().GoToUrl(Settings.Url);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() => Driver.Quit();
    }
}
