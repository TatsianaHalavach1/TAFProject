using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils
{
	class BaseElement { 
		Browser _browser = Browser.Instance;

		readonly By _locator;
		public IWebElement Element => _browser.FindElement(_locator);

		public BaseElement(By locator)
		{
			_locator = locator;
		}

		public void SendKeys(string text) => Element.SendKeys(text);

		public bool IsVisible() => Element.Displayed;

		public void Click()
		{
			new WebDriverWait(_browser.Driver, TimeSpan.FromSeconds(_browser.ImpWait)).Until(driver => driver.FindElement(_locator));
			Element.Click();
		}

		public bool IsExist()
		{
			return Element != null;
		}

		public string Text()
		{
			return Element.Text;
		}

		public void Clear() => Element.Clear();
	}
}
