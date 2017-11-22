using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    public partial class EDocBaseInfoVM
    {
        public Guid DocBaseInfo { get; set; }

        public Nullable<Guid> UserID { get; set; }

        public string FName { get; set; }

        public Nullable<decimal> BaseNum { get; set; }

        public Nullable<decimal> Quotiety { get; set; }

        public Nullable<DateTime> ValidTime { get; set; }
        public Nullable<DateTime> ValidTime1 { get; set; }

        public Nullable<DateTime> ValidTime2 { get; set; }

        public Nullable<DateTime> Updtime { get; set; }

        public string InputHospitalNM { get; set; }
    }
}
