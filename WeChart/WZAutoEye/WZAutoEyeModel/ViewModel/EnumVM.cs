using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class EnumVM
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }
    }
}
