using OpenQA.Selenium;

namespace SampleSite.Pages
{

    public class HomePage : BasePage
    {
        public readonly HomePageDom Dom;

        public HomePage(IWebDriver driver) : base(driver)
        {
            Dom = new HomePageDom(driver);
        }
    }


    public class HomePageDom
    {
        IWebDriver _driver;

        public HomePageDom(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}