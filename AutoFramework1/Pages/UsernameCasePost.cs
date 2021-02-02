

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoFramework1.Pages
{
    class UsernameCasePost
    {
        public UsernameCasePost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }
    }
}
