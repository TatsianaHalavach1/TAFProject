using SeleniumForRedmine.Utils;

namespace SeleniumForRedmine.UIUtils
{
	public abstract class BasePage
	{
        protected Browser browser = Browser.Instance;
		public abstract void GoToPage();
	}
}
