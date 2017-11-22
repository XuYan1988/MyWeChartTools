using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    [Serializable]
    public partial class FundusScreeningVM 
    {
        [Key]
        public Guid EyeImageID { get; set; }

        //[DisplayName("编号")]
        public string ImageCode { get; set; }

        //[DisplayName("自动上传   0：手动上传   1：自动上传")]
        public bool AutoUpload { get; set; }

        //[DisplayName("区分：1.糖尿病;2.高血压;3.普通筛查")]
        public string DistinguishCD { get; set; }

        //[DisplayName("身份证")]
        public string IDCard { get; set; }

        //[DisplayName("姓名")]
        public string PatientNM { get; set; }

        //[DisplayName("年龄")]
        public Nullable<int> Age { get; set; }

        //[DisplayName("性别：1.男;2.女")]
        public string SexCD { get; set; }

        //[DisplayName("处方医生")]
        public Nullable<Guid> PrescriptionDoctorID { get; set; }
        //阅片医生
        public string UserName { get; set; }

        public string Suggestion { get; set; }

        public string ImpressionCD { get; set; }
        public string ProcessName { get; set; }
        public string Impression { get; set; }
        public string Process { get; set; }
        public Nullable<bool> EyeOffice { get; set; }
        //[DisplayName("医院")]
        public string HospitalCD { get; set; }
        //医院名称
        public string HospitalName { get; set; }
        public string CodeDesc { get; set; }
        public string DoctorName { get; set; }
        public Nullable<DateTime> InsTime { get; set; }
        //[DisplayName("眼压(左眼)")]
        public Nullable<int> IntraOcularTensionLeft { get; set; }

        //[DisplayName("血糖")]
        public Nullable<decimal> BloodSugar { get; set; }

        //[DisplayName("体重")]
        public Nullable<decimal> Weight { get; set; }

        //[DisplayName("邮箱")]
        public string Email { get; set; }

        //[DisplayName("手机")]
        public string Phone { get; set; }

        //[DisplayName("备注")]
        public string Remark { get; set; }

        //[DisplayName("眼压(右眼)")]
        public Nullable<int> IntraOcularTensionRight { get; set; }

        //[DisplayName("视力(左眼)")]
        public Nullable<decimal> VisionLeft { get; set; }

        //[DisplayName("视力(右眼)")]
        public Nullable<decimal> VisionRight { get; set; }

        //[DisplayName("矫正视力(左眼)")]
        public Nullable<decimal> CorrectedVisionLeft { get; set; }

        //[DisplayName("矫正视力(右眼)")]
        public Nullable<decimal> CorrectedVisionRight { get; set; }

        //[DisplayName("状态")]
        public string StatusCD { get; set; }

        //[DisplayName("上传时间")]
        public Nullable<DateTime> UploadTime { get; set; }

        public string ReadTime { get; set; }
        //[DisplayName("上传者")]
        public Nullable<Guid> UploadUserID { get; set; }

        //[DisplayName("性别")]
        public string SexName { get; set; }
            
        //[DisplayName("筛查区分")]
        public string DistinguishName { get; set; }

        //[DisplayName("图像整体、细节质量")]
        public string ImageDetailQualityName { get; set; }

        //[DisplayName("状态")]
        public string StatusName { get; set; }

        //阅片类型（自动或人工）
        public string ProcessTypeCD { get; set; }
        public string MisAttributionName { get; set; }
        public string Name { get; set; }

        public Nullable<Guid> UserID { get; set; }
 
    }
}
