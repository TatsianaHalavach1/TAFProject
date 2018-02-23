using OpenQA.Selenium;

namespace SeleniumForRedmine.UIUtils.PageObjects
{
	public class LoginPage : BasePage
	{
		private const string BASE_URL = "http://icerow.com/";
		
		BaseElement loginForm;
		BaseElement passwordForm;
		BaseElement loginButton;

	    public LoginPage()
	    {
	        loginForm = new BaseElement(By.Id("username"));
	        passwordForm = new BaseElement(By.Id("password"));
	        loginButton = new BaseElement(By.Name("login"));
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
			return new HomePage();
		}
	}
}
