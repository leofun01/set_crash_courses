using NUnit.Framework;

using Selenium1.Framework.Categories;
using Selenium1.PageObject;

namespace Selenium1.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class EmailValidationTest : BaseTest
    {
        private Header header;

        [OneTimeSetUp]
        public void OneTimeSetUp() => header = new Header(Driver);

        [TestCase(true, "test@domain.set")]
        [TestCase(false, "(test@domainset")]
        [EmailValidationTests]
        public void ValidateEmail(bool isPositive, string email)
        {
            AuthenticationPage authenticationPage = header.ClickOnSingIn();
            bool isEmailOk = authenticationPage.EnterNewAccountEmail(email).IsNewEmailOk();
            Assert.That(isEmailOk, Is.EqualTo(isPositive), $"Email was validated {(isEmailOk ? "successfully" : "unsuccessfully")}"
                                                           + " but were expected opposite");
        }
    }
}
