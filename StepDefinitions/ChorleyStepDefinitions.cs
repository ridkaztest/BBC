using BBCProject.Hooks;
using BBCProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.BindingSkeletons;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class ChorleyStepDefinitions
    {
        public IWebDriver Driver = BaseTest.driver;
        ChorleyPage chorleyPage = new ChorleyPage();

        [Given(@"I navigate to BBC news Url ""([^""]*)""")]
        public void GivenINavigateToBBCNewsUrl(string url)
        {
           chorleyPage.NavigateToUrl(url);
        }

        [Given(@"I click on search BBC icon")]
        public void GivenIClickOnSearchBBCIcon()
        {
            chorleyPage.ClickSearchIcon();     
        }

        [Given(@"I enter ""([^""]*)"" in the search icon")]
        public void GivenIEnterInTheSearchIcon(string chorley)
        {
            chorleyPage.EnterChorley(chorley);
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            chorleyPage.ClickSearchButton();
        }

        [Then(@"I should see the search results")]
        public void ThenIShouldSeeTheSearchResults()
        {
            Assert.IsTrue(Driver.Title.Contains("Chorley"));
        }

        [Then(@"I should see a list of articles containing ""([^""]*)"" in the first five of the results displayed")]
        public void ThenIShouldSeeAListOfArticlesContainingInTheFirstFiveOfTheResultsDisplayed(string chorley)
        {
            var searchResults = chorleyPage.GetSearchResults();

            for (int i = 0; i < System.Math.Min(5, searchResults.Count); i++)
            {
                var resultText = searchResults[i].Text;
                Assert.That(resultText, Does.Contain(chorley).IgnoreCase, $"Result {i + 1} does not contain '{chorley}'");
            }
        }
    }
}
        
    

