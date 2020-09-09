using MarsFramework.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MarsFramework
{
    internal class Profile
    {

        public Profile()
        {

			PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

		}

		#region  Initialize Web Elements 
		//Click on Profile Name Icon
		[FindsBy(How = How.XPath, Using = "//div[@class='title']//i[@class='dropdown icon']")]
		private IWebElement EditProfileicon { get; set; }

		//Click on First Name to eidt
		[FindsBy(How = How.XPath, Using = "//input[@name='firstName']")]
		private IWebElement EditFirstName { get; set; }

		//Click on First Name to eidt
		[FindsBy(How = How.XPath, Using = "//input[@name='lastName']")]
		private IWebElement EditLasttName { get; set; }
		//Click on First Name to eidt
		[FindsBy(How = How.XPath, Using = "//button[@class='ui teal button']")]
		private IWebElement ProfileSaveBtn { get; set; }
		//Click on Edit button
		[FindsBy(How = How.XPath, Using = "//div[@class='four wide column']//div[2]//div[1]//span[1]//i[1]")]
        private IWebElement Availability { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }
		
		//Click on  Hour Tab
		[FindsBy(How = How.XPath, Using = "//div[@class='extra content']//div[3]//div[1]//span[1]//i[1]")]
        private IWebElement Hours { get; set; }

		//Click on Availability Hour dropdown
		[FindsBy(How = How.Name, Using = "availabiltyHour")]
		private IWebElement AvailabilityHour { get; set; }

		//Click on Earn Target Tab
		[FindsBy(How = How.XPath, Using = "//div[4]//div[1]//span[1]//i[1]")]
        private IWebElement EarnTarget { get; set; }

		//Click on salary
		[FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
		private IWebElement AvailabilityTarget { get; set; }

		//Click on Location
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }
		
		//Choose Location
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }
		//Click on Description
		[FindsBy(How = How.XPath, Using = "//h3[@class='ui dividing header']//i[@class='outline write icon']")]
		private IWebElement DescriptionBtn { get; set; }
		//Click on Description TextBox
		[FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
		private IWebElement TxtDescription { get; set; }
		//Click on Description Save Button
		[FindsBy(How = How.XPath, Using = "//div[@class='ui twelve wide column']//button[@class='ui teal button'][contains(text(),'Save')]")]
		private IWebElement DesSaveButton { get; set; }

		

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }



		internal void EditProfile()
		{
			//Populate the Excel Sheet
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
			GlobalDefinitions.Wait();
			EditProfileicon.Click();
			EditFirstName.Clear();
			EditFirstName.SendKeys(ExcelLib.ReadData(2, "FirstName"));
			EditLasttName.Clear();
			EditLasttName.SendKeys(ExcelLib.ReadData(2, "LastName"));
			ProfileSaveBtn.Click();
			GlobalDefinitions.driver.Navigate().Refresh();
			GlobalDefinitions.Wait();
			Availability.Click();
		 	AvailabilityTime.SendKeys(ExcelLib.ReadData(2, "Availability"));
			Hours.Click();
			AvailabilityHour.SendKeys(ExcelLib.ReadData(2, "SelectHours"));
			GlobalDefinitions.Wait();
			EarnTarget.Click();
			AvailabilityTarget.SendKeys(ExcelLib.ReadData(2, "EarnTraget"));
			GlobalDefinitions.Wait();
			DescriptionBtn.Click();
			TxtDescription.Clear();
			GlobalDefinitions.Wait();
			TxtDescription.SendKeys(ExcelLib.ReadData(2, "EditDesc"));
			DesSaveButton.Click();
		

        }
    }
}
#endregion