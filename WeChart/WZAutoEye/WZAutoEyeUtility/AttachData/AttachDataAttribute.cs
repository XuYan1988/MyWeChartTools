#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class AttachDataAttribute : Attribute
	{
		public AttachDataAttribute(object key, object value)
		{
			this.Key = key;
			this.Value = value;
		}

		public object Key { get; set; }

		public object Value { get; set; }
	}
}
