using OpenQA.Selenium;

namespace SampleSite.Pages
{

    public abstract class BasePage
    {
        public readonly HamBurgerMenu Menu;

        public BasePage(IWebDriver driver)
        {
            Menu = new HamBurgerMenu(driver);
        }



    }
}