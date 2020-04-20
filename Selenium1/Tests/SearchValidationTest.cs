using NUnit.Framework;

using Selenium1.Framework.Categories;
using Selenium1.PageObject;

namespace Selenium1.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [SearchTests]
    public class SearchValidationTest : BaseTest
    {
        private Header mainPage;

        [OneTimeSetUp]
        public void OneTimeSetUp() => mainPage = new Header(Driver);

        [TestCase(false, "Blouce")]
        [TestCase(true, "Blouse")]
        public void Test(bool isPositive, string text)
        {
            bool isOk = mainPage.ClickOnSearch().EnterSearch(text).IsSearchOk();
            Assert.That(isOk, Is.EqualTo(isPositive),
                        $"Search was validated{(isOk ? "successfully" : "unsuccessfully")}");
        }
    }
}
