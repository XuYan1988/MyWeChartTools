using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Utility
{
    [Serializable]
    public class CommonResourceManager : BaseResourceManager
    {
        private static CommonResourceManager current = null;

        public static CommonResourceManager Current
        {
            get
            {
                if (current == null)
                    current = new CommonResourceManager();
                return current;
            }
        }

        public override string GetFileName()
        {
            return "Common_Resource.xml";
        }
    }
}
