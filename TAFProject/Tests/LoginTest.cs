using System.Threading;
using NUnit.Framework;
using SeleniumForRedmine.UIUtils.Driver;
using SeleniumForRedmine.UIUtils.PageObjects;

namespace TAFProject.Tests
{
	[TestFixture]
	class LoginTest: BaseTest
	{
		private string login = "TAT18";
		private string password = "tat18pass";
	    
        [Test]
		public void CorrectLoginTest()
		{
		    LoginPage loginPage = new LoginPage();
            HomePage homepage = loginPage.Login(login, password);
			Assert.True(homepage.GetLogin().Contains(login));
			Thread.Sleep(5000);
		}
	}
}
