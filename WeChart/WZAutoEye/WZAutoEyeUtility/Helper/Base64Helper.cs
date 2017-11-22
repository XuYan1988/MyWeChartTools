using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public static class Base64Helper
    {
        /// <summary>
        /// Base64加密，解密方法
        /// </summary>
        /// <paramname="s">输入字符串</param>
        /// <paramname="c">true-加密,false-解密</param>
        public static string Base64ToString(string s, bool c = false)
        {
            if (c)
            {
                return Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(s));
            }
            else
            {
                try
                {
                    return Encoding.Default.GetString(System.Convert.FromBase64String(s));
                }
                catch (Exception exp)
                {
                    return exp.Message;
                }
            }
        }

    }
}
