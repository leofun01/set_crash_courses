using System;

using OpenQA.Selenium;
using OpenQA.Selenium.Internal;

namespace Selenium1.Framework
{
    public static class SeleniumExtensions
    {
        public static IWebDriver GetDriver(this ISearchContext context)
        {
            switch (context)
            {
                case IWebDriver driver:
                    return driver;
                case IWrapsDriver element:
                    return element.WrappedDriver;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
