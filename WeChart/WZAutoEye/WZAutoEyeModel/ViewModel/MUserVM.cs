using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    public partial class MUserVM
    {
        public Guid UserID { get; set; }
        public string SignatureURL { get; set; }
        public Nullable<Guid> EyeImageID { get; set; }
        public string UserName { get; set; }
        public string SumPoint { get; set; }
        public string SettledPoint { get; set; }
        public string UnsettledPoint { get; set; }
        public string ThisTimeSettlePoint { get; set; }

    }
}
