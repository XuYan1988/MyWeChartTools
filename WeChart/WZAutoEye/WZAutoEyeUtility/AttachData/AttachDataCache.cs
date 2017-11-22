#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
	public static class AttachDataCache<TData>
	{
		private static Dictionary<string, Dictionary<string, TData>> current;
		private static object sync = new object();

		static AttachDataCache()
		{
			current = new Dictionary<string, Dictionary<string, TData>>();
		}

		public static void Add(string category, Dictionary<string, TData> datas)
		{
			lock (sync)
			{
				current.Add(category, datas);
			}
		}

		public static void Add(string category, string key, TData data)
		{
			lock (sync)
			{
				current[category].Add(key, data);
			}
		}

		public static Dictionary<string, Dictionary<string, TData>> Current
		{
			get
			{
				return current;
			}
		}
	}
}
