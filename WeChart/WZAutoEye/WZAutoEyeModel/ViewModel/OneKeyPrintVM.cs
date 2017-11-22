using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    public partial class OneKeyPrintVM
    {
        //MEyeImage 表
        public Guid EyeImageID { get; set; }

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

        public Nullable<int> IntraOcularTensionRight { get; set; }

        public Nullable<decimal> VisionLeft { get; set; }

        public Nullable<decimal> VisionRight { get; set; }

        public Nullable<decimal> CorrectedVisionLeft { get; set; }

        public Nullable<decimal> CorrectedVisionRight { get; set; }

        public string StatusCD { get; set; }

        public Nullable<DateTime> UploadTime { get; set; }

        public Nullable<Guid> UploadUserID { get; set; }

        public Nullable<bool> IsPrinted { get; set; }

        public Nullable<Guid> ReturnDoc { get; set; }

        //MEyeImageBleeding表
        public Guid EIBleedingID { get; set; }

        public Nullable<Guid> EIAttachmentID { get; set; }

        public string BleedingAmount { get; set; }

        public Nullable<decimal> BleedingArea { get; set; }

        public Nullable<decimal> BleedingMostArea { get; set; }

        public string ExudeAmount { get; set; }

        public Nullable<decimal> ExudeArea { get; set; }

        public Nullable<decimal> ExudeMostArea { get; set; }

        public string ImageQualityCD { get; set; }

        public string DetailQualityCD { get; set; }

        public string LensSituationCD { get; set; }
        public string UnitCD { get; set; }

        //

        public string EITypeV { get; set; }
        public string EIAttachmentPath { get; set; }
        //
        public string CodeDesc { get; set; }
        public string CodeDesc_EN { get; set; }
        public string ReportTempletCD { get; set; }
        public Nullable<bool> BleedingNumType { get; set; }
        public string HospitalName { get; set; }
        //模版模式
        public string ReportCD { get; set; }
        public string Suggestion { get; set; }
        public string Impression { get; set; }
        public string Impression_EN { get; set; }

        public int EIOrder { get; set; }
        public Nullable<decimal> PPBloodSugar { get; set; }
    }
}
