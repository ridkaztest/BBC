using BBCProject.Hooks;
using BBCProject.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class IsraelStepDefinitions
    {
        public IWebDriver Driver = BaseTest.driver;
        IsraelPage israelPage = new IsraelPage();



        [Given(@"I click on ""([^""]*)"" icon under news section")]
        public void GivenIClickOnIconUnderNewsSection(string p0)
        {
            israelPage.ClickOnIsraelGazaIcon();
        }

        [When(@"I scroll down to the Analysis section")]
        public void WhenIScrollDownToTheAnalysisSection()
        {
            israelPage.ScrollToAnalysisSection();
        }

        [When(@"I click on ""([^""]*)""")]
        public void WhenIClickOn(string p0)
        {
            israelPage.ClickInvasionIcon();
        }

        [Then(@"I should be able to see the article")]
        public void ThenIShouldBeAbleToSeeTheArticle()
        {
            israelPage.IsArticleVisible().Should().BeTrue();    
        }
    }
}
