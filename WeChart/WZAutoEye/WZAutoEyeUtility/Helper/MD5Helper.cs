using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public static class MD5Helper
    {
        private static MD5CryptoServiceProvider _MD5Provider = null;

        private static MD5CryptoServiceProvider MD5Provider
        {
            get
            {
                if (_MD5Provider == null)
                    _MD5Provider = new MD5CryptoServiceProvider();
                return _MD5Provider;
            }
        }

        public static string ToMD5(string s, Encoding encoding)
        {
            return BitConverter.ToString(MD5Provider.ComputeHash(encoding.GetBytes(s))).Replace("-", "");
        }
    }
}
