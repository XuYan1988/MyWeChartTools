using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    public partial class EManualReadRECVM
    {
        public Guid ReadID { get; set; }

        public Guid EyeImageID { get; set; }

        public string ImageCode { get; set; }

        public string PatientNM { get; set; }

        public string SexCD { get; set; }

        public Nullable<int> Age { get; set; }

        public string DistinguishCD { get; set; }

        public Nullable<DateTime> UploadTime { get; set; }

        public string CodeTableCD { get; set; }

        public Nullable<int> Type { get; set; }
        public string CodeCD { get; set; }

        public string CodeType { get; set; }

        public string CodeDesc { get; set; }

        public string CodeDesc_EN { get; set; }

        public Nullable<int> OrderNum { get; set; }

        public string Remark { get; set; }

        public string SexDesc { get; set; }

        public string DistinguishDESC { get; set; }

        public Decimal SumPoint { get; set; }

        public Decimal NotClearPoint { get; set; }

        public string ProcessTypeCD { get; set; }

        public string ImpressionCD { get; set; }

        public Nullable<DateTime> UpdTime { get; set; }

        public String  CheckTime { get; set; }

        public String HospitalName { get; set; }

        public string StatusCD { get; set; }

        public string hour { get; set; }

        public string UserName { get; set; }
        public string FirstName { get; set; }
        
        public string StatusName { get; set; }

        public string UserTypeCD { get; set; }
    }
}
