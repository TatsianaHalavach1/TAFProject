using OpenQA.Selenium;
using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils.PageObjects
{
	public class HomePage : BasePage
	{
		private const string BASE_URL = "http://icerow.com/";
		private Browser browser;
		BaseElement loginIdentifier = new BaseElement(By.Id("loggedas"));

		public string GetLogin()
		{
			if (loginIdentifier.IsExist())
				return loginIdentifier.Text();
			else return "";
		}

		public override void GoToPage()
		{
			browser.GoToUrl(BASE_URL);
		}

	}
}
