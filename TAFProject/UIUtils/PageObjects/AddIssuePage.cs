using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils.PageObjects
{
	class AddIssuePage : BasePage
	{
		private const string BASE_URL = "http://icerow.com/issues/";
		private Browser browser;
		private WebDriverWait wait;
		readonly BaseElement newIssueButton = new BaseElement(By.XPath("//div[@class=\"contextual\"]/a"));
		readonly BaseElement newIssueSubject = new BaseElement(By.Id("issue_subject"));
		readonly BaseElement newIssueCommitButton = new BaseElement(By.Name("commit"));
		public static BaseElement newIssueNumber = new BaseElement(By.XPath("//*[@id=\"flash_notice\"]/a"));
		private string createdIssueNumber = GetIssueNumber();

		public AddIssuePage(Browser browser)
		{
			this.browser = browser;
			///PageFactory.InitElements(driver, this);
		}

		public static string GetIssueNumber()
		{
			return newIssueNumber.Element.Text;
		}

		public override void GoToPage()
		{
			browser.GoToUrl(BASE_URL);
		}

		public void CreateNewIssue()
		{
			newIssueButton.Click();
			newIssueSubject.SendKeys(GetRandomString(8));
			newIssueCommitButton.Click();
		}

		public static string GetRandomString(int length)
		{
			string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			Random random = new Random();
			string result = new string(
				Enumerable.Repeat(chars, length)
					.Select(s => s[random.Next(s.Length)])
					.ToArray());

			return result;
		}
	}
}
