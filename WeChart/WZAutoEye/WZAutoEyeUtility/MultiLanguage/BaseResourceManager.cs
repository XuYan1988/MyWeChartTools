using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Xml;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    [Serializable]
    public class BaseResourceManager
    {
        protected static string DEFAULT_LANGUAGE = "zh-cn";
        public static string LangCacheKey = "H-Language";

        public virtual string GetFileName()
        {
            return string.Empty;
        }

        public static void InitialLanguage()
        {
            string Currentlang = CookieHelper.Read(BaseResourceManager.LangCacheKey);
            if (Currentlang == null)
            {
                CookieHelper.Insert(BaseResourceManager.LangCacheKey, DEFAULT_LANGUAGE);
            }
            else { }
        }

        public string GetString(string key)
        {
            //得到当前的默认语言
            string cacheKey = this.DefaultLanguage + this.GetFileName();
            object resource = HttpContext.Current.Cache.Get(cacheKey);
            if (resource == null)
            {
                //装载指定的语言数据
                Dictionary<string, string> res = GetResource();
                HttpContext.Current.Cache.Add(cacheKey, res, new CacheDependency(GetFilePath()), DateTime.MaxValue, Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                resource = res;
            }

            Dictionary<string, string> res1 = resource as Dictionary<string, string>;
            try
            {
                return res1[key];
            }
            catch
            {
                return key;
            }
        }

        public string GetString(string key, string language)
        {
            //得到当前的默认语言
            string cacheKey = language + this.GetFileName();
            object resource = HttpContext.Current.Cache.Get(cacheKey);
            if (resource == null)
            {
                //装载指定的语言数据
                Dictionary<string, string> res = GetResource(language);
                HttpContext.Current.Cache.Add(cacheKey, res, new CacheDependency(GetFilePath(language)), DateTime.MaxValue, Cache.NoSlidingExpiration, CacheItemPriority.High, null);
                resource = res;
            }

            Dictionary<string, string> res1 = resource as Dictionary<string, string>;
            try
            {
                return res1[key];
            }
            catch
            {
                return key;
            }
        }

        public string DefaultLanguage
        {
            get
            {
                object lang = CookieHelper.Read(LangCacheKey);
                if (lang != null)
                {
                    DEFAULT_LANGUAGE = lang.ToString();
                }
                else
                {
                    CookieHelper.Insert(LangCacheKey, DEFAULT_LANGUAGE);
                }
                return DEFAULT_LANGUAGE;
            }
        }

        public string GetFilePath()
        {
            return GetFilePath(DEFAULT_LANGUAGE);
        }

        public string GetFilePath(string language)
        {
            string fileName = GetFileName();
            string filePath = HttpContext.Current.Server.MapPath("~/Languages/" + language + "/{0}");
            filePath = string.Format(filePath, fileName);
            return filePath;
        }

        private Dictionary<string, string> GetResource()
        {
            return GetResource(DEFAULT_LANGUAGE);
        }

        private Dictionary<string, string> GetResource(string language)
        {
            string defaultLanguage = language;
            Dictionary<string, string> resources = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
            XmlDocument d = new XmlDocument();
            d.Load(GetFilePath(language));
            foreach (XmlNode n in d.SelectSingleNode("root").ChildNodes)
            {
                if (n.NodeType != XmlNodeType.Comment)
                {
                    string key = n.Attributes["name"].Value.ToLower();
                    if (!resources.ContainsKey(key))
                    {
                        resources.Add(key, n.InnerText);
                    }
                    else
                    {
                        resources[key] = n.InnerText;
                    }
                }
            }
            return resources;
        }
    }
}
