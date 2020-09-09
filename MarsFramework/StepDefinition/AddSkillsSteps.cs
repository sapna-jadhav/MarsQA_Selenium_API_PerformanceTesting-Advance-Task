using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class AddSkillsSteps
    {
        [Given(@"I  logged in with valid credentials and navigate to profile page")]
        public void GivenILoggedInWithValidCredentialsAndNavigateToProfilePage()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		
		}
        
        
        [When(@"I try to add Skill Details")]
        public void WhenITryToAddSkillDetails()
        {
			Skills objskill = new Skills();
			objskill.AddSkills();
		}
        
        [When(@"I try to Edit Skill Details")]
        public void WhenITryToEditSkillDetails()
        {
			Skills objskill = new Skills();
			objskill.EditSkills();
		}
        
        [When(@"I try to delete Skill Details")]
        public void WhenITryToDeleteSkillDetails()
        {
			Skills objskill = new Skills();
			objskill.DeleteSkills();
		}
        
        [Then(@"A Skill Details gets added Successfully")]
        public void ThenASkillDetailsGetsAddedSuccessfully()
        {
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
			//Asserting the Language text

			String ActualSkill = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'C#')]")).Text;
			Assert.AreEqual(ActualSkill, ExcelLib.ReadData(2, "Skill"));
			Console.WriteLine("Skill" + " " + ActualSkill + " " + "is added");
			GlobalDefinitions.Wait();
			
			String ActualSkill1 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'POM')]")).Text;
			Assert.AreEqual(ActualSkill1, ExcelLib.ReadData(3, "Skill"));
			Console.WriteLine("Skill" + " " + ActualSkill1 + " " + "is added");
			GlobalDefinitions.Wait();
			
			String ActualSkill2 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Nunit')]")).Text;
			Assert.AreEqual(ActualSkill2, ExcelLib.ReadData(4, "Skill"));
			Console.WriteLine("Skill" + " " + ActualSkill2 + " " + "is added");
			//Reading Language Level from Data excel sheet
			 


			//Asserting the Skill level
			String ActualLevel = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Intermediate')]")).Text;
			Assert.AreEqual(ActualLevel, ExcelLib.ReadData(2, "ChooseSkillLevel"));
			Console.WriteLine("Level" + " " + ActualLevel + " " + "is added");
			GlobalDefinitions.Wait();
			
			String ActualLevel1 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Expert')]")).Text;
			Assert.AreEqual(ActualLevel1, ExcelLib.ReadData(3, "ChooseSkillLevel"));
			Console.WriteLine("Level" + " " + ActualLevel1 + " " + "is added");
			GlobalDefinitions.Wait();
			
			String ActualLevel2 = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'Expert')]")).Text;
			Assert.AreEqual(ActualLevel2, ExcelLib.ReadData(4, "ChooseSkillLevel"));
			Console.WriteLine("Level" + " " + ActualLevel2 + " " + "is added");
			//Base.TearDown();
		}
        
        [Then(@"Skill Details gets Updated Successfully")]
        public void ThenSkillDetailsGetsUpdatedSuccessfully()
        {
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skill Updated Successfully");
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("updated"));
			Console.WriteLine(AlertText);
			//Base.TearDown();

		}
        
        [Then(@"Skill Details gets deleted successfully")]
        public void ThenSkillDetailsGetsDeletedSuccessfully()
        {
			
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("deleted"));
			Console.WriteLine(AlertText);
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Adding is successful");
			//GlobalDefinitions.Wait();
			//Base.TearDown();

		}
    }
}
