using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 眼底图像信息信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MEyeImage
    {
        public MEyeImage()
        {
          this.EAutoReadRECOculist_EyeImageIDList = new List<EAutoReadRECOculist>();
          this.EEyeImageAttachmentHis_EyeImageIDList = new List<EEyeImageAttachmentHis>();
          this.EAutoReadREC_EyeImageIDList = new List<EAutoReadREC>();
          this.EExamDoc_EyeImageIDList = new List<EExamDoc>();
          this.EGlaucomaReadREC_EyeImageIDList = new List<EGlaucomaReadREC>();
          this.EManualReadREC_EyeImageIDList = new List<EManualReadREC>();
          this.EReportFeedback_EyeImageIDList = new List<EReportFeedback>();
          this.EReadedImgREC_EyeImageIDList = new List<EReadedImgREC>();
          this.MEyeImageAttachment_EyeImageIDList = new List<MEyeImageAttachment>();
          this.EReturnHis_EyeImageIDList = new List<EReturnHis>();
          this.EManualReadRECOculist_EyeImageIDList = new List<EManualReadRECOculist>();
        }
 
        [Key]
        public Guid EyeImageID { get; set; }
 
        [DisplayName("编号")]
        public string ImageCode { get; set; }
 
        [DisplayName("自动上传   0：手动上传   1：自动上传")]
        public bool AutoUpload { get; set; }
 
        [DisplayName("区分：1.糖尿病;2.高血压;3.普通筛查")]
        public string DistinguishCD { get; set; }
 
        [DisplayName("身份证")]
        public string IDCard { get; set; }
 
        [DisplayName("姓名")]
        public string PatientNM { get; set; }
 
        [DisplayName("年龄")]
        public Nullable<int> Age { get; set; }
 
        [DisplayName("性别：1.男;2.女")]
        public string SexCD { get; set; }
 
        [DisplayName("医生姓名   由自动上传的数据中得来，不清楚是处方医生还是拍照医生")]
        public string RecordDoctorNM { get; set; }
 
        [DisplayName("处方医生")]
        public Nullable<Guid> PrescriptionDoctorID { get; set; }
 
        [DisplayName("医院")]
        public string HospitalCD { get; set; }
 
        [DisplayName("眼压(左眼)")]
        public Nullable<int> IntraOcularTensionLeft { get; set; }
 
        [DisplayName("血糖")]
        public Nullable<decimal> BloodSugar { get; set; }
 
        [DisplayName("体重")]
        public Nullable<decimal> Weight { get; set; }
 
        [DisplayName("邮箱")]
        public string Email { get; set; }
 
        [DisplayName("手机")]
        public string Phone { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        [DisplayName("眼压(右眼)")]
        public Nullable<int> IntraOcularTensionRight { get; set; }
 
        [DisplayName("视力(左眼)")]
        public Nullable<decimal> VisionLeft { get; set; }
 
        [DisplayName("视力(右眼)")]
        public Nullable<decimal> VisionRight { get; set; }
 
        [DisplayName("矫正视力(左眼)")]
        public Nullable<decimal> CorrectedVisionLeft { get; set; }
 
        [DisplayName("矫正视力(右眼)")]
        public Nullable<decimal> CorrectedVisionRight { get; set; }
 
        [DisplayName("状态")]
        public string StatusCD { get; set; }
 
        [DisplayName("上传时间")]
        public Nullable<DateTime> UploadTime { get; set; }
 
        [DisplayName("上传者")]
        public Nullable<Guid> UploadUserID { get; set; }
 
        [DisplayName("HosCameraID")]
        public Nullable<Guid> HosCameraID { get; set; }
 
        [DisplayName("是否已打印：0.未打印过,1.已打印过")]
        public Nullable<bool> IsPrinted { get; set; }
 
        [DisplayName("上次退回此眼图的阅片医生:存的UserID")]
        public Nullable<Guid> ReturnDoc { get; set; }
 
        [DisplayName("流程类型：   ProcessType-1.人工流程   ProcessType-2.自动流程   ProcessType-3.青光眼流程")]
        public string ProcessTypeCD { get; set; }
 
        [DisplayName("检查类型：   CheckType-1.糖网   CheckType-2.体检   CheckType-3:青光眼")]
        public string CheckTypeCD { get; set; }
 
        public string Complain { get; set; }
 
        public Nullable<Guid> PatientID { get; set; }
 
        public string DocLevelCD { get; set; }
 
        public Nullable<decimal> PPBloodSugar { get; set; }
 
        public bool IsReception { get; set; }
 
        public virtual ICollection<EAutoReadRECOculist> EAutoReadRECOculist_EyeImageIDList { get; set; }
        public virtual ICollection<EEyeImageAttachmentHis> EEyeImageAttachmentHis_EyeImageIDList { get; set; }
        public virtual ICollection<EAutoReadREC> EAutoReadREC_EyeImageIDList { get; set; }
        public virtual ICollection<EExamDoc> EExamDoc_EyeImageIDList { get; set; }
        public virtual ICollection<EGlaucomaReadREC> EGlaucomaReadREC_EyeImageIDList { get; set; }
        public virtual ICollection<EManualReadREC> EManualReadREC_EyeImageIDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_EyeImageIDList { get; set; }
        public virtual ICollection<EReadedImgREC> EReadedImgREC_EyeImageIDList { get; set; }
        public virtual ICollection<MEyeImageAttachment> MEyeImageAttachment_EyeImageIDList { get; set; }
        public virtual ICollection<EReturnHis> EReturnHis_EyeImageIDList { get; set; }
        public virtual ICollection<EManualReadRECOculist> EManualReadRECOculist_EyeImageIDList { get; set; }
        public virtual MCodeTable CheckTypeCD_FK { get; set; }
        public virtual MCodeTable DistinguishCD_FK { get; set; }
        public virtual MCodeTable StatusCD_FK { get; set; }
        public virtual MCodeTable SexCD_FK { get; set; }
        public virtual MCodeTable DocLevelCD_FK { get; set; }
        public virtual MCodeTable ProcessTypeCD_FK { get; set; }
        public virtual MPrescriptionDoctor PrescriptionDoctorID_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MPatient PatientID_FK { get; set; }
        public virtual MUser UploadUserID_FK { get; set; }
        public virtual MHosCamera HosCameraID_FK { get; set; }
    }
}
