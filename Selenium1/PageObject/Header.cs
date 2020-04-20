using OpenQA.Selenium;

namespace Selenium1.PageObject
{
    public class Header : PageObjectBase
    {
        private static readonly By LoginButton = By.ClassName("login");
        private static readonly By CreateSearchInput = By.Id("search_query_top");
        private static readonly By SearchLine = By.Id("search_query_top");

        public Header(ISearchContext search) : base(search)
        { }

        public AuthenticationPage ClickOnSingIn()
        {
            Search.FindElement(LoginButton).Click();
            return new AuthenticationPage(Search);
        }

        public Header ClickOnSearch()
        {
            Search.FindElement(SearchLine).Click();
            return this;
        }

        public SearchPage EnterSearch(string text)
        {
            Search.FindElement(CreateSearchInput).SendKeys(text);
            Search.FindElement(CreateSearchInput).SendKeys(Keys.Enter);
            Search.FindElement(CreateSearchInput).Clear();
            return new SearchPage(Search);
        }
    }
}
