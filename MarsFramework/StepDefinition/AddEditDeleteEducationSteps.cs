using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class AddEditDeleteEducationSteps
    {
        [Given(@"I have logged in with username and pwd")]
        public void GivenIHaveLoggedInWithUsernameAndPwd()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		}
                       
        [When(@"I try to add Education details")]
        public void WhenITryToAddEducationDetails()
        {
			Skills objEducation = new Skills();
			objEducation.AddEducation();
		}

		[When(@"I try to Edit Education details")]
        public void WhenITryToEditEducationDetails()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
			Skills objEducation = new Skills();
			objEducation.EditEduaction();
		}
        
        [When(@"I try to delete Education details")]
        public void WhenITryToDeleteEducationDetails()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
			Skills objEducation = new Skills();
			objEducation.DeleteEducation();
		}
        
        [Then(@"A Education details gets added successfully")]
        public void ThenAEducationDetailsGetsAddedSuccessfully()
        {
			//Asserting the Language text
			String ExpectedLanguage = ExcelLib.ReadData(2, "College");
			String ActualLanguage = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'MIT')]")).Text;
			Assert.AreEqual(ActualLanguage, ExpectedLanguage);
			Console.WriteLine("Education" + " " + ActualLanguage + " " + "is added");
			GlobalDefinitions.Wait();
			String ExpectedLanguage1 = ExcelLib.ReadData(3, "College");
			String ActualLanguage1 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Raisoni')]")).Text;
			Assert.AreEqual(ActualLanguage1, ExpectedLanguage1);
			Console.WriteLine("Education" + " " + ActualLanguage1 + " " + "is added");
			GlobalDefinitions.Wait();
			String ExpectedLanguage2 = ExcelLib.ReadData(4, "College");
			String ActualLanguage2 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'IC')]")).Text;
			Assert.AreEqual(ActualLanguage2, ExpectedLanguage2);
			Console.WriteLine("Education" + " " + ActualLanguage2 + " " + "is added");

		}

		[Then(@"Education details gets Updated Successfully")]
        public void ThenEducationDetailsGetsUpdatedSuccessfully()
        {
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("updated"));
			Console.WriteLine(AlertText);
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Education Updated Successfully");
		}
        
        [Then(@"Education details gets deleted successfully")]
        public void ThenEducationDetailsGetsDeletedSuccessfully()
        {
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("removed"));
			Console.WriteLine(AlertText);
		}
    }
}
