using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TestTechnique.Pages;

namespace TestTechnique.Steps
{
    [Binding]
    public sealed class TestSteps
    {
        [Given(@"I have entered '(.*)' in (.*) field")]
        public void GivenIHaveEnteredInField(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the AsseTNamE(.*) added :")]
        public void ThenIShouldSeeTheAsseTNamEAdded(Decimal p0, Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I added '(.*)'")]
        public void GivenIAdded(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I do add '(.*)' in (.*) field")]
        public void WhenIDoAddInField(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I do add")]
        public void WhenIDoAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see the following Message '(.*)'")]
        public void ThenISeeTheFollowingMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I entered AssetName")]
        public void GivenIEnteredAssetName()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I submit")]
        public void WhenISubmit()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The page displays '(.*)'")]
        public void ThenThePageDisplays(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I entered AsseTNamE(.*) in (.*) field")]
        public void GivenIEnteredAsseTNamEInField(Decimal p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The page displays the following :")]
        public void ThenThePageDisplaysTheFollowing(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I entered '(.*)' in the search box")]
        public void GivenIEnteredInTheSearchBox(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"'(.*)' is an existing Assetname")]
        public void GivenIsAnExistingAssetname(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I hit enter")]
        public void WhenIHitEnter()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"The AssetTable page is open")]
        public void GivenTheAssetTablePageIsOpen()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The page displays a sort button")]
        public void ThenThePageDisplaysASortButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The page displays a Filter button")]
        public void ThenThePageDisplaysAFilterButton()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I sort by AssetName")]
        public void WhenISortByAssetName()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The page displays the assetnames ordered alphabetically")]
        public void ThenThePageDisplaysTheAssetnamesOrderedAlphabetically()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I filter by AssetName")]
        public void WhenIFilterByAssetName()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The page displays assetnames only")]
        public void ThenThePageDisplaysAssetnamesOnly()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
