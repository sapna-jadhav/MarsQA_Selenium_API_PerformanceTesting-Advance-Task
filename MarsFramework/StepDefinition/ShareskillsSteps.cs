using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class ShareskillsSteps
    {
        [Given(@"I have logged in and i try to add skill")]
        public void GivenIHaveLoggedInAndITryToAddSkill()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		}
        
        [When(@"I try to add and share skill in the listing")]
        public void WhenITryToAddAndShareSkillInTheListing()
        {
			ShareSkill objshareSkill = new ShareSkill();
			objshareSkill.EnterShareSkill();
		}

		[Then(@"Skill dhould gets added in the listings for sharing")]
        public void ThenSkillDhouldGetsAddedInTheListingsForSharing()
        {
			string searchInput1 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Programming & Tech')]")).Text;
			Console.WriteLine(searchInput1);
			Assert.AreEqual(searchInput1, ExcelLib.ReadData(2, "Category"));

			string searchInput2 = GlobalDefinitions.driver.FindElement(By.XPath("//table[@class='ui striped table']//tbody//tr[1]//td[3]")).Text;
			Console.WriteLine(searchInput2);
			Assert.AreEqual(searchInput2, ExcelLib.ReadData(2, "Title").TrimEnd());
			Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skill gets added in the Manage Listing");
		}
    }
}
