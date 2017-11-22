using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Xml;

namespace WZAutoEye
{
    /// <summary>
    /// HandlerWX 的摘要说明
    /// </summary>
    public class HandlerWX : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Request.HttpMethod.ToLower() == "post")
            {
                //回复消息的时候也需要验证消息，这个很多开发者没有注意这个，存在安全隐患  
                //微信中 谁都可以获取信息 所以 关系不大 对于普通用户 但是对于某些涉及到验证信息的开发非常有必要
                if (CheckSignature())
                {
                    //接收消息
                    ReceiveXml();
                }
                else
                {
                    HttpContext.Current.Response.Write("错误提示");
                    HttpContext.Current.Response.End();
                }
            }
            else
            {
                CheckWechat();
            }
        }
        #region 验证微信签名
        /// <summary>
        /// 返回随机数表示验证成功
        /// </summary>
        private void CheckWechat()
        {
            if (string.IsNullOrEmpty(HttpContext.Current.Request.QueryString["echoStr"]))
            {
                HttpContext.Current.Response.Write("消息并非来自微信");
                HttpContext.Current.Response.End();
            }
            string echoStr = HttpContext.Current.Request.QueryString["echoStr"];
            if (CheckSignature())
            {
                HttpContext.Current.Response.Write(echoStr);
                HttpContext.Current.Response.End();
            }
        }

        /// <summary>
        /// 验证微信签名
        /// </summary>
        /// <returns></returns>
        /// * 将token、timestamp、nonce三个参数进行字典序排序
        /// * 将三个参数字符串拼接成一个字符串进行sha1加密
        /// * 开发者获得加密后的字符串可与signature对比，标识该请求来源于微信。
        private bool CheckSignature()
        {
            string access_token = "123456";
            //订阅号服务号
            string signature = HttpContext.Current.Request.QueryString["signature"].ToString();
            string timestamp = HttpContext.Current.Request.QueryString["timestamp"].ToString();
            string nonce = HttpContext.Current.Request.QueryString["nonce"].ToString();
            string[] ArrTmp = { access_token, timestamp, nonce };
            Array.Sort(ArrTmp);     //字典排序
            string tmpStr = string.Join("", ArrTmp);
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");

            if (tmpStr.ToLower() == signature)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 接收消息
        /// <summary>
        /// 接收微信发送的XML消息并且解析
        /// </summary>
        private void ReceiveXml()
        {
            Stream requestStream = System.Web.HttpContext.Current.Request.InputStream;
            byte[] requestByte = new byte[requestStream.Length];
            requestStream.Read(requestByte, 0, (int)requestStream.Length);
            string requestStr = Encoding.UTF8.GetString(requestByte);

            if (!string.IsNullOrEmpty(requestStr))
            {
                //封装请求类
                XmlDocument requestDocXml = new XmlDocument();
                requestDocXml.LoadXml(requestStr);
                XmlElement rootElement = requestDocXml.DocumentElement;
                WxXmlModel WxXmlModel = new WxXmlModel();
                WxXmlModel.ToUserName = rootElement.SelectSingleNode("ToUserName").InnerText;//开发者微信号
                WxXmlModel.FromUserName = rootElement.SelectSingleNode("FromUserName").InnerText;//发送方帐号（一个OpenID）
                WxXmlModel.CreateTime = rootElement.SelectSingleNode("CreateTime").InnerText;//消息创建时间 （整型）
                WxXmlModel.MsgType = rootElement.SelectSingleNode("MsgType").InnerText;//消息类型，event

                switch (WxXmlModel.MsgType)
                {
                    case "text"://文本
                        WxXmlModel.Content = rootElement.SelectSingleNode("Content").InnerText;
                        break;
                    case "image"://图片
                        WxXmlModel.PicUrl = rootElement.SelectSingleNode("PicUrl").InnerText;
                        break;
                    case "event"://事件
                        WxXmlModel.Event = rootElement.SelectSingleNode("Event").InnerText;
                        if (WxXmlModel.Event != "TEMPLATESENDJOBFINISH")//关注类型
                        {
                            WxXmlModel.EventKey = rootElement.SelectSingleNode("EventKey").InnerText;
                        }
                        switch (WxXmlModel.Event)
                        {
                            case "subscribe"://关注事件
                                //WxXmlModel.ScanType = rootElement.SelectSingleNode("ScanCodeInfo").SelectSingleNode("ScanType").InnerText;//扫描类型，一般是qrcode
                                //WxXmlModel.Content = "进入关注事件";
                                //WxXmlModel.ScanCodeInfo = rootElement.SelectSingleNode("ScanCodeInfo").InnerText;
                                //WxXmlModel.ScanResult = rootElement.SelectSingleNode("ScanCodeInfo").SelectSingleNode("ScanResult").InnerText;//扫描结果，即二维码对应的字符串信息
                                break;
                        }
                        switch (WxXmlModel.EventKey)
                        {
                            case "ScanCode"://扫码事件

                                WxXmlModel.ScanType = rootElement.SelectSingleNode("ScanCodeInfo").SelectSingleNode("ScanType").InnerText;//扫描类型，一般是qrcode
                                WxXmlModel.ScanResult = rootElement.SelectSingleNode("ScanCodeInfo").SelectSingleNode("ScanResult").InnerText;//扫描结果，即二维码对应的字符串信息
                                break;
                            case "ReviewTime"://点击菜单事件
                                break;
                        }

                        break;
                    default:
                        break;
                }

                ResponseXML(WxXmlModel);//回复消息
            }
        }
        #endregion

        #region 回复消息
        private void ResponseXML(WxXmlModel WxXmlModel)
        {
            StringBuilder str = new StringBuilder();
            string XML = "";
            switch (WxXmlModel.MsgType)
            {
                case "text"://文本回复
                    XML = ResponseMessage.GetText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, "");
                    break;
                case "event":
                    switch (WxXmlModel.Event)
                    {
                        case "subscribe":
                            if (string.IsNullOrEmpty(WxXmlModel.EventKey))
                            {

                                str = new StringBuilder();
                                str.Append("欢迎消息");
                                XML = ResponseMessage.ReText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, str.ToString());
                            }
                            break;
                            //case "SCAN":
                            //    XML = ResponseMessage.ScanQrcode(WxXmlModel.FromUserName, WxXmlModel.ToUserName, WxXmlModel.EventKey);//扫描带参数二维码已关注 直接推送事件
                            //    break;
                        case "VIEW":
                                XML = ResponseMessage.GetText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, WxXmlModel.Content);
                            break;
                        case "scancode_waitmsg":
                            //通过公众号内扫码功能扫码
                            WxXmlModel.Content = WXResponseMessage.ResponseScanCode(WxXmlModel);
                            XML = ResponseMessage.ReText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, WxXmlModel.Content);
                            break;
                        case "CLICK":
                            switch (WxXmlModel.EventKey)
                            {
                                    //用户点击事件
                                case "ReviewTime":
                                    WxXmlModel.Content = WXResponseMessage.ResponseReviewTime(WxXmlModel.FromUserName);
                                    XML = ResponseMessage.ReText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, WxXmlModel.Content);
                                    break;
                                //回复图文消息
                                case "Media":
                                    XML = ResponseMessage.GetText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, WxXmlModel.EventKey);
                                    break;
                            }
                            break;
                    }
                    break;
                default://默认回复
                    //XML = ResponseMessage.ReText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, "此操作无效！");
                    XML = ResponseMessage.GetText(WxXmlModel.FromUserName, WxXmlModel.ToUserName, "");
                    break;
            }
            HttpContext.Current.Response.Write(XML);
            HttpContext.Current.Response.End();
        }
        #endregion

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}