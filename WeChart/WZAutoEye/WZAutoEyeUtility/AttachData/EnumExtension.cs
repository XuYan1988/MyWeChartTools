using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public static class EnumExtension
    {
        /**
         * 获取枚举值的特性,如果没有特性，则返回name
         */
        public static String GetDescription(this Enum enumValue)
        {
            return enumValue.GetAttachedData<string>(AttachDataKey.Description);
        }

        public static int GetValue(this Enum enumValue)
        {
            return Convert.ToInt32(enumValue);
        }

        public static string GetStringValue(this Enum enumValue)
        {
            return enumValue.GetValue().ToString();
        }
    }
}