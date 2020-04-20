using System;

using NUnit.Framework;

namespace Selenium1.Framework
{
    public static class Settings
    {
        public static readonly string Url = TestContext.Parameters["Url"] ?? "http://automationpractice.com/index.php";

        public static readonly Drivers Driver = (Drivers) Enum.Parse(typeof(Drivers), TestContext.Parameters["Driver"] ?? "Chrome");

        public static readonly TimeSpan ImplicitWait = TimeSpan
            .FromMilliseconds(Convert.ToInt32(TestContext.Parameters["WaitTime"] ?? "3000"));
    }
}
