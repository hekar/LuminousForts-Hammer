/*
 * Created by SharpDevelop.
 * User: hekar
 * Date: 6/27/2011
 * Time: 6:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Runtime.Remoting;

namespace LuminousFortsHammer
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Logger
	{
		private const string defaultLogFile = "log.txt";
		private static Logger logger = null;
		public static Logger Instance
		{
			get
			{
				if (logger == null)
				{
					logger = new Logger(defaultLogFile);
				}
				
				return logger;
			}
		}
		
		private string filename;
		public Logger(string filename)
		{
			this.filename = filename;
		}
		
		public void Write(string entry)
		{
			string logLine = DateTime.Now.ToString() + " " + entry;
			try
			{
				StreamWriter writer = new StreamWriter(filename, true);
				writer.WriteLine(logLine);
				writer.Close();
			}
			catch (IOException)
			{
				Console.WriteLine(logLine);
			}
		}
	}
}
