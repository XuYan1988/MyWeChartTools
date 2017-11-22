using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    public class CookieHelper
    {
        public static void Insert(string name, string value)
        {
            Insert(name, value, 1);

        }

        public static void Insert(string name, string value, int days)
        {
            HttpCookie cookie = new HttpCookie(name, value);
            cookie.Expires = DateTime.Now.AddDays(days);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        public static string Read(string name)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[name];
            if (cookie != null)
            {
                return cookie.Value;
            }
            return null;
        }
    }
}
