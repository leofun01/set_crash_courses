using System;
using System.Linq;

using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

using Selenium1.Framework;

namespace Selenium1.PageObject
{
    public class AuthenticationPage : PageObjectBase
    {
        private static readonly By CreateEmailInput = By.Id("email_create");

        private static readonly By IsNewEmailOkDiv = By.XPath("//form[@id='create-account_form']//div[@class='form-group form-ok']");

        public AuthenticationPage(ISearchContext search) : base(search)
        { }

        public AuthenticationPage EnterNewAccountEmail(string email)
        {
            Search.FindElement(CreateEmailInput).Click();
            Search.FindElement(CreateEmailInput).Clear();
            Search.FindElement(CreateEmailInput).SendKeys(email);
            Search.FindElement(CreateEmailInput).SendKeys(Keys.Tab);
            return this;
        }

        public bool IsNewEmailOk()
        {
            WaitContext.Switch(Search.GetDriver());
            bool isOk = Wait.WaitFor(() => Search.FindElements(IsNewEmailOkDiv).Any());
            WaitContext.Switch(Search.GetDriver());
            return isOk;
        }
    }
}
