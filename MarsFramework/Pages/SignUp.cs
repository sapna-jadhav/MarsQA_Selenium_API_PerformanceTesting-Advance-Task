using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsFramework.Pages
{
    class SignUp
    {
        public SignUp()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

		#region  Initialize Web Elements 
		//Click on Registration Button
		[FindsBy(How = How.XPath, Using = "//button[@class='ui green basic button']")]
		private IWebElement RegistrationButton { get; set; }
		//Finding the Join 
		[FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement Join { get; set; }

		//Enter the Title in textbox
		[FindsBy(How = How.Name, Using = "firstName")]
		private IWebElement FirstName { get; set; }
		//Enter the Title in textbox
		[FindsBy(How = How.Name, Using = "lastName")]
		private IWebElement LastName { get; set; }
		//Enter the Title in textbox
		[FindsBy(How = How.Name, Using = "email")]
		private IWebElement Email { get; set; }
		//Enter the Title in textbox
		[FindsBy(How = How.Name, Using = "password")]
		private IWebElement Password { get; set; }
		//Enter the Title in textbox
		[FindsBy(How = How.Name, Using = "confirmPassword")]
		private IWebElement ConfirmPassword { get; set; }
		//Enter the Title in textbox
		[FindsBy(How = How.Name, Using = "terms")]
		private IWebElement Terms { get; set; }
		[FindsBy(How = How.Id, Using = "submit-btn")]
		private IWebElement SubmitButton { get; set; }

		#endregion

		public  void register()
        {
            //Populate the excel data
        ExcelLib.PopulateInCollection(Base.ExcelPath, "SignUp");
			GlobalDefinitions.NavigateUrl();
			//Click on Join button
			Join.Click();

            //Enter FirstName
            FirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));

            //Enter LastName
            LastName.SendKeys(ExcelLib.ReadData(2, "LastName"));

            //Enter Email
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            //Enter Password
            Password.SendKeys(ExcelLib.ReadData(2, "Password"));

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(ExcelLib.ReadData(2, "ConfirmPswd"));

            //Click on Checkbox
            Terms.Click();

            //Click on join button to Sign Up
            SubmitButton.Click();


        }
    }
}
