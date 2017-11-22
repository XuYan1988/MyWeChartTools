using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public static class UrlParamHelper
    {
        /// <summary>
        /// 根据获得的加密字符串和对应的传参key获得传参value
        /// </summary>
        /// <param name="param">加密字符串</param>
        /// <param name="paramKey">传参key</param>
        /// <returns>传参value</returns>
        public static string GetUrlParam(string param, string paramKey)
        {
            string paramVal = string.Empty;
            try 
            {
                string paramStr = Base64Helper.Base64ToString(param);

                paramVal = paramStr.Split(new string[] { paramKey + "=" }, StringSplitOptions.None)[1];

                paramVal = paramVal.Split('&')[0];

                return paramVal;
            }
            catch
            {
                return "";
            }
        }
    }
}
