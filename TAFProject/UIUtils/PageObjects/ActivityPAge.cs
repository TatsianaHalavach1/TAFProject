using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumForRedmine.Utils;

//using TAFProject.PageObjects;

namespace SeleniumForRedmine.UIUtils.PageObjects
{
	class ActivityPage : BasePage
	{
		private const string BASE_URL = "http://icerow.com/projects/test/activity";
		private Browser browser;
		private WebDriverWait wait;
		BaseElement activityContent = new BaseElement(By.Id("activity"));
		//AddIssuePage addIsue = new AddIssuePage(new ChromeDriver());


		public ActivityPage(Browser browser)
		{
			this.browser = browser;
			///PageFactory.InitElements(driver, this);
		}

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
