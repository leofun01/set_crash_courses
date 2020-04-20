using System.Linq;

using OpenQA.Selenium;

using Selenium1.Framework;

namespace Selenium1.PageObject
{
    public class SearchPage : PageObjectBase
    {
        private static readonly By IsSearch = By.CssSelector("p.alert-warning");

        public SearchPage(ISearchContext search) : base(search)
        { }

        public bool IsSearchOk()
        {
            WaitContext.Switch(Search.GetDriver());
            bool isOk = Wait.WaitFor(() => Search.FindElements(IsSearch).Any());
            WaitContext.Switch(Search.GetDriver());
            return !isOk;
        }
    }
}
