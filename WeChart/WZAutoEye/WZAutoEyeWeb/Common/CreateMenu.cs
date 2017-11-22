using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace WZAutoEye
{
    public class CreateMenu
    {

        JavaScriptSerializer Jss = new JavaScriptSerializer();
        //获取菜单

        public string selectMenu()
        {
            FileStream fs1 = new FileStream(System.Web.HttpContext.Current.Server.MapPath(".") + "\\menu.txt", FileMode.Open);

            StreamReader sr = new StreamReader(fs1, Encoding.GetEncoding("GBK"));

            string menu = sr.ReadToEnd();

            sr.Close();

            fs1.Close();

            return menu;
        }



        #region 发布菜单
        /// <summary>
        /// 发布菜单
        /// </summary>
        /// <param name="MenuJson">配置的菜单json数据</param>
        /// <param name="AppID">AppID</param>
        /// <param name="AppSecret">AppSecret</param>
        /// <returns>返回0成功否则错误码</returns>
        public string MenuCreate(string MenuJson, string AppID, string AppSecret)
        {
            string setMenuUrl = "https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}";
            setMenuUrl = string.Format(setMenuUrl, BasicApi.GetTokenSession(AppID, AppSecret));//获取token、拼凑url
            string respText = CommonMethod.WebRequestPostOrGet(setMenuUrl, MenuJson);
            Dictionary<string, object> respDic = (Dictionary<string, object>)Jss.DeserializeObject(respText);
            return respDic["errcode"].ToString();//返回0发布成功
        }
        #endregion



        #region 获取素材ID
        /// <summary>
        /// 获取素材ID
        /// </summary>
        /// <param name="MenuJson">获取素材ID</param>
        /// <param name="AppID">AppID</param>
        /// <param name="AppSecret">AppSecret</param>
        /// <returns>返回0成功否则错误码</returns>
        public string GetMedia(string MenuJson, string AppID, string AppSecret)
        {
            string setMenuUrl = "https://api.weixin.qq.com/cgi-bin/material/batchget_material?access_token={0}";
            setMenuUrl = string.Format(setMenuUrl, BasicApi.GetTokenSession(AppID, AppSecret));//获取token、拼凑url
            string respText = CommonMethod.WebRequestPostOrGet(setMenuUrl, MenuJson);
            Dictionary<string, object> respDic = (Dictionary<string, object>)Jss.DeserializeObject(respText);
            return respDic["errcode"].ToString();//返回0发布成功
        }
        #endregion


        #region 根据code获取appID
        /// <summary>
        /// 通过code换取网页授权access_token (2017-09-06 获取access_token的方法为GetTokenSession)
        /// </summary>
        /// <param name="code">用户同意授权，获取code</param>
        /// <param name="AppID">AppID</param>
        /// <param name="AppSecret">AppSecret</param>
        /// <returns>返回0成功否则错误码</returns>
        public Dictionary<string, object> GetAppID(string AppID, string AppSecret, string code)
        {
            string setMenuUrl = "https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code ";
            setMenuUrl = string.Format(setMenuUrl, AppID, AppSecret, code);//获取token、拼凑url
            string respText = CommonMethod.WebRequestPostOrGet(setMenuUrl,"");
            Dictionary<string, object> respDic = (Dictionary<string, object>)Jss.DeserializeObject(respText);
            return respDic; //返回0发布成功
        }
        #endregion


        public string Get_openid(string AppID, string AppSecret, string code)
        {
            string url = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=" + AppID + "&secret=" + AppSecret + "&code=" + code + "&grant_type=authorization_code";

            string Str = GetJson(url);

            return Str;
        }
        public string GetJson(string url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            wc.Encoding = Encoding.UTF8;
            string returnText = wc.DownloadString(url);

            if (returnText.Contains("errcode"))
            {
                //可能发生错误
            }
            //Response.Write(returnText);
            return returnText;
        }





    }
}