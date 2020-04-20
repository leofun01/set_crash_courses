using System;

using NUnit.Framework;

namespace Selenium1.Framework.Categories
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class SearchTests : CategoryAttribute
    { }
}
