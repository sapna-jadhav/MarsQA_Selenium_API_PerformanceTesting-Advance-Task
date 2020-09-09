using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class ProfileSteps
    {
        [Given(@"I logge in and i am on the profile page")]
        public void GivenILoggeInAndIAmOnTheProfilePage()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		}
        
        [When(@"I try to Updated Profile")]
        public void WhenITryToUpdatedProfile()
        {
			Profile ObjProfile = new Profile();
			ObjProfile.EditProfile();
		}

		[Then(@"The Profile details get Updated")]
        public void ThenTheProfileDetailsGetUpdated()
        {
			//string searchInput = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[1]")).Text;
			//Assert.AreEqual(searchInput, ExcelLib.ReadData(2, "FirstName"));
			//string searchLevel = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			//Assert.AreEqual(searchLevel, ExcelLib.ReadData(2, "LastName"));
			//string searchAvail = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			//Assert.AreEqual(searchAvail, ExcelLib.ReadData(2, "Availability"));
			//string searchHours = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			//Assert.AreEqual(searchHours, ExcelLib.ReadData(2, "Hours"));
			//string searchEarn = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			//Assert.AreEqual(searchEarn, ExcelLib.ReadData(2, "EarnTraget"));
			//string searchDescr = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			//Assert.AreEqual(searchDescr, ExcelLib.ReadData(2, "Desc"));
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Profile/Earn Traget/Hours/Description added Successfully");
		}
    }
}
