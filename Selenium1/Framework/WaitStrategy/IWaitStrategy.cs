using OpenQA.Selenium;

namespace Selenium1.Framework.WaitStrategy
{
    public interface IWaitStrategy
    {
        void SetWaitStrategy(IWebDriver driver);
    }
}
