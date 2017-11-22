using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public static class TwoCodeBar 
    {
        public static string GetTwoCodeBars(string url)
        {
            string param = url;

            MemoryStream ms = TwoCodeHelper.CreateTwoCode(param);

            byte[] by = ms.ToArray();


            #region 把二维码流数据转换为图片存入FileUpload中
            System.IO.MemoryStream s = new MemoryStream(by);
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(s);
            //按规则生成路径
            String serverUri =ConfigurationManager.AppSettings["EyePicPath"] + "erweima" + "/" + DateTime.Now.ToString("yyyyMMdd") + "/";

            //判断路径是否存在，若不存在则创建
            if (Directory.Exists(System.Web.HttpContext.Current.Server.MapPath(serverUri)) == false)
            {
                Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath(serverUri));
            }
            else
            {

            }
            //获取物理路径
            string path = System.Web.HttpContext.Current.Server.MapPath(serverUri);
            //创建图片名称
            string picname = DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".Gif";
            //把图片按jpg格式存入创建的路径中
            bitmap.Save(path + picname, ImageFormat.Gif);
            string img = serverUri + picname;

            #endregion

            return img;
        }
    }
}
