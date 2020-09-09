using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.StepDefinition
{
    [Binding]
    public class AddEditDeleteCertificateSteps
    {
        [Given(@"I  logged in with valid credentials")]
        public void GivenILoggedInWithValidCredentials()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
		}
                        
        [When(@"I try to add Certificate Details")]
        public void WhenITryToAddCertificateDetails()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
			Skills objCertificate = new Skills();
			objCertificate.AddCertificate();
		}
        
        [When(@"I try to Edit Certificate Details")]
        public void WhenITryToEditCertificateDetails()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
			Skills objCertificate = new Skills();
			objCertificate.EditCertificate();
		}
        
        [When(@"I try to delete Certificate Details")]
        public void WhenITryToDeleteCertificateDetails()
        {
			SignIn Login = new SignIn();
			Login.LoginSteps();
			Skills objCertificate = new Skills();
			objCertificate.DeleteCertificate();
		}
        
        [Then(@"A Certificate Details gets added Successfully")]
        public void ThenACertificateDetailsGetsAddedSuccessfully()
        {
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("added"));
			Console.WriteLine(AlertText);
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Skills deleted successfully");
		}
        
        [Then(@"Certificate Details gets Updated Successfully")]
        public void ThenCertificateDetailsGetsUpdatedSuccessfully()
        {
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("updated"));
			Console.WriteLine(AlertText);
		}
        
        [Then(@"Certificate Details gets deleted successfully")]
        public void ThenCertificateDetailsGetsDeletedSuccessfully()
        {
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("deleted"));
			Console.WriteLine(AlertText);
		}
    }
}
