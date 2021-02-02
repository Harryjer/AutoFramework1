namespace AutoFramework1.Pages
{
    using SeleniumExtras.PageObjects;

    public class SpecialElementsPage
    {
        public SpecialElementsPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

    }
}
