using OpenQA.Selenium;

using Selenium1.Framework;
using Selenium1.Framework.WaitStrategy;

namespace Selenium1.PageObject
{
    public abstract class PageObjectBase
    {
        protected readonly ISearchContext Search;

        protected readonly WaitContext WaitContext;

        protected PageObjectBase(ISearchContext search)
        {
            Search = search;
            WaitContext = new WaitContext(Search.GetDriver(), WaitStrategy.Implicit);
        }
    }
}
