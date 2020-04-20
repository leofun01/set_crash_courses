using OpenQA.Selenium;

namespace Selenium1.Framework.WaitStrategy
{
    public class ImplicitWaitStrategy : IWaitStrategy
    {
        public void SetWaitStrategy(IWebDriver driver) => driver.Manage().Timeouts().ImplicitWait = Settings.ImplicitWait;
    }
}
