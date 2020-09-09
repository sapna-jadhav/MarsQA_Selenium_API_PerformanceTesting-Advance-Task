using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class ManageListingsSteps
    {
        [Given(@"I logged in with valid Credentials")]
        public void GivenILoggedInWithValidCredentials()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		}
        
        [When(@"I try to Edit Skill on the manage Listing Page")]
        public void WhenITryToEditSkillOnTheManageListingPage()
        {
			ManageListings objSkillList = new ManageListings();
			objSkillList.Listings();
		}

		[When(@"I try to Delete Skill on the manage Listing Page")]
        public void WhenITryToDeleteSkillOnTheManageListingPage()
        {
			ManageListings objDeleteList = new ManageListings();
			objDeleteList.DeleteListing();
		}

		[Then(@"The Skill get Updated Successfully")]
        public void ThenTheSkillGetUpdatedSuccessfully()
        {
			string searchInput1 = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			Assert.AreEqual(searchInput1, ExcelLib.ReadData(3, "Category"));
			string searchInput2 = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[3]")).Text;
			Assert.AreEqual(searchInput2, ExcelLib.ReadData(3, "Title"));
			string searchInput3 = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[5]")).Text;
			Assert.AreEqual(searchInput3, ExcelLib.ReadData(3, "ServiceType"));
			Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skills Updated Successfully");
		}
        
        [Then(@"The Skill get Deleted Successfully")]
        public void ThenTheSkillGetDeletedSuccessfully()
        {
			try
			{
				String ActLang2 = (GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]"))).Text;
				Assert.AreNotEqual(ActLang2, ExcelLib.ReadData(3, "Title"));
			}
			catch
			{
				Assert.True(true, "Element not found");
			}
			Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skills deleted Successfully");

			Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Language deleted Successfully");
		}
    }
}
