using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumForRedmine.UIUtils.PageObjects
{
	class ActivityPage : BasePage
	{
		private const string BASE_URL = "http://icerow.com/projects/test/activity";
		private WebDriverWait wait;
		BaseElement activityContent = new BaseElement(By.Id("activity"));

        //public bool IsIssueAdded()
		//{
		// return activityContent.Element.Text.Contains(/*here must be numberof issue*/);
		//}

		public override void GoToPage()
		{
			browser.GoToUrl(BASE_URL);
		}
	}
}
