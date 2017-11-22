using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ThoughtWorks.QRCode.Codec;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public static class TwoCodeHelper
    {
        /// <summary>
        /// 创建二维码
        /// </summary>
        /// 2016-7-4，yel
        /// <param name="param">创建二维码内容</param>
        /// <returns>二维码流数据</returns>
        public static MemoryStream CreateTwoCode(string param)
        {
            try
            {
                System.IO.MemoryStream ms;

                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                qrCodeEncoder.QRCodeScale = 2;
                qrCodeEncoder.QRCodeVersion = 0;
                qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                String data = param;
                ms = new System.IO.MemoryStream();
                System.Drawing.Image myimg = qrCodeEncoder.Encode(data);
                myimg.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);

                return ms;
            }
            catch
            {
                return null;
            }
        }
    }
}
