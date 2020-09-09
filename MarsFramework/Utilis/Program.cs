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


		[Test]
		public static void Test()
		{
			//SignIn objsignin = new SignIn();
			//objsignin.LoginSteps();
			
		}


		[AfterFeature]
			public static void EndTest()
			{
				Base.TearDown();
			}

		}
	}


