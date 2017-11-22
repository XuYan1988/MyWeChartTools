using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class MHospitalEyesResultImageVM
    {
        public string ProcessTypeCD { get; set; }
        public string SettleTypeCD { get; set; }
        public string ReportTempletCD { get; set; }
    }
}
