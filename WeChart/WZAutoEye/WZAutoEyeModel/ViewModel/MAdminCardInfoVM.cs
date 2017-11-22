using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAutoEye.AutoEyeMVC.Model
{
     public partial class MAdminCardInfoVM
    {
        public Guid AdminCardInfoID { get; set; }

        public string CardNo { get; set; }

        public string HospitalName { get; set; }

        public string HospitalCD { get; set; }

        public Nullable<decimal> CardNum { get; set; }

        public Nullable<DateTime> InsTime { get; set; }

        public Nullable<DateTime> InsTime1 { get; set; }

        public Nullable<DateTime> InsTime2 { get; set; }
    }
}
