using MarsFramework.Config;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
	class Skills
	{
		public Skills()
		{

			PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

		}

		#region  Initialize Web Elements 
		//Click on Add new to add new Language
		[FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
		private IWebElement AddNewLangBtn { get; set; }

		//Enter the Language on text box
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
		private IWebElement AddLangText { get; set; }

		//Enter the Language on text box
		[FindsBy(How = How.Name, Using = "level")]
		private IWebElement ChooseLang { get; set; }

		//Enter the Language on text box
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
		private IWebElement ChooseLangOpt { get; set; }

		//Add Language
		[FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
		private IWebElement AddLang { get; set; }

		[FindsBy(How = How.XPath, Using = "//tbody[1]//tr[1]//td[3]//span[1]//i[1]")]
		private IWebElement EditLang { get; set; }

		[FindsBy(How = How.XPath, Using = "//tbody[1]//tr[1]//td[3]//span[2]")]
		private IWebElement DeleteLang { get; set; }
		//tbody[2]//tr[1]//td[3]//span[2]//i[1]
		//tbody[1]//tr[1]//td[3]//span[2]//i[1]

		//Click on skill Tab
		[FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skills')]")]
		private IWebElement SkillLink { get; set; }

		//Click on Add new to add new skill
		[FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
		private IWebElement AddNewSkillBtn { get; set; }
		//a[contains(text(),'Skills')]


		//Enter the Skill on text box
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
		private IWebElement AddSkillText { get; set; }

		//Click on skill level dropdown
		[FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//select[@name='level']")]
		private IWebElement ChooseSkill { get; set; }

		//Choose the skill level option
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
		private IWebElement ChooseSkilllevel { get; set; }

		//Add Skill
		[FindsBy(How = How.XPath, Using = "//input[contains(@class,'ui teal button')]")]
		private IWebElement AddSkill { get; set; }

		[FindsBy(How = How.XPath, Using = "//tbody[2]//tr[1]//td[3]//span[1]//i[1]")]
		private IWebElement EditSkill { get; set; }

		[FindsBy(How = How.XPath, Using = "	//div[@class='fields']//input[@class='ui teal button']")]
		private IWebElement UpdateSkill { get; set; }


		[FindsBy(How = How.XPath, Using = "//tbody[1]//tr[1]//td[3]//span[2]//i[1]")]
		private IWebElement DeleteSkill { get; set; }


		//Click Education Link
		[FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(text(),'Education')]")]
		private IWebElement EducationLink { get; set; }

		//Click on Add new to Educaiton
		[FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
		private IWebElement AddNewEducation { get; set; }

		//Enter university in the text box
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")]
		private IWebElement EnterUniversity { get; set; }

		//Choose the country
		[FindsBy(How = How.XPath, Using = "//select[@name='country']")]
		private IWebElement ChooseCountry { get; set; }

		//Choose the skill level option
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
		private IWebElement ChooseCountryOpt { get; set; }

		//Click on Title dropdown
		[FindsBy(How = How.XPath, Using = "//select[@name='title']")]
		private IWebElement ChooseTitle { get; set; }


		//Choose title
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
		private IWebElement ChooseTitleOpt { get; set; }

		//Degree
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")]
		private IWebElement EduDegree { get; set; }

		//Year of graduation
		[FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
		private IWebElement DegreeYear { get; set; }

		//Choose Year
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
		private IWebElement DegreeYearOpt { get; set; }

		//Click on Add
		[FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide field']//input[contains(@class,'ui teal button')]")]
		private IWebElement AddEdu { get; set; }


		//Click on Edit Education
		[FindsBy(How = How.XPath, Using = "//td[@class='right aligned']//i[@class='outline write icon']")]
		private IWebElement EditEdu { get; set; }

		//Click on Update Education
		[FindsBy(How = How.XPath, Using = "//div[@class='sixteen wide field']//input[@class='ui teal button']")]
		private IWebElement UpdateEdu { get; set; }

		//Click on Delete Education
		[FindsBy(How = How.XPath, Using = "//tbody[1]//tr[1]//td[6]//span[2]//i[1]")]
		private IWebElement DeleteEdu { get; set; }

		//Click On Education Tab
		[FindsBy(How = How.XPath, Using = "//a[contains(text(),'Certifications')]")]
		private IWebElement CertificateLink { get; set; }


		//Add new Certificate
		[FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
		private IWebElement AddNewCerti { get; set; }

		//Enter Certification Name
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
		private IWebElement EnterCerti { get; set; }

		//Certified from
		[FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
		private IWebElement CertiFrom { get; set; }

		//Year
		[FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
		private IWebElement CertiYear { get; set; }

		//Choose Opt from Year
		[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
		private IWebElement CertiYearOpt { get; set; }

		//Add Ceritification
		[FindsBy(How = How.XPath, Using = "//div[@class='five wide field']//input[contains(@class,'ui teal button')]")]
		private IWebElement AddCertiBtn { get; set; }
		//Edit Ceritification
		[FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='outline write icon']")]
		private IWebElement EditCerti { get; set; }
		//Update Ceritification
		[FindsBy(How = How.XPath, Using = "//table[@class='ui fixed table']//div[@class='row']//input[@class='ui teal button']")]
		private IWebElement UpdateCerti { get; set; }
		//Delete Ceritification
		[FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//i[@class='remove icon']")]
		private IWebElement DeleteCerti { get; set; }

	
		public static int rowNum = Int32.Parse(MarsResource.RowCount);

		

		public void AddLanguage()
		{
			//Populate the Excel Sheet
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
			GlobalDefinitions.Wait();


			//loop for multiple properties getting added at single shot
			int loopNum = Base.RowCount + 2;

			for (int rowNum = 2; rowNum <= loopNum; rowNum++)
			{

				GlobalDefinitions.Wait();
				AddNewLangBtn.Click();
				AddLangText.SendKeys(ExcelLib.ReadData(rowNum, "Language"));

				//ChooseLang.SendKeys(ExcelLib.ReadData(2, "ChooseLangLevel"));
				ChooseLang.Click();


				//Selecting the language level
				IWebElement LanguageLevelDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='level']"));
				SelectElement chooseLanguageLevel = new SelectElement(LanguageLevelDrpdwn);
				//select.SelectByText(ConstantHelpers.LevelFluent);
				var languageLevelData = ExcelLib.ReadData(rowNum, "ChooseLangLevel");
				chooseLanguageLevel.SelectByValue(languageLevelData);

				AddLang.Click();

			}
				Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Languages added successfully");

		
			
			
		}

		public void EditLanguage()
		{
			{
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
			GlobalDefinitions.Wait();//for editing skill details
			EditLang.Click();
			AddLangText.Clear();
			AddLangText.SendKeys(ExcelLib.ReadData(7, "Language"));

			//Selecting the language level
			IWebElement LanguageLevelDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='level']"));
			SelectElement chooseLanguageLevel = new SelectElement(LanguageLevelDrpdwn);
			//select.SelectByText(ConstantHelpers.LevelFluent);
			var languageLevelData = ExcelLib.ReadData(2, "ChooseLangLevel");
			chooseLanguageLevel.SelectByValue(languageLevelData);
			AddLang.Click();
		}
			
		}

		internal void DeleteLanguage()
		{
			//for deleting skill details
			GlobalDefinitions.Wait();

			DeleteLang.Click();
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("deleted"));
			Console.WriteLine(AlertText);
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Language deleted successfully");
			
		}

		public  void AddSkills()
		{
			//Populate the Excel Sheet
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
			GlobalDefinitions.Wait();
			SkillLink.Click();

			//loop for multiple properties getting added at single shot
			int loopNum = Base.RowCount + 2;

			for (int rowNum = 2; rowNum <= loopNum; rowNum++)
			{

				GlobalDefinitions.Wait();
				AddNewSkillBtn.Click();
				AddSkillText.SendKeys(ExcelLib.ReadData(rowNum, "Skill"));

				//ChooseLang.SendKeys(ExcelLib.ReadData(2, "ChooseLangLevel"));
				ChooseSkill.Click();
				IWebElement SkillLevelDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//select[@name='level']"));
				SelectElement chooseSkillLevel = new SelectElement(SkillLevelDrpdwn);
				//select.SelectByText(ConstantHelpers.LevelFluent);
				var SkillLevelData = ExcelLib.ReadData(rowNum, "ChooseSkillLevel");
				chooseSkillLevel.SelectByValue(SkillLevelData);

				AddSkill.Click();
				//GlobalDefinitions.Wait();

			}
			//saving screenshot
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Adding is successful");
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skills added successfully");
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
			
		}
		public  void EditSkills()
		{


			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");

			GlobalDefinitions.Wait();
			SkillLink.Click();

			//This list gets the number of rows from the table
			//IList<IWebElement> rows = GlobalDefinitions.driver.FindElements(By.XPath(".//tr"));

			//This loop finds the first row which' title matches sRowValue
			IList<IWebElement> rows = GlobalDefinitions.driver.FindElements(By.XPath(".//tr"));

			//This loop finds the first row which' title matches sRowValue
			for (int i = 1; i < rows.Count; i++)
			{
				String sValue = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'C#')]")).Text;
				if (sValue == ExcelLib.ReadData(2, "Skill")) 
				{
					IWebElement Edit = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//tbody[1]//tr[1]//td[3]//span[1]//i[1]"));
					Edit.Click();
					AddSkillText.Clear();
					AddSkillText.SendKeys(ExcelLib.ReadData(7, "Skill"));
					UpdateSkill.Click();
					break;

				}
			}		
			GlobalDefinitions.Wait();
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("updated"));
			Console.WriteLine(AlertText);
			//saving screenshot
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Edit is successful");

		}

		public void DeleteSkills()
		{
			GlobalDefinitions.Wait();
			SkillLink.Click();
			IWebElement Delete = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//tbody[1]//tr[1]//td[3]//span[2]"));
			Delete.Click();
			//for deleting skill details
			
			IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = AddAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("deleted"));
			Console.WriteLine(AlertText);
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skills deleted successfully");
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Skills deleted successfully");
		}
		public void AddEducation()
		{
			//Populate the Excel Sheet
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
			GlobalDefinitions.Wait();
			EducationLink.Click();

			//loop for multiple data getting added at single shot
			int loopNum = Base.RowCount + 2;

			for (int rowNum = 2; rowNum <= loopNum; rowNum++)
			{

				GlobalDefinitions.Wait();
				AddNewEducation.Click();
				EnterUniversity.SendKeys(ExcelLib.ReadData(rowNum, "College"));
				//Select country from dropdown
				IWebElement EduLevelDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='country']"));
				SelectElement chooseEduLevel = new SelectElement(EduLevelDrpdwn);
				var EduLevelData = ExcelLib.ReadData(rowNum, "Country");
				chooseEduLevel.SelectByValue(EduLevelData);

				//Select Title from Dropdown
				IWebElement TitleLevelDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='title']"));
				SelectElement chooseEduTitleLevel = new SelectElement(TitleLevelDrpdwn);
				//select.SelectByText(ConstantHelpers.LevelFluent);
				var EduTitleLevelData = ExcelLib.ReadData(rowNum, "Title");
				chooseEduTitleLevel.SelectByValue(EduTitleLevelData);
				GlobalDefinitions.Wait();
				//Enter Degree

				EduDegree.SendKeys(ExcelLib.ReadData(rowNum, "Degree"));

				//Select Title from Dropdown
				IWebElement YearDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
				SelectElement chooseEduYear = new SelectElement(YearDrpdwn);
				//select.SelectByText(ConstantHelpers.LevelFluent);
				var EduYearData = ExcelLib.ReadData(rowNum, "Year");
				chooseEduYear.SelectByValue(EduYearData);
				AddSkill.Click();
				
			}
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
			//saving screenshot
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Education Added successfully");


		}
		public void EditEduaction()
		{
			{
				Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
				GlobalDefinitions.Wait();
				EducationLink.Click();

				//for editing Education details
				IList<IWebElement> rows = GlobalDefinitions.driver.FindElements(By.XPath(".//tr"));

				//This loop finds the first row which' title matches sRowValue
				for (int i = 1; i < rows.Count; i++)
				{
					String sValue = GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(text(),'MIT')]")).Text;
					if (sValue == "MIT")
					{
						IWebElement Edit = GlobalDefinitions.driver.FindElement(By.XPath("//tbody[1]//tr[1]//td[6]//span[1]//i[1]"));
						Edit.Click();
						//EditEdu.Click();
						EnterUniversity.Clear();
						EnterUniversity.SendKeys(ExcelLib.ReadData(7, "College"));
						//Select Title from Dropdown
						IWebElement TitleLevelDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='title']"));
						SelectElement chooseEduTitleLevel = new SelectElement(TitleLevelDrpdwn);
						var EduTitleLevelData = ExcelLib.ReadData(rowNum, "Title");
						chooseEduTitleLevel.SelectByValue(EduTitleLevelData);
						UpdateEdu.Click();
						break;

					}
				}

			}
			
			IWebElement UpdateAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = UpdateAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("updated"));
			Console.WriteLine(AlertText);
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Education Updated successfully");
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Skills deleted successfully");

		}

		public void DeleteEducation()
		{
			GlobalDefinitions.Wait();
			EducationLink.Click();
			//for deleting Education details
			//IWebElement Delete = GlobalDefinitions.driver.FindElement(By.XPath("//tbody[1]//tr[1]//td[6]//span[2]//i[1]"));
			GlobalDefinitions.Wait();
			DeleteEdu.Click();
			
			IWebElement DeleteAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String ExpectedAlertText = DeleteAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(ExpectedAlertText.Contains("removed"));
			//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Education deleted successfully");
			
		}
		public void AddCertificate()
		{
			//Populate the Excel Sheet
			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
			GlobalDefinitions.Wait();
			CertificateLink.Click();

			//loop for multiple data getting added at single shot
			int loopNum = Base.RowCount + 2;

			for (int rowNum = 2; rowNum <= loopNum; rowNum++)
			{

				GlobalDefinitions.Wait();
				AddNewCerti.Click();
				EnterCerti.SendKeys(ExcelLib.ReadData(rowNum, "Certificate"));
				CertiFrom.SendKeys(ExcelLib.ReadData(rowNum, "CertificateFrom"));

				IWebElement CertYearDrpdwn = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
				SelectElement chooseCertYear = new SelectElement(CertYearDrpdwn);
				//select.SelectByText(ConstantHelpers.LevelFluent);
				var CertYearData = ExcelLib.ReadData(rowNum, "CertYear");
				chooseCertYear.SelectByValue(CertYearData);
				AddCertiBtn.Click();
			}
				IWebElement AddAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
				String AlertText = AddAlertPopup.Text;
			    GlobalDefinitions.Wait();
			    Assert.IsTrue(AlertText.Contains("added"));
				Console.WriteLine(AlertText);
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Certificate Added successfully");


		}
		public void EditCertificate()
		{


			Global.ExcelLib.PopulateInCollection(Base.ExcelPath, "AddSkills");
			GlobalDefinitions.Wait();
			CertificateLink.Click();
			EditCerti.Click();
			EnterCerti.Clear();
			EnterCerti.SendKeys(ExcelLib.ReadData(7, "Certificate"));
			UpdateCerti.Click();
			IWebElement UpdateAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String AlertText = UpdateAlertPopup.Text;
			GlobalDefinitions.Wait();
			Assert.IsTrue(AlertText.Contains("updated"));
			Console.WriteLine(AlertText);
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Certificate Edited successfully");

		}

		public void DeleteCertificate()
		{
			//for deleting Certificate details
			GlobalDefinitions.Wait();
			CertificateLink.Click();
			DeleteCerti.Click();
			IWebElement DeleteAlertPopup = GlobalDefinitions.driver.FindElement(By.ClassName("ns-box-inner"));
			String ExpectedAlertText = DeleteAlertPopup.Text;
			Assert.IsTrue(ExpectedAlertText.Contains("deleted"));
			var ScreenshotPath = Global.SaveScreenshot.SaveScreenshotClass(GlobalDefinitions.driver, "Certificate Edited successfully");
		}
	}
}


#endregion

