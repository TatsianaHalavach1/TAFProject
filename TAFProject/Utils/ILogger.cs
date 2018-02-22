
namespace SeleniumForRedmine.Utils
{
	interface ILogger
	{
		void WriteLog(string message);
		void WriteLog(string message, string filename);
	}
}
