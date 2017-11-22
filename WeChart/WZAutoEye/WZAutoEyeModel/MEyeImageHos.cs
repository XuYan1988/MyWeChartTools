using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    public partial class MEyeImageHos
    {

        public Guid EyeImageID { get; set; }
        public string ImageCode { get; set; }
        public bool AutoUpload { get; set; }
        public string DistinguishCD { get; set; }
        public string IDCard { get; set; }
        public string PatientNM { get; set; }
        public Nullable<int> Age { get; set; }
        public string SexCD { get; set; }
        public string RecordDoctorNM { get; set; }
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
        public Nullable<Guid> UploadUserID { get; set; }
        public Nullable<Guid> HosCameraID { get; set; }
        public Nullable<bool> IsPrinted { get; set; }
        public Nullable<Guid> ReturnDoc { get; set; }
        public string ProcessTypeCD { get; set; }
        public string CheckTypeCD { get; set; }




        public string AddressCD { get; set; }
        public string HospitalName { get; set; }
        public string AddressName { get; set; }
        public string HospitalName_EN { get; set; }
        public string AddressName_EN { get; set; }
        public bool CanAccess { get; set; }
        public Nullable<decimal> NowCardCount { get; set; }
        public string SettleTypeCD { get; set; }
        public bool ImageQualityView { get; set; }
        public bool LensSituationView { get; set; }
        public bool AutoReport { get; set; }
        public bool SaveInk { get; set; }
        public string ReportTempletCD { get; set; }
        public Nullable<bool> BleedingNumType { get; set; }
    }
}
