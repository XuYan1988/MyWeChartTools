using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class UploadImgInfoVM
    {
        public DateTime PhotoDate { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string SexCD { get; set; }

        public string LeftOrRight { get; set; }

        public string PhotoNumber { get; set; }
    }
}
