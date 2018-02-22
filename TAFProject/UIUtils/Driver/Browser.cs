using System;
using OpenQA.Selenium;
using SeleniumForRedmine.UIUtils.Driver;

namespace SeleniumForRedmine.Utils
{
	public class Browser
	{
		static Browser _instance;
		BrowserFactory.BrowserType browserTypeFromConfig;
		private int impWait;
		public int ImpWait {
			get
			{
				int.TryParse(Configuration.ElementTimeout, out impWait);
				return impWait;
			}
		}
		public IWebDriver Driver { get; private set; }
		
		private Browser()
		{
			Enum.TryParse(Configuration.Browser, out browserTypeFromConfig);
			Driver = BrowserFactory.GetDriver(browserTypeFromConfig, ImpWait);
		}
		
		public static Browser Instance => _instance ?? (_instance = new Browser());

		public void WindowMaximise()
		{
			Driver.Manage().Window.Maximize();
		}

		public void GoToUrl(string url)
		{
			Driver.Navigate().GoToUrl(url);
		}

		public IWebElement FindElement(By locator)
		{
			return Driver.FindElement(locator);
		}

		public void Quit()
		{
			Driver.Quit();
			_instance = null;
			Driver = null;
		}

	}
}
