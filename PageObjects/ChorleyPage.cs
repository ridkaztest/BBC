using BBCProject.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
    
    public class ChorleyPage
    {
        private IWebDriver driver;
        public ChorleyPage()
        {
            driver = BaseTest.driver;
        }

        private By searchIcon = By.CssSelector("#orbit-search-button > span.ux-v5 > span");
        private By enterChorley = By.CssSelector("#searchInput");
        private By searchButton = By.CssSelector("#searchButton");
        
        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickSearchIcon()
        {
            driver.FindElement(searchIcon).Click();
        }

        public void EnterChorley(string searchText)
        {
            driver.FindElement(enterChorley).SendKeys(searchText);
        }

        public void ClickSearchButton()
        {
            driver.FindElement(searchButton).Click();
        }

        public bool AreSearchResultsVisible()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".search-results"))) != null;
        }

        public IList<IWebElement> GetSearchResults()
        {
            return driver.FindElements(By.TagName("q"));
        }
    }
}

