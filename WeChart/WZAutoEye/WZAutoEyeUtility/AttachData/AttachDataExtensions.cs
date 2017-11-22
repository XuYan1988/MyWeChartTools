#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

#endregion

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
	public static class AttachDataExtensions
	{
		public static object GetAttachedData(this ICustomAttributeProvider provider, object key)
		{
			var attributes = (AttachDataAttribute[])provider.GetCustomAttributes(
				typeof(AttachDataAttribute), false);
			var obj = attributes.FirstOrDefault(a => a.Key.Equals(key));
            if (obj == null)
                throw new Exception("对象未添加AttachedData.");
		    return obj.Value;
		}

		public static T GetAttachedData<T>(this ICustomAttributeProvider provider, object key)
		{
			return (T)provider.GetAttachedData(key);
		}

		public static object GetAttachedData(this Enum value, object key)
		{
			return value.GetType().GetField(value.ToString()).GetAttachedData(key);
		}

        public static T GetAttachedData<T>(this Enum value, object key)
        {
            string typeKey = value.GetType().ToString();
            string dataKey = value.ToString();
            T data;

            if (!AttachDataCache<T>.Current.ContainsKey(typeKey))
            {
                AttachDataCache<T>.Current[typeKey] = new Dictionary<string, T>();
                data = (T)value.GetAttachedData(key);
                AttachDataCache<T>.Current[typeKey][dataKey] = data;
            }

            if (!AttachDataCache<T>.Current[typeKey].ContainsKey(dataKey))
            {
                data = (T)value.GetAttachedData(key);
                AttachDataCache<T>.Current[typeKey][dataKey] = data;
            }
            else
            {
                data = AttachDataCache<T>.Current[typeKey][dataKey];
            }

            return data;
        }
	}
}
