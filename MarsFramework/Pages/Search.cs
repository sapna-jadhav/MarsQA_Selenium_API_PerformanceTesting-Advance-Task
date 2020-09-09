using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
	class Search
	{
		public Search()
		{

			PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

		}


		#region  Initialize Web Elements 
		//Click on Profile Name Icon
		[FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
		private IWebElement SearchIcon { get; set; }
		//Click on Profile Name Icon
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Search skills']")]
		private IWebElement TxtSearcSkill { get; set; }
		//Click on Profile Name Icon
		[FindsBy(How = How.XPath, Using = "//div[@class='four wide column']//input[@placeholder='Search skills']")]
		private IWebElement TxtSubCategory { get; set; }
		//Click on Profile Name Icon
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Search user']")]
		private IWebElement SearchUser { get; set; }
		[FindsBy(How = How.XPath, Using = "//button[contains(text(),'Onsite')]")]
		private IWebElement Onsite { get; set; }
		[FindsBy(How = How.XPath, Using = "//button[contains(text(),'Onsite')]")]
		private IWebElement Online { get; set; }
		[FindsBy(How = How.XPath, Using = "//button[contains(text(),'ShowAll')]")]
		private IWebElement ShowAll { get; set; }

		public void SearchSkill()
		{
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "SearchSkill");
			GlobalDefinitions.Wait();
			TxtSearcSkill.SendKeys(ExcelLib.ReadData(2, "Category"));
			SearchIcon.Click();
			//Checking the right page
			Assert.AreEqual("Search", GlobalDefinitions.driver.Title);
			Base.test = Base.extent.StartTest("On Share Search page");
			TxtSubCategory.SendKeys(ExcelLib.ReadData(2, "SubCategory"));
			SearchUser.SendKeys(ExcelLib.ReadData(2, "SearchUser"));
			IList<IWebElement> optionsToSelect = GlobalDefinitions.driver.FindElements(By.XPath("//input[@placeholder='Search user']"));

			foreach (IWebElement options in optionsToSelect)
			{
				Console.WriteLine(options);
				if (options.Text.Equals(SearchUser))
				{
					Console.WriteLine("Trying to select: " + SearchUser);
					options.Click();
					break;
				}
			}
			Onsite.Click();
			Online.Click();
			ShowAll.Click();

		}
	}
}


#endregion