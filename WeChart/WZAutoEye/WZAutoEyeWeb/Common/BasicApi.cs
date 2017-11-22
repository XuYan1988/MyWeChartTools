using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace WZAutoEye
{
    public class BasicApi
    {
        public static string SessionAccessToken = "";//access_token缓存 其他接口的通行证

        public BasicApi() { }

        #region 获取access_token缓存
        public static string GetTokenSession(string AppID, string AppSecret)
        {
            string TokenSession = "";

            if (System.Web.HttpContext.Current.Session[SessionAccessToken] == null)
            {
                TokenSession = AddTokenSession(AppID, AppSecret);
            }
            else
            {
                TokenSession = System.Web.HttpContext.Current.Session[SessionAccessToken].ToString();
            }

            return TokenSession;
        }
        /// <summary>
        /// 添加AccessToken缓存
        /// </summary>
        /// <param name="AppID"></param>
        /// <param name="AppSecret"></param>
        /// <returns></returns>
        public static string AddTokenSession(string AppID, string AppSecret)
        {
            //获取AccessToken
            string AccessToken = GetAccessToken(AppID, AppSecret);
            HttpContext.Current.Session[SessionAccessToken] = AccessToken;
            HttpContext.Current.Session.Timeout = 7200;
            return AccessToken;
        }

        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="AppID"></param>
        /// <param name="AppSecret"></param>
        /// <returns></returns>
        public static string GetAccessToken(string AppID, string AppSecret)
        {
            JavaScriptSerializer Jss = new JavaScriptSerializer();
            string respText = CommonMethod.WebRequestPostOrGet(string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", AppID, AppSecret), "");
            Dictionary<string, object> respDic = (Dictionary<string, object>)Jss.DeserializeObject(respText);
            string accessToken = respDic["access_token"].ToString();
            return accessToken;
        }
        #endregion

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="access_token"></param>
        /// <param name="openid"></param>
        /// <returns>respDic</returns>
        public static Dictionary<string, object> GetUserInfo(string access_token, string openid)
        {
            JavaScriptSerializer Jss = new JavaScriptSerializer();
            string respText = CommonMethod.WebRequestPostOrGet(string.Format("https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}", access_token, openid), "");
            Dictionary<string, object> respDic = (Dictionary<string, object>)Jss.DeserializeObject(respText);
            return respDic;
        }

        #region 用户是否关注
        /// <summary>
        /// 用户是否关注
        /// </summary>
        /// <param name="openid">微信opeid</param>
        /// <returns>true:关注 false:未关注</returns>
        public static bool isSubscribe(string openid)
        {

            try
            {
                bool issub = false;
                string accessToken = BasicApi.GetAccessToken(ConfigurationManager.AppSettings["AppID"].ToString(), ConfigurationManager.AppSettings["AppSecret"].ToString());
                Dictionary<string, object> respDic_UserInfo = BasicApi.GetUserInfo(accessToken, openid);
                if (respDic_UserInfo["subscribe"].ToString() == "1")
                {
                    issub = true;
                }
                return issub;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}