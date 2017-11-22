using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class AreaTransferVM
    {
        public Guid EyeImageID { get; set; }
        public string ImageCode { get; set; }
        public string PatientNM { get; set; }

        public string SexDesc { get; set; }
        public int Age { get; set; }
        public string DistinguishDESC { get; set; }
        public string UserName { get; set; }
        public string HospitalName { get; set; }
        public string ReadTime { get; set; }
        public string StatusName { get; set; }

        public string Type { get; set; }

        public string EyeImageType { get; set; }
        public string UserID { get; set; }
        public string HospitalCD { get; set; }
        public string ExamDocID { get; set; }
    }
}
