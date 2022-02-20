using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test
{
	public static class LocalStorage
	{
		private static Dictionary<string, object> _data = new Dictionary<string, object>();

		public static object GetValue(string key)
		{
			return _data[key];
		}

		public static void SetValue(string key, object value)
		{
			_data[key] = value;
		}
	}
}
