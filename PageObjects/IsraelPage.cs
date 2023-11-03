using BBCProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObjects
{
    public class IsraelPage
    {
        private IWebDriver driver;
        public IsraelPage()
        {
            driver = BaseTest.driver;
        }

        private By israelGazaIcon = By.CssSelector("#orb-modules > header > div:nth-child(2) > div:nth-child(1) > div.gs-u-display-none.gs-u-display-block\\@m.nw-o-news-wide-navigation > nav > ul > li:nth-child(2)");
        private By analysisSection = By.CssSelector("#main-content > div:nth-child(5) > div > div > div > div > div > div > h2");
        private By invasionIcon = By.CssSelector("#main-content > div:nth-child(5) > div > div > ul > li.ssrcss-1r7nvnf-ListItem.edq0yjy0 > div > div > div > div.ssrcss-tq7xfh-PromoContent.exn3ah99 > div.ssrcss-1f3bvyz-Stack.e1y4nx260 > a");
        private By article = By.CssSelector("#main-heading");

        public void ClickOnIsraelGazaIcon()
        {
            driver.FindElement(israelGazaIcon).Click();
        }

        public void ScrollToAnalysisSection()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", driver.FindElement(analysisSection));
        }
        public void ClickInvasionIcon()
        {
            driver.FindElement(invasionIcon).Click();
        }
        public bool IsArticleVisible()
        {
            return driver.FindElement(article).Displayed;
        }
       
    }
}   