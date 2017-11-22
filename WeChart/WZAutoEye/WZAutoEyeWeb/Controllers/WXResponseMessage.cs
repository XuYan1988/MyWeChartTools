using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using WZAutoEye.WZAutoEyeMVC.Utility;
using WZAutoEye.WZAutoEyeMVC.Model;
using WZAutoEye.WZAutoEyeMVC.DAL;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WZAutoEye
{
    /// <summary>
    /// 扫码方法类
    /// </summary>
    public class WXResponseMessage
    {
        JavaScriptSerializer Jss = new JavaScriptSerializer();

        #region 将扫码结果返回给用户
        /// <summary>
        /// 将扫码结果返回给用户
        /// </summary>
        /// <param name="WxXmlModel">微信Model返回参数</param>
        /// <returns></returns>
        public static string ResponseScanCode(WxXmlModel WxXmlModel)
        {
            string response = "";
            try
            {
                if (!string.IsNullOrEmpty(WxXmlModel.ScanResult))
                {
                        /*逻辑代码*/
                }
     
                return response;
            }
            catch
            {
                /*失败方法*/
                return response;
            }
        }
        #endregion

        #region 向用户发布一次性订阅消息
        /// <summary>
        /// 向用户发布一次性订阅消息
        /// </summary>
        /// <param name="post_json">发送内容Json</param>
        /// <param name="access_token">全局唯一接口调用凭据</param>
        /// <returns>返回0成功否则错误码</returns>
        public Dictionary<string, object> SendMessageForOnceSubUser(string post_json, string access_token)
        {
            string setMenuUrl = "https://api.weixin.qq.com/cgi-bin/message/template/subscribe?access_token={0}";
            setMenuUrl = string.Format(setMenuUrl, access_token);
            string respText = CommonMethod.WebRequestPostOrGet(setMenuUrl, post_json);
            Dictionary<string, object> respDic = (Dictionary<string, object>)Jss.DeserializeObject(respText);
            return respDic; //返回0发布成功
        }
        #endregion

        #region 向用户发送模板消息
        /// <summary>
        /// 向用户发送模板消息
        /// </summary>
        /// <param name="post_json">发送内容Json</param>
        /// <param name="access_token">全局唯一接口调用凭据</param>
        /// <returns>返回0成功否则（若出现问题，则通过解析返回XML进行记录）</returns>
        public Dictionary<string, object> SendMessageForFormatUser(string post_json, string access_token)
        {
            string setMenuUrl = "https://api.weixin.qq.com/cgi-bin/message/template/send?access_token={0}";
            setMenuUrl = string.Format(setMenuUrl, access_token);
            string respText = CommonMethod.WebRequestPostOrGet(setMenuUrl, post_json);
            Dictionary<string, object> respDic = (Dictionary<string, object>)Jss.DeserializeObject(respText);
            return respDic; //返回0发布成功
        }
        #endregion
        
    }
}
