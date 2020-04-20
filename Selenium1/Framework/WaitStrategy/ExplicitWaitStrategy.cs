using System;

using OpenQA.Selenium;

namespace Selenium1.Framework.WaitStrategy
{
    public class ExplicitWaitStrategy : IWaitStrategy
    {
        public void SetWaitStrategy(IWebDriver driver) => driver.Manage().Timeouts().ImplicitWait = TimeSpan.Zero;
    }
}
