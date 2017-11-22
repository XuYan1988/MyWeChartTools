using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class MenuVM
    {
        public string MenuCD { get; set; }

        public string ParentMenuCD { get; set; }

        public string MenuName { get; set; }

        public string MenuName_EN { get; set; }

        public string MenuKey { get; set; }

        public string MenuURL { get; set; }

        public Nullable<int> OrderNum { get; set; }

        public bool LeftOrRight { get; set; }

        public string ImgUrl { get; set; }
    }
}
