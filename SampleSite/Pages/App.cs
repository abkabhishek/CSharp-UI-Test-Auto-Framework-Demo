using OpenQA.Selenium;

namespace SampleSite.Pages
{

    public class App
    {
        public HomePage Home;
        public MFCalculatorPage MFCalPage;

        public App(IWebDriver driver)
        {
            Home = new HomePage(driver);
            MFCalPage = new MFCalculatorPage(driver);
        }
    }

}