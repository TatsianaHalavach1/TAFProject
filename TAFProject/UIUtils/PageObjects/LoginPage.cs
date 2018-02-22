using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumForRedmine.Utils;

//using TAFProject.PageObjects;

namespace SeleniumForRedmine.UIUtils.PageObjects
{
	public class LoginPage : BasePage
	{
		private const string BASE_URL = "http://icerow.com/";
		private Browser browser;

		BaseElement loginForm = new BaseElement(By.Id("username"));
		BaseElement passwordForm = new BaseElement(By.Id("password"));
		BaseElement loginButton = new BaseElement(By.Name("login"));

		public LoginPage(Browser browser)
		{
			this.browser = browser;
			///PageFactory.InitElements(browser.Driver, this);
		}

		public override void GoToPage()
		{
			browser.GoToUrl(BASE_URL);
		}

		public HomePage Login(string login, string password)
		{
			loginForm.SendKeys(login);
			passwordForm.SendKeys(password);
			loginButton.Click();
			return new HomePage(browser);
		}


	}
}
