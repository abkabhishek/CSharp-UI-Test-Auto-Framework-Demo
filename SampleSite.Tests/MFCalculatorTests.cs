using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleSite.Pages;

namespace SampleSite.Tests
{
    public class MFCalculatorTests
    {
        IWebDriver driver;
        App App;


        [SetUp]
        public void BeforeEach()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            App = new App(driver);

        }

        [TearDown]
        public void AfterEach()
        {
            driver.Quit();
            App = null;
        }

        [Test]
        public void Inflation_Calculator_is_on_MFCalulator_Page()
        {
            // Go to Mututalfundssahihai.com
            driver.Url = "https://www.mutualfundssahihai.com";

            // Open Hamburger menu
            // driver.FindElement(By.Id("toggle-icon")).Click();
            App.Home.Menu.GoToMFCaluclatorPage();

            // Click on Mutual Fund Calculator option
            // driver.FindElement(By.CssSelector(".mm-panels a[href='/en/calculators']")).Click();

            // Get Page Heading.
            // var MFPageHeading = driver.FindElement(By.CssSelector("h1.node__title>a>span"));
            var MFPageHeading = App.MFCalPage.Dom.MFPageHeading;
            Assert.AreEqual("Mutual Fund Calculators", MFPageHeading.Text);
        }
    }
}
/*
Site : https://www.mutualfundssahihai.com/en

HamburgerMenu = By ID ="toggle-icon"
MenuItemHome = By CSS =".mm-panels a[href='/en']"
MenuItemMFCalculator = By CSS =".mm-panels a[href='/en/calculators']"

MFCalPageHeading = By CSS = "h1.node__title>a>span"
InflationCalHeading = By CSS = "#inflation-calculator>div>h2"
SipCalHeading = By CSS = "#sip-calculator>div>h2"
GoalsipCalHead = By Css = "#goal-sip-calculator>div>h2"

*/
