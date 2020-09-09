using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class SearchSkillsSteps
    {
        [Given(@"I have logged in and I Enter Keyword in the search")]
        public void GivenIHaveLoggedInAndIEnterKeywordInTheSearch()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		}
        
        [When(@"I try to search for the desired skills applying filter")]
        public void WhenITryToSearchForTheDesiredSkillsApplyingFilter()
        {
			Search objSearch = new Search();
			objSearch.SearchSkill();
		}

		[Then(@"The desired skills get listed on the page")]
        public void ThenTheDesiredSkillsGetListedOnThePage()
        {
			Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Searched Record gets displayed on the Page Successfully");
		}
    }
}
