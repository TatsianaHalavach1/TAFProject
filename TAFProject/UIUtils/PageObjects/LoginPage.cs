using OpenQA.Selenium;
using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils.PageObjects
{
	public class LoginPage : BasePage
	{
		private const string BASE_URL = "http://icerow.com/";
		private Browser browser;

		BaseElement loginForm = new BaseElement(By.Id("username"));
		BaseElement passwordForm = new BaseElement(By.Id("password"));
		BaseElement loginButton = new BaseElement(By.Name("login"));

		public override void GoToPage()
		{
			browser.GoToUrl(BASE_URL);
		}

		public HomePage Login(string login, string password)
		{
			loginForm.SendKeys(login);
			passwordForm.SendKeys(password);
			loginButton.Click();
			return new HomePage();
		}


	}
}
