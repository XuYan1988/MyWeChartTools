using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using WZAutoEye.WZAutoEyeMVC.DAL;
using WZAutoEye.WZAutoEyeMVC.Model;

namespace WZAutoEye
{
    public class ResponseMessage
    {
         JavaScriptSerializer Jss = new JavaScriptSerializer();
        #region 接收的类型
        /// <summary>
        /// 接收文本
        /// </summary>
        /// <param name="FromUserName"></param>
        /// <param name="ToUserName"></param>
        /// <param name="Content"></param>
        /// <returns></returns>
        public static string GetText(string FromUserName, string ToUserName, string Content)
        {
            CommonMethod.WriteTxt(Content);

            string XML = "";
            switch (Content)
            {
                //工程介绍单图文回复
                case "Project":
                    XML = ReArticle(FromUserName, ToUserName, "中国糖网筛防工程", "工程由中国微循环学会与全国防盲技术指导组主办、中国微循环学会糖尿病与微循环专业委员会承办、国家眼科诊断与治疗工程技术研究中心提供技术支持、北京上工医信科技有限公司协办", ConfigurationManager.AppSettings["DomainName"]+"/WXMain/images/cover.jpg", "https://mp.weixin.qq.com/s/Y3k1uFZXwmmaksI0llZFGw");
                    break;
                //科室介绍单图文回复
                case "Department":
                    XML = ReArticle(FromUserName, ToUserName, "科室介绍", "",  ConfigurationManager.AppSettings["DomainName"]+"/WXMain/images/department.jpg",  ConfigurationManager.AppSettings["DomainName"]+"/WXMain/IntroduceDepartment");
                    break;
                //专家介绍单图文回复
                case "ConsultDoctor":
                    XML = ReArticle(FromUserName, ToUserName, "专家介绍", "", ConfigurationManager.AppSettings["DomainName"] + "/WXMain/images/consultdoctor.png",  ConfigurationManager.AppSettings["DomainName"]+"/WXMain/IntroduceConsultDoctor");
                    break;
                //健康知识单图文回复
                case "DiabeticRetinopathy":
                    XML = ReArticle(FromUserName, ToUserName, "健康知识--认识糖尿病", "", "https://mmbiz.qpic.cn/mmbiz_jpg/MO6LZNP0ecCPxVCYzt9Y5UPSxlBVM0YB5AFRDiblEcOcNzYChd5KZ88ZakgybQ05MiccqUxxcicr7lUUgz4zUsicFA/0?wx_fmt=jpeg", "https://mp.weixin.qq.com/s/HASAJEOGFa4C_fqTybLFug");
                    break;
                //case "患者管理样例":
                //    XML = ReText(FromUserName, ToUserName, "<a href=\"/WXMain/PatientList?openid=oxrSr1EpQqBExKozl6cF9rwhDlFc\">患者管理</a>");
                    //break;
                //回复图文消息
                case "Media":

                    //ReArticle(string FromUserName, string ToUserName, int ArticleCount, System.Data.DataTable dtArticle)
                    //"<item><Title><![CDATA[" + Item["Title"] + "]]></Title><Description><![CDATA[" + Item["Description"] + "]]></Description><PicUrl><![CDATA[" + Item["PicUrl"] + "]]></PicUrl><Url><![CDATA[" + Item["Url"] + "]]></Url></item>";

                    //DataTable dt = new DataTable();
                    //DataColumn dc1 = new DataColumn("Title", System.Type.GetType("System.String"));

                    //DataColumn dc2 = new DataColumn("Description", System.Type.GetType("System.String"));

                    //DataColumn dc3 = new DataColumn("PicUrl", Type.GetType("System.String"));

                    //DataColumn dc4 = new DataColumn("Url", Type.GetType("System.String"));
                    //        dt.Columns.Add(dc1);            

                    //       dt.Columns.Add(dc2);

                    //dt.Columns.Add(dc3);
                    //dt.Columns.Add(dc4);
                    ////添加三条数据　　　　

                    //DataRow row=dt.NewRow();
                    //row["Title"] = "中国糖网筛防工程自助查询攻略";
                    //row["Description"] = "中国糖网筛防工程自助查询攻略";
                    //row["PicUrl"] = "https://mmbiz.qpic.cn/mmbiz_png/MO6LZNP0ecBx4iaCmKVyZBdGR2cdP2gGOhpbPkhpFo0Cuz6h6eGBt6GND9INokct39rEYbLje7XfwiaEPxdTRnHA/0?wx_fmt=png";
                    //row["Url"] = "https://mp.weixin.qq.com/s/1-fy7DHmGypxUB00rGGMfg";
                    //dt.Rows.Add(row);
                    //row=dt.NewRow();
                    //row["Title"] = "中国糖网筛防工程自助查询攻略";
                    //row["Description"] = "中国糖网筛防工程自助查询攻略";
                    //row["PicUrl"] = "https://mmbiz.qpic.cn/mmbiz_png/MO6LZNP0ecBx4iaCmKVyZBdGR2cdP2gGOhpbPkhpFo0Cuz6h6eGBt6GND9INokct39rEYbLje7XfwiaEPxdTRnHA/0?wx_fmt=png";
                    //row["Url"] = "https://mp.weixin.qq.com/s/1-fy7DHmGypxUB00rGGMfg";
                    //dt.Rows.Add(row);
                    //XML = ReArticle(FromUserName, ToUserName, 2, dt);
                    XML = ReArticle(FromUserName, ToUserName, "糖网筛查报告自助查询攻略", "", "https://mmbiz.qpic.cn/mmbiz_jpg/MO6LZNP0ecAB21icUu44UW54b0Zx0mLSlwRcBm3OibxDs8WJAHP8ME56F9wbH1J5rLrER7oPXkE7UVRconeA5iaJg/0?wx_fmt=jpeg", "https://mp.weixin.qq.com/s/1-fy7DHmGypxUB00rGGMfg");
                    break;
                default:
                   // XML = ReText(FromUserName, ToUserName, "");
                    break;
            }
            return XML;
        }






        /// <summary>
        /// 未关注扫描带参数二维码
        /// </summary>
        /// <param name="FromUserName"></param>
        /// <param name="ToUserName"></param>
        /// <param name="EventKey"></param>
        /// <returns></returns>
        public static string SubScanQrcode(string FromUserName, string ToUserName, string EventKey)
        {
            return "";
        }

        /// <summary>
        /// 已关注扫描带参数二维码
        /// </summary>
        /// <param name="FromUserName"></param>
        /// <param name="ToUserName"></param>
        /// <param name="EventKey"></param>
        /// <returns></returns>
        public static string ScanQrcode(string FromUserName, string ToUserName, string EventKey)
        {
            return "";
        }
        #endregion

        #region 回复方式
        /// <summary>
        /// 回复文本
        /// </summary>
        /// <param name="FromUserName">发送给谁(openid)</param>
        /// <param name="ToUserName">来自谁(公众账号ID)</param>
        /// <param name="Content">回复类型文本</param>
        /// <returns>拼凑的XML</returns>
        public static string ReText(string FromUserName, string ToUserName,string Content)
        {
            StringBuilder xmlBuilder=new StringBuilder();
            xmlBuilder.Append("<xml>");
            xmlBuilder.Append("<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>");
            xmlBuilder.Append("<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>");
            xmlBuilder.Append("<CreateTime>" + CommonMethod.ConvertDateTimeInt(DateTime.Now) + "</CreateTime>");
            xmlBuilder.Append("<MsgType><![CDATA[text]]></MsgType>");
            xmlBuilder.Append("<Content><![CDATA[" + Content + "]]></Content><FuncFlag>0</FuncFlag></xml>");
            return xmlBuilder.ToString();
        }


        /// <summary>
        /// 回复View
        /// </summary>
        /// <param name="FromUserName">发送给谁(openid)</param>
        /// <param name="ToUserName">来自谁(公众账号ID)</param>
        /// <param name="Content">回复类型文本</param>
        /// <returns>拼凑的XML</returns>
        public static string ReView(string FromUserName, string ToUserName, string Content)
        {
            StringBuilder xmlBuilder = new StringBuilder();
            xmlBuilder.Append("<xml>");
            xmlBuilder.Append("<ToUserName><![CDATA[" + FromUserName + "]]></ToUserName>");
            xmlBuilder.Append("<FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>");
            xmlBuilder.Append("<CreateTime>" + CommonMethod.ConvertDateTimeInt(DateTime.Now) + "</CreateTime>");
            xmlBuilder.Append("<MsgType><![CDATA[VIEW]]></MsgType>");
            xmlBuilder.Append("<Content><![CDATA[" + Content + "]]></Content><FuncFlag>0</FuncFlag></xml>");
            return xmlBuilder.ToString();
        }


        /// <summary>
        /// 回复单图文
        /// </summary>
        /// <param name="FromUserName">发送给谁(openid)</param>
        /// <param name="ToUserName">来自谁(公众账号ID)</param>
        /// <param name="Title">标题</param>
        /// <param name="Description">详情</param>
        /// <param name="PicUrl">图片地址</param>
        /// <param name="Url">地址</param>
        /// <returns>拼凑的XML</returns>
        public static string ReArticle(string FromUserName, string ToUserName, string Title, string Description, string PicUrl, string Url)
        {
            string XML = "<xml><ToUserName><![CDATA[" + FromUserName + "]]></ToUserName><FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";//发送给谁(openid)，来自谁(公众账号ID)
            XML += "<CreateTime>" + CommonMethod.ConvertDateTimeInt(DateTime.Now) + "</CreateTime>";//回复时间戳
            XML += "<MsgType><![CDATA[news]]></MsgType><Content><![CDATA[]]></Content><ArticleCount>1</ArticleCount><Articles>";
            XML += "<item><Title><![CDATA[" + Title + "]]></Title><Description><![CDATA[" + Description + "]]></Description><PicUrl><![CDATA[" + PicUrl + "]]></PicUrl><Url><![CDATA[" + Url + "]]></Url></item>";
            XML += "</Articles><FuncFlag>0</FuncFlag></xml>";
            return XML;
        }

        /// <summary>
        /// 回复图文消息
        /// </summary>
        /// <param name="FromUserName">发送给谁(openid)</param>
        /// <param name="ToUserName">来自谁(公众账号ID)</param>
        /// <param name="ArticleCount">图文数量</param>
        /// <param name="dtArticle"></param>
        /// <returns></returns>
        public static string ReArticle(string FromUserName, string ToUserName, int ArticleCount, System.Data.DataTable dtArticle)
        {
            string XML = "<xml><ToUserName><![CDATA[" + FromUserName + "]]></ToUserName><FromUserName><![CDATA[" + ToUserName + "]]></FromUserName>";//发送给谁(openid)，来自谁(公众账号ID)
            XML += "<CreateTime>" + CommonMethod.ConvertDateTimeInt(DateTime.Now) + "</CreateTime>";//回复时间戳
            XML += "<MsgType><![CDATA[news]]></MsgType><Content><![CDATA[]]></Content><ArticleCount>" + ArticleCount + "</ArticleCount><Articles>";
            foreach (System.Data.DataRow Item in dtArticle.Rows)
            {
                XML += "<item><Title><![CDATA[" + Item["Title"] + "]]></Title><Description><![CDATA[" + Item["Description"] + "]]></Description><PicUrl><![CDATA[" + Item["PicUrl"] + "]]></PicUrl><Url><![CDATA[" + Item["Url"] + "]]></Url></item>";
            }
            XML += "</Articles><FuncFlag>0</FuncFlag></xml>";
            return XML;
        }
        #endregion


    }
}
