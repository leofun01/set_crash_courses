using System;
using System.Collections.Generic;

using OpenQA.Selenium;

namespace Selenium1.Framework.WaitStrategy
{
    public class WaitContext
    {
        private readonly Dictionary<WaitStrategy, IWaitStrategy> strategyPool;

        private WaitStrategy currentStrategy;

        public WaitContext(IWebDriver driver, WaitStrategy strategy)
        {
            currentStrategy = strategy;
            strategyPool = new Dictionary<WaitStrategy, IWaitStrategy>(2)
            {
                {currentStrategy, GetStrategy(currentStrategy)}
            };

            strategyPool[currentStrategy].SetWaitStrategy(driver);
        }

        public void Switch(IWebDriver driver)
        {
            switch (currentStrategy)
            {
                case WaitStrategy.Implicit:
                    currentStrategy = WaitStrategy.Explicit;
                    if (!strategyPool.ContainsKey(currentStrategy))
                        strategyPool.Add(currentStrategy, GetStrategy(currentStrategy));
                    break;
                case WaitStrategy.Explicit:
                    currentStrategy = WaitStrategy.Implicit;
                    if (!strategyPool.ContainsKey(currentStrategy))
                        strategyPool.Add(currentStrategy, GetStrategy(currentStrategy));
                    break;
                default:
                    throw new NotImplementedException();
            }

            strategyPool[currentStrategy].SetWaitStrategy(driver);
        }

        private static IWaitStrategy GetStrategy(WaitStrategy strategy)
        {
            switch (strategy)
            {
                case WaitStrategy.Implicit:
                    return new ImplicitWaitStrategy();
                case WaitStrategy.Explicit:
                    return new ExplicitWaitStrategy();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
