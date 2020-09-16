using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework
{
	
	[Binding]
	public static class Program
	{
		public static IWebDriver myDriver = GlobalDefinitions.driver;


		[BeforeFeature]
			public static void StartTest()
			{

				Base.Inititalize();
			}


		//[Test]
		//public static void TestLogin()
		//{
		//	SignIn objsignin = new SignIn();
		//	objsignin.LoginSteps();
		//}
			
		//[Test]
		//public static void TestLanguage()
		//{
		//	Skills objLanguage = new Skills();
		//	objLanguage.AddLanguage();
		//	objLanguage.EditLanguage();
		//	objLanguage.DeleteLanguage();
		//}
		//[Test]
		//public static void TestSkills()
		//{
		//	Skills objSkills = new Skills();
		//	objSkills.AddSkills();
		//	objSkills.EditSkills();
		//	objSkills.DeleteSkills();
			
		//}
		//	[Test]
		//public static void TestEducation()
		//{
		//	Skills objeducation = new Skills();
		//	objeducation.AddEducation();
		//	objeducation.EditEduaction();
		//	objeducation.DeleteEducation();
		//}
		//[Test]
		//public static void TestCertificate()
		//{
		//	Skills objcertificate = new Skills();
		//	objcertificate.AddCertificate();
		//	objcertificate.EditCertificate();
		//	objcertificate.DeleteCertificate();

		//}
		//[Test]
		//public static void TestProfile()
		//{
		//	Profile objprofile = new Profile();
		//	objprofile.EditProfile();

		//}
		//[Test]
		//public static void TestSearch()
		//{
		//	Search objsearch = new Search();
		//	objsearch.SearchSkill();

		//}
		//[Test]
		//public static void TestRegister()
		//{
		//	SignUp objregister = new SignUp();
		//	objregister.register();

		//}
		//[Test]
		//public static void TestShareSkill()
		//{
		//	ShareSkill objshareskill = new ShareSkill();
		//	objshareskill.EnterShareSkill();

		//}
		//[Test]
		//public static void TestManageListings()
		//{
		//	ManageListings objListings = new ManageListings();
		//	objListings.ViewListing();
		//	objListings.DeleteListing();

		//}
	
	


		[AfterFeature]
			public static void EndTest()
			{
				Base.TearDown();
			}

		}
	}


