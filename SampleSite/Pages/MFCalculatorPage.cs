using OpenQA.Selenium;

namespace SampleSite.Pages
{
    public class MFCalculatorPage : BasePage
    {
        public readonly MFCalculatorPageDom Dom;


        public MFCalculatorPage(IWebDriver driver) : base(driver)
        {
            Dom = new MFCalculatorPageDom(driver);
        }






    }

    public class MFCalculatorPageDom
    {
        IWebDriver _driver;

        public MFCalculatorPageDom(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement MFPageHeading => _driver.FindElement(By.CssSelector("h1.node__title>a>span"));
        public IWebElement InflationCalHeading => _driver.FindElement(By.CssSelector("#inflation-calculator>div>h2"));
        public IWebElement SipCalHeading => _driver.FindElement(By.CssSelector("#sip-calculator>div>h2"));
        public IWebElement GoalsipCalHead => _driver.FindElement(By.CssSelector("#goal-sip-calculator>div>h2"));

    }
}