﻿using System;
using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils
{
	class BaseElement : IWebElement
	{ 
		readonly Browser browser = Browser.Instance;
	    readonly IWebElement element;
	    readonly By locator;

	    public string Text => element.Text;

        public string TagName => element.TagName;

        public bool Enabled => element.Enabled;

        public bool Selected => element.Selected;

        public Point Location => element.Location;

        public Size Size => element.Size;

        public bool Displayed => element.Displayed;

        public BaseElement(By locator)
		{
			this.locator = locator;
		    element = browser.FindElement(locator);
        }

		public void SendKeys(string text) => element.SendKeys(text);

		public void Click()
		{
			new WebDriverWait(browser.Driver, TimeSpan.FromSeconds(browser.ImpWait)).Until(driver => driver.FindElement(locator));
			element.Click();
		}

		public bool IsExist()
		{
			return element != null;
		}
        
		public void Clear() => element.Clear();

        public void Submit() => element.Submit();

        public string GetAttribute(string attributeName) => element.GetAttribute(attributeName);

	    public string GetProperty(string propertyName) => element.GetProperty(propertyName);

	    public string GetCssValue(string propertyName) => element.GetCssValue(propertyName);

	    public IWebElement FindElement(By by) => element.FindElement(by);

        public ReadOnlyCollection<IWebElement> FindElements(By by) => element.FindElements(by);
    }
}
