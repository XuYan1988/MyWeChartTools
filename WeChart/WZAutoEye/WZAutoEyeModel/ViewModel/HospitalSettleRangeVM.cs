using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class HospitalSettleRangeVM
    {
        public Guid ReadedImgID { get; set; }

        public string PatientNM { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }

        public string UserName { get; set; }

        public string Process { get; set; }

        public Nullable<DateTime> ReadedTime { get; set; }

        public string HospitalCD { get; set; }
    }
}
