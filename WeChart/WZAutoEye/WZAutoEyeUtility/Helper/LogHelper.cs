using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public static class LogHelper
    {
        public static void WriteTextLog(string action, string strMessage, DateTime time)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Log\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string fileFullPath = path + time.ToString("yyyy-MM-dd") + ".Web.txt";
            StringBuilder str = new StringBuilder();
            str.Append("Time:    " + time.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");
            str.Append("Action:  " + action + "\r\n");
            str.Append("Message: " + strMessage + "\r\n");
            str.Append("-----------------------------------------------------------\r\n\r\n");
            StreamWriter sw;
            if (!File.Exists(fileFullPath))
            {
                sw = File.CreateText(fileFullPath);
            }
            else
            {
                sw = File.AppendText(fileFullPath);
            }
            sw.WriteLine(str.ToString());
            sw.Close();
        }

        public static void WriteReturnLog(string action, string strMessage, DateTime time)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + @"Log\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            string fileFullPath = path + "回退记录" + time.ToString("yyyy-MM-dd") + ".Web.txt";
            StringBuilder str = new StringBuilder();
            str.Append("Time:    " + time.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\r\n");
            str.Append("Action:  " + action + "\r\n");
            str.Append("Message: " + strMessage + "\r\n");
            str.Append("-----------------------------------------------------------\r\n\r\n");
            StreamWriter sw;
            if (!File.Exists(fileFullPath))
            {
                sw = File.CreateText(fileFullPath);
            }
            else
            {
                sw = File.AppendText(fileFullPath);
            }
            sw.WriteLine(str.ToString());
            sw.Close();
        }
    }
}
