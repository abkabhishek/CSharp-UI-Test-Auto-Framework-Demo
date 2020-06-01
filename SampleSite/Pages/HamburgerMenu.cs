using System;
using OpenQA.Selenium;

namespace SampleSite.Pages
{
    public class HamBurgerMenu
    {
        public readonly HamBurgerMenuDom Dom;

        public HamBurgerMenu(IWebDriver driver)
        {
            Dom = new HamBurgerMenuDom(driver);
            
        }

        public void ClickHamBurgerMenu()
        {
            Dom.HamBurgerMenu.Click();

        }


        public void GoToMFCaluclatorPage()
        {
            Dom.HamBurgerMenu.Click();
            GetMenuOptionByName("calculators").Click();
        }

        public void ClickMenuItemByOption(string name)
        {   
            IWebElement MenuItem = GetMenuOptionByName(name);
            if (MenuItem!=null)
            {
                MenuItem.Click();
            }
        }

        public IWebElement GetMenuOptionByName(string optionName)
        {   
            optionName = optionName.ToLower();

            if (optionName.Contains(" "))
            {
                optionName = optionName.Replace(" ","-").ToLower();
            }
            if (optionName.Equals("home"))
            {
                optionName = "";
            }else
            {
                optionName = "/" + optionName;
            }
            return Dom.MenuItem(optionName);
        }

    }


    public class HamBurgerMenuDom
    {
        IWebDriver _driver;

        public HamBurgerMenuDom(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement HamBurgerMenu => _driver.FindElement(By.Id("toggle-icon"));
        public IWebElement MenuItem(string option) => _driver.FindElement(By.CssSelector($".mm-panels a[href='/en{option}']"));
    }
}
