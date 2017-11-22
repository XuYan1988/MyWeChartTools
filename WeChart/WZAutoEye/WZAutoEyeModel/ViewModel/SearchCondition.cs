using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public class SearchCondition
    {
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string UploadDate { get; set; }
        public string UploadDateFrom { get; set; }
        public string UploadDateTo { get; set; }
        public string ImageCode { get; set; }
        public string Distinguish { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string ImageQuality { get; set; }
        public string BleedingAmountFrom { get; set; }
        public string BleedingAmountTo { get; set; }
        public string BleedingAreaFrom { get; set; }
        public string BleedingAreaTo { get; set; }
        public string VisionFrom { get; set; }
        public string VisionTo { get; set; }
        public string IntraOcularTensionFrom { get; set; }
        public string IntraOcularTensionTo { get; set; }
        public string CorrectedVisionFrom { get; set; }
        public string CorrectedVisionTo { get; set; }
        //2017-01-10 zzc
        public string ProcessType { get; set; }
        public string DocName { get; set; }
        public string HosName { get; set; }
        public string PrescriptionName { get; set; }
        public string IsReferral { get; set; }
        public string ImpressionCD { get; set; }
        public string Suggestion { get; set; }


    }
}
