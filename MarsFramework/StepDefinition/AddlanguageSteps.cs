using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class AddlanguageSteps
    {
        [Given(@"I logged in with valid credentails")]
        public void GivenILoggedInWithValidCredentails()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		}
        
        [When(@"I try to add new language on the profile page")]
        public void WhenITryToAddNewLanguageOnTheProfilePage()
        {
			Skills objLanguage = new Skills();
			objLanguage.AddLanguage();
			
		
		}

		[When(@"I try to Edit language Details")]
        public void WhenITryToEditLanguageDetails()
        {
			
			Skills objLanguage = new Skills();
			objLanguage.EditLanguage();
		}
        
        [When(@"I try to delete Seller language details")]
        public void WhenITryToDeleteSellerLanguageDetails()
        {
			Skills objLanguage = new Skills();
			objLanguage.DeleteLanguage();
		}
        
        [Then(@"A new language gets added successfully")]
        public void ThenANewLanguageGetsAddedSuccessfully()
        {
			//Asserting the Language text
			String ExpectedLanguage = ExcelLib.ReadData(2, "Language");
			String ActualLanguage = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[1]")).Text;
			Assert.AreEqual(ActualLanguage, ExpectedLanguage);
			Console.WriteLine("Language" + " " + ActualLanguage + " " + "is added");
			GlobalDefinitions.Wait();
			String ExpectedLanguage1 = ExcelLib.ReadData(3, "Language");
			String ActualLanguage1 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Hindi')]")).Text;
			Assert.AreEqual(ActualLanguage1, ExpectedLanguage1);
			Console.WriteLine("Language" + " " + ActualLanguage1 + " " + "is added");
			GlobalDefinitions.Wait();
			String ExpectedLanguage2 = ExcelLib.ReadData(4, "Language");
			String ActualLanguage2 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Chinese')]")).Text;
			Assert.AreEqual(ActualLanguage2, ExpectedLanguage2);
			Console.WriteLine("Language" + " " + ActualLanguage2 + " " + "is added");
			//Reading Language Level from Data excel sheet
			String languageLevelData = ExcelLib.ReadData(2, "ChooseLangLevel");


			//Asserting the Language level
			String ActualLevel = GlobalDefinitions.driver.FindElement(By.XPath("//tbody//tr[1]//td[2]")).Text;
			Assert.AreEqual(ActualLevel, languageLevelData);
			Console.WriteLine("Level" + " " + ActualLevel + " " + "is added");
			GlobalDefinitions.Wait();
			String languageLevelData1 = ExcelLib.ReadData(3, "ChooseLangLevel");
			String ActualLevel1 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Conversational')]")).Text;
			Assert.AreEqual(ActualLevel1, languageLevelData1);
			Console.WriteLine("Level" + " " + ActualLevel1 + " " + "is added");
			GlobalDefinitions.Wait();
			String languageLevelData2 = ExcelLib.ReadData(4, "ChooseLangLevel");
			String ActualLevel2 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Fluent')]")).Text;
			Assert.AreEqual(ActualLevel2, languageLevelData2);
			Console.WriteLine("Level" + " " + ActualLevel2 + " " + "is added");
			//Base.TearDown();
		}
        

        [Then(@"A Seller Language gets Updated Successfully")]
        public void ThenASellerLanguageGetsUpdatedSuccessfully()
        {
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("updated"));
			Console.WriteLine(AlertText);
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Language Updated Successfully");
		}
        
        [Then(@"The Seller language deatils gets deleted successfully")]
        public void ThenTheSellerLanguageDeatilsGetsDeletedSuccessfully()
        {
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("deleted"));
			Console.WriteLine(AlertText);
		
		}
		
	}
}
