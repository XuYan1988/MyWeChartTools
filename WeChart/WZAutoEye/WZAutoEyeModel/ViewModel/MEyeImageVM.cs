using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{

    [Serializable]
    public partial class MEyeImageVM
    {
        public Guid EyeImageID { get; set; }
        public Guid ManualReadID { get; set; }
        public Guid ExamDocID { get; set; }
        public string ImageCode { get; set; }
        public bool AutoUpload { get; set; }
        public string DistinguishCD { get; set; }
        public string IDCard { get; set; }
        public string PatientNM { get; set; }
        public Nullable<int> Age { get; set; }
        public string SexCD { get; set; }
        public Nullable<Guid> PrescriptionDoctorID { get; set; }
        public string HospitalCD { get; set; }
        public Nullable<int> IntraOcularTensionLeft { get; set; }
        public Nullable<decimal> BloodSugar { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Remark { get; set; }
        public Nullable<int> IntraOcularTensionRight { get; set; }
        public Nullable<decimal> VisionLeft { get; set; }
        public Nullable<decimal> VisionRight { get; set; }
        public Nullable<decimal> CorrectedVisionLeft { get; set; }
        public Nullable<decimal> CorrectedVisionRight { get; set; }
        public string StatusCD { get; set; }
        public Nullable<DateTime> UploadTime { get; set; }
        public string Unit { get; set; }
        public Nullable<Guid> UploadUserID { get; set; }
 
        public Nullable<decimal> BaseNum { get; set; }

        public Nullable<decimal> Quotiety { get; set; }

        public Nullable<DateTime> InsTime { get; set; }

        public Nullable<DateTime> InsTime1 { get; set; }

        public Nullable<DateTime> InsTime2 { get; set; }

        public Nullable<bool> IsPrinted { get; set; }

        public string EyeOffice { get; set; }

        public string Suggestion { get; set; }
        public string ImpressionCD { get; set; }
        public Nullable<DateTime> ReadTime { get; set; }
        public string ProcessTypeCD { get; set; }

        public string Complain { get; set; }

        public Guid PatientID { get; set; }

        public String CheckTime { get; set; }

    }
}
