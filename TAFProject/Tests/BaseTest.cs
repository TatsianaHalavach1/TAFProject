using NUnit.Framework;
using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils.Driver
{
	public class BaseTest
	{
		protected static Browser browser = Browser.Instance;

		[SetUp]
		public virtual void InitTest()
		{
			browser.WindowMaximise();
			browser.GoToUrl(Configuration.StartUrl);
		}

		[TearDown]
		public virtual void CleanTest()
		{
			browser.Quit();
		}
	}
}
