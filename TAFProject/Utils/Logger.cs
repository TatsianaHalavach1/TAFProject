using System;
using System.IO;
using System.Reflection;

namespace SeleniumForRedmine.Utils
{
	public class Logger : ILogger
		//Singleton??
	{
		public void WriteLog(string message)
		{
			WriteLog(message, "\\log.txt");
		}

		public void WriteLog(string message, string filename)
		{
			using (StreamWriter sw =
				new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + filename, true))
			{
				//sw.WriteLine(message);
				sw.WriteLine($"{DateTime.Now.ToString()}: {message}");
			}
		}

	}
}
