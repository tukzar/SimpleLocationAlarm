﻿using System;
using System.Diagnostics;

namespace LocationAlarm.PCL.Services
{
	class LogService : ILogService
	{
		public void Log(string tag, string format, params object[] args)
		{
			Debug.WriteLine("{0} {1} : {2}", DateTime.Now.TimeOfDay.ToString(), tag, string.Format(format, args));
		}

		public void Log(string tag, Exception e)
		{
			Log(tag, "{0} : {1}", e.ToString(), e.Message);
		}
	}
}
