using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 码表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年10月23日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MCodeTable
    {
        public MCodeTable()
        {
          this.MEyeImageBleedingOculist_ImageQualityCDList = new List<MEyeImageBleedingOculist>();
          this.MEyeImageBleedingOculist_DetailQualityCDList = new List<MEyeImageBleedingOculist>();
          this.MEyeImageBleedingOculist_LensSituationCDList = new List<MEyeImageBleedingOculist>();
          this.MEyeImageBleedingOculist_UnitCDList = new List<MEyeImageBleedingOculist>();
          this.EEyeImageAttachmentHis_ProcessStatusCDList = new List<EEyeImageAttachmentHis>();
          this.EAutoReadREC_UnitList = new List<EAutoReadREC>();
          this.EAutoReadREC_ReportTempletCDList = new List<EAutoReadREC>();
          this.EExamDoc_ImpressionCDList = new List<EExamDoc>();
          this.EExamDoc_StatusCDList = new List<EExamDoc>();
          this.EGlaucomaReadREC_GlaucomaStatusCDList = new List<EGlaucomaReadREC>();
          this.EGlaucomaReadREC_ReportTempletCDList = new List<EGlaucomaReadREC>();
          this.MUserDocLevel_DocLevelCDList = new List<MUserDocLevel>();
          this.MUserDocLevel_ProcessTypeCDList = new List<MUserDocLevel>();
          this.MPatient_SexCDList = new List<MPatient>();
          this.EManualReadREC_ImpressionCDList = new List<EManualReadREC>();
          this.EManualReadREC_ReportTempletCDList = new List<EManualReadREC>();
          this.EReportFeedback_FeedbackStatusCDList = new List<EReportFeedback>();
          this.EReportFeedback_QuestionTypeCDList = new List<EReportFeedback>();
          this.EReportFeedback_MisAttributionCDList = new List<EReportFeedback>();
          this.EReadedImgREC_SettleTypeCDList = new List<EReadedImgREC>();
          this.EReadedImgREC_ProcessTypeCDList = new List<EReadedImgREC>();
          this.MExamDocAttachment_ExamTypeCDList = new List<MExamDocAttachment>();
          this.MEyeImage_CheckTypeCDList = new List<MEyeImage>();
          this.MEyeImage_DistinguishCDList = new List<MEyeImage>();
          this.MEyeImage_StatusCDList = new List<MEyeImage>();
          this.MEyeImage_SexCDList = new List<MEyeImage>();
          this.MEyeImage_DocLevelCDList = new List<MEyeImage>();
          this.MEyeImage_ProcessTypeCDList = new List<MEyeImage>();
          this.MEyeImageAttachment_EITypeCDList = new List<MEyeImageAttachment>();
          this.MEyeImageBleeding_UnitCDList = new List<MEyeImageBleeding>();
          this.MEyeImageBleeding_ImageQualityCDList = new List<MEyeImageBleeding>();
          this.MEyeImageBleeding_DetailQualityCDList = new List<MEyeImageBleeding>();
          this.MEyeImageBleeding_LensSituationCDList = new List<MEyeImageBleeding>();
          this.EReturnHis_DocLevelCDList = new List<EReturnHis>();
          this.MHospital_BindRuleCDList = new List<MHospital>();
          this.MHospital_AutoReportTempletCDList = new List<MHospital>();
          this.MHospital_CheckTypeCDList = new List<MHospital>();
          this.MHospital_GlaReportTempletCDList = new List<MHospital>();
          this.MHospital_ProcessTypeCDList = new List<MHospital>();
          this.MHospital_SettleTypeCDList = new List<MHospital>();
          this.MHospital_ReportTempletCDList = new List<MHospital>();
          this.MHospital_CameraOwnerCDList = new List<MHospital>();
          this.MHospital_HospitalLevelCDList = new List<MHospital>();
          this.MHospital_ReadTypeCDList = new List<MHospital>();
          this.MHospitalProjectType_ProjectTypeCDList = new List<MHospitalProjectType>();
          this.MLoginLog_LoginTypeList = new List<MLoginLog>();
          this.MMessageInfo_MessageTypeList = new List<MMessageInfo>();
          this.MSystemConfig_ReadTypeCDList = new List<MSystemConfig>();
          this.MUser_SexCDList = new List<MUser>();
          this.MUser_UserTypeCDList = new List<MUser>();
          this.MUser_JobTitleCDList = new List<MUser>();
          this.MUser_EducationCDList = new List<MUser>();
          this.MUser_ReadTypeCDList = new List<MUser>();
          this.EMonthPlan_PlanTypeCDList = new List<EMonthPlan>();
          this.EManualReadRECOculist_ReportTempletCDList = new List<EManualReadRECOculist>();
          this.EManualReadRECOculist_ImpressionCDList = new List<EManualReadRECOculist>();
          this.EDocDuty_DutyTypeCDList = new List<EDocDuty>();
          this.EAutoReadRECOculist_ReportTempletCDList = new List<EAutoReadRECOculist>();
        }
 
        [Key]
        public string CodeTableCD { get; set; }
 
        [DisplayName("键值")]
        public string CodeCD { get; set; }
 
        [DisplayName("分类")]
        public string CodeType { get; set; }
 
        [DisplayName("描述（中）")]
        public string CodeDesc { get; set; }
 
        [DisplayName("描述（英）")]
        public string CodeDesc_EN { get; set; }
 
        [DisplayName("排序")]
        public Nullable<int> OrderNum { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        public virtual ICollection<MEyeImageBleedingOculist> MEyeImageBleedingOculist_ImageQualityCDList { get; set; }
        public virtual ICollection<MEyeImageBleedingOculist> MEyeImageBleedingOculist_DetailQualityCDList { get; set; }
        public virtual ICollection<MEyeImageBleedingOculist> MEyeImageBleedingOculist_LensSituationCDList { get; set; }
        public virtual ICollection<MEyeImageBleedingOculist> MEyeImageBleedingOculist_UnitCDList { get; set; }
        public virtual ICollection<EEyeImageAttachmentHis> EEyeImageAttachmentHis_ProcessStatusCDList { get; set; }
        public virtual ICollection<EAutoReadREC> EAutoReadREC_UnitList { get; set; }
        public virtual ICollection<EAutoReadREC> EAutoReadREC_ReportTempletCDList { get; set; }
        public virtual ICollection<EExamDoc> EExamDoc_ImpressionCDList { get; set; }
        public virtual ICollection<EExamDoc> EExamDoc_StatusCDList { get; set; }
        public virtual ICollection<EGlaucomaReadREC> EGlaucomaReadREC_GlaucomaStatusCDList { get; set; }
        public virtual ICollection<EGlaucomaReadREC> EGlaucomaReadREC_ReportTempletCDList { get; set; }
        public virtual ICollection<MUserDocLevel> MUserDocLevel_DocLevelCDList { get; set; }
        public virtual ICollection<MUserDocLevel> MUserDocLevel_ProcessTypeCDList { get; set; }
        public virtual ICollection<MPatient> MPatient_SexCDList { get; set; }
        public virtual ICollection<EManualReadREC> EManualReadREC_ImpressionCDList { get; set; }
        public virtual ICollection<EManualReadREC> EManualReadREC_ReportTempletCDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_FeedbackStatusCDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_QuestionTypeCDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_MisAttributionCDList { get; set; }
        public virtual ICollection<EReadedImgREC> EReadedImgREC_SettleTypeCDList { get; set; }
        public virtual ICollection<EReadedImgREC> EReadedImgREC_ProcessTypeCDList { get; set; }
        public virtual ICollection<MExamDocAttachment> MExamDocAttachment_ExamTypeCDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_CheckTypeCDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_DistinguishCDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_StatusCDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_SexCDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_DocLevelCDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_ProcessTypeCDList { get; set; }
        public virtual ICollection<MEyeImageAttachment> MEyeImageAttachment_EITypeCDList { get; set; }
        public virtual ICollection<MEyeImageBleeding> MEyeImageBleeding_UnitCDList { get; set; }
        public virtual ICollection<MEyeImageBleeding> MEyeImageBleeding_ImageQualityCDList { get; set; }
        public virtual ICollection<MEyeImageBleeding> MEyeImageBleeding_DetailQualityCDList { get; set; }
        public virtual ICollection<MEyeImageBleeding> MEyeImageBleeding_LensSituationCDList { get; set; }
        public virtual ICollection<EReturnHis> EReturnHis_DocLevelCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_BindRuleCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_AutoReportTempletCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_CheckTypeCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_GlaReportTempletCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_ProcessTypeCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_SettleTypeCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_ReportTempletCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_CameraOwnerCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_HospitalLevelCDList { get; set; }
        public virtual ICollection<MHospital> MHospital_ReadTypeCDList { get; set; }
        public virtual ICollection<MHospitalProjectType> MHospitalProjectType_ProjectTypeCDList { get; set; }
        public virtual ICollection<MLoginLog> MLoginLog_LoginTypeList { get; set; }
        public virtual ICollection<MMessageInfo> MMessageInfo_MessageTypeList { get; set; }
        public virtual ICollection<MSystemConfig> MSystemConfig_ReadTypeCDList { get; set; }
        public virtual ICollection<MUser> MUser_SexCDList { get; set; }
        public virtual ICollection<MUser> MUser_UserTypeCDList { get; set; }
        public virtual ICollection<MUser> MUser_JobTitleCDList { get; set; }
        public virtual ICollection<MUser> MUser_EducationCDList { get; set; }
        public virtual ICollection<MUser> MUser_ReadTypeCDList { get; set; }
        public virtual ICollection<EMonthPlan> EMonthPlan_PlanTypeCDList { get; set; }
        public virtual ICollection<EManualReadRECOculist> EManualReadRECOculist_ReportTempletCDList { get; set; }
        public virtual ICollection<EManualReadRECOculist> EManualReadRECOculist_ImpressionCDList { get; set; }
        public virtual ICollection<EDocDuty> EDocDuty_DutyTypeCDList { get; set; }
        public virtual ICollection<EAutoReadRECOculist> EAutoReadRECOculist_ReportTempletCDList { get; set; }
    }
}
