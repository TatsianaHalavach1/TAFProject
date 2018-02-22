using OpenQA.Selenium;
using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils
{
	class AddProjectPage : BasePage
	{

		private const string BASE_URL = "http://icerow.com/projects/new";

		private BaseElement inputProjectName = new BaseElement(By.XPath("//input[@id='project_name']"));

		private BaseElement inputProjectDescription = new BaseElement(By.XPath("//textarea[@id='project_description']"));

		private BaseElement inputHomepage = new BaseElement(By.XPath("//input[@id='project_homepage']"));

		private BaseElement checkboxPublic = new BaseElement(By.XPath("//input[@id='project_is_public']"));

		private BaseElement checkboxInheritMembers = new BaseElement(By.XPath("//input[@id='project_inherit_members']"));

		private BaseElement buttonCreate = new BaseElement(By.XPath("//input[@type='submit']"));

		private Browser browser;

		public AddProjectPage(Browser browser)
		{
			this.browser = browser;
			//PageFactory.InitElements(this.driver, this);
		}

		public override void GoToPage()
		{
			browser.GoToUrl(BASE_URL);
		}

		public void CreateNewProject(string projectName, string projectIdentifier, string projectDescription = "", string homepage = "")
		{
			inputProjectName.SendKeys(projectName);
			inputProjectDescription.SendKeys(projectIdentifier);
			inputProjectDescription.SendKeys(projectDescription);
			inputProjectDescription.SendKeys(homepage);
			buttonCreate.Click();
		}


	}
}
