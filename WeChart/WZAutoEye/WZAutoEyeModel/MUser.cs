using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 用户表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年11月08日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MUser
    {
        public MUser()
        {
          this.MOculistHos_UserIDList = new List<MOculistHos>();
          this.EEyeImageAttachmentHis_InsUserIDList = new List<EEyeImageAttachmentHis>();
          this.EEyeImageAttachmentHis_UpdUserIDList = new List<EEyeImageAttachmentHis>();
          this.EAutoReadREC_UpdUserIDList = new List<EAutoReadREC>();
          this.EAutoReadREC_InsUserIDList = new List<EAutoReadREC>();
          this.EEyeImageBleedingHis_InsUserIDList = new List<EEyeImageBleedingHis>();
          this.EEyeImageBleedingHis_UpdUserIDList = new List<EEyeImageBleedingHis>();
          this.EDocBaseInfo_UserIDList = new List<EDocBaseInfo>();
          this.EDocBaseInfo_UpdUserIDList = new List<EDocBaseInfo>();
          this.EDocBaseInfo_InsUserIDList = new List<EDocBaseInfo>();
          this.EDocSettleDTL_InsUserIDList = new List<EDocSettleDTL>();
          this.EDocSettleDTL_UpdUserIDList = new List<EDocSettleDTL>();
          this.EDocSettleHDR_UserIDList = new List<EDocSettleHDR>();
          this.EDocSettleHDR_InsUserIDList = new List<EDocSettleHDR>();
          this.EDocSettleHDR_UpdUserIDList = new List<EDocSettleHDR>();
          this.EExamDoc_UserIDList = new List<EExamDoc>();
          this.EExamDoc_UpdUserIDList = new List<EExamDoc>();
          this.EExamDoc_InsUserIDList = new List<EExamDoc>();
          this.EGlaucomaReadREC_UserIDList = new List<EGlaucomaReadREC>();
          this.EGlaucomaReadREC_InsUserIDList = new List<EGlaucomaReadREC>();
          this.EGlaucomaReadREC_UpdUserIDList = new List<EGlaucomaReadREC>();
          this.MUserDocLevel_UserIDList = new List<MUserDocLevel>();
          this.EHosCardInfo_UpdUserIDList = new List<EHosCardInfo>();
          this.EHosCardInfo_InsUserIDList = new List<EHosCardInfo>();
          this.EHosSettleDTL_InsUserIDList = new List<EHosSettleDTL>();
          this.EHosSettleDTL_UpdUserIDList = new List<EHosSettleDTL>();
          this.EHosSettleHDR_UpdUserIDList = new List<EHosSettleHDR>();
          this.EHosSettleHDR_InsUserIDList = new List<EHosSettleHDR>();
          this.EManualReadREC_UpdUserIDList = new List<EManualReadREC>();
          this.EManualReadREC_InsUserIDList = new List<EManualReadREC>();
          this.EManualReadREC_UserIDList = new List<EManualReadREC>();
          this.EReportFeedback_InsUserIDList = new List<EReportFeedback>();
          this.EReportFeedback_UpdUserIDList = new List<EReportFeedback>();
          this.ENotice_UserIDList = new List<ENotice>();
          this.ENotice_UpdUserIDList = new List<ENotice>();
          this.ENotice_InsUserIDList = new List<ENotice>();
          this.EReadedImgREC_UserIDList = new List<EReadedImgREC>();
          this.EReadedImgREC_UpdUserIDList = new List<EReadedImgREC>();
          this.EReadedImgREC_InsUserIDList = new List<EReadedImgREC>();
          this.MDocHos_UserIDList = new List<MDocHos>();
          this.MExamDocAttachment_UploadUserIDList = new List<MExamDocAttachment>();
          this.MEyeImage_UploadUserIDList = new List<MEyeImage>();
          this.MEyeImageAttachment_UploadUserIDList = new List<MEyeImageAttachment>();
          this.EReturnHis_ReturnUserIDList = new List<EReturnHis>();
          this.EReturnHis_InsUserIDList = new List<EReturnHis>();
          this.EReturnHis_UpdUserIDList = new List<EReturnHis>();
          this.MHospital_InsUserIDList = new List<MHospital>();
          this.MHospital_UpdUserIDList = new List<MHospital>();
          this.MLoginLog_UserIDList = new List<MLoginLog>();
          this.MMessageInfo_UserIDList = new List<MMessageInfo>();
          this.MSalesman_InsUserIDList = new List<MSalesman>();
          this.MSalesman_UpdUserIDList = new List<MSalesman>();
          this.MRegion_InsUserIDList = new List<MRegion>();
          this.MRegion_UpdUserIDList = new List<MRegion>();
          this.MRegionAddress_InsUserIDList = new List<MRegionAddress>();
          this.MRegionAddress_UpdUserIDList = new List<MRegionAddress>();
          this.EMonthPlan_InsUserIDList = new List<EMonthPlan>();
          this.EMonthPlan_UpdUserIDList = new List<EMonthPlan>();
          this.MUserRole_UserIDList = new List<MUserRole>();
          this.EOrderPlan_InsUserIDList = new List<EOrderPlan>();
          this.EOrderPlan_UpdUserIDList = new List<EOrderPlan>();
          this.EManualReadRECOculist_InsUserIDList = new List<EManualReadRECOculist>();
          this.EManualReadRECOculist_UpdUserIDList = new List<EManualReadRECOculist>();
          this.EDocDuty_UserIDList = new List<EDocDuty>();
          this.EAbandonHis_InsUserIDList = new List<EAbandonHis>();
          this.EAbandonHis_UpdUserIDList = new List<EAbandonHis>();
          this.EAutoReadRECOculist_InsUserIDList = new List<EAutoReadRECOculist>();
          this.EAutoReadRECOculist_UpdUserIDList = new List<EAutoReadRECOculist>();
        }
 
        [Key]
        public Guid UserID { get; set; }
 
        [DisplayName("用户姓名的姓")]
        public string UserName { get; set; }
 
        [DisplayName("性别：0.女;1.男")]
        public string SexCD { get; set; }
 
        [DisplayName("身份证号")]
        public string IDCard { get; set; }
 
        [DisplayName("生日")]
        public Nullable<DateTime> Birthday { get; set; }
 
        [DisplayName("电话号码")]
        public string Phone { get; set; }
 
        [DisplayName("电子邮箱")]
        public string Email { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("输入的医院名称（阅片医生）")]
        public string InputHospitalNM { get; set; }
 
        [DisplayName("科室CD")]
        public string OfficeCD { get; set; }
 
        [DisplayName("输入的科室名称（阅片医生）")]
        public string InputOfficeNM { get; set; }
 
        [DisplayName("工作年限")]
        public Nullable<int> WorkPeriod { get; set; }
 
        [DisplayName("职称:0.主任医师;1.副主任医师;2.主治医师;3.住院医师;4.其他")]
        public string JobTitleCD { get; set; }
 
        [DisplayName("学历:0.学士;1.硕士;2.博士")]
        public string EducationCD { get; set; }
 
        [DisplayName("特长")]
        public string Speciality { get; set; }
 
        [DisplayName("照片")]
        public string PhotoURL { get; set; }
 
        [DisplayName("登陆用户名")]
        public string LoginID { get; set; }
 
        [DisplayName("密码")]
        public string Passwd { get; set; }
 
        [DisplayName("医生签名")]
        public string SignatureURL { get; set; }
 
        [DisplayName("允许登陆   0：不可访问   1：可访问")]
        public bool CanLogin { get; set; }
 
        [DisplayName("用户类型：   UserType-1：医院账户   UserType-2：医生账户   UserType-3：管理员账户")]
        public string UserTypeCD { get; set; }
 
        [DisplayName("用户姓名的名")]
        public string FirstName { get; set; }
 
        [DisplayName("更新日期")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建日期")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("阅片医生每天实时退回次数")]
        public int DocReturnCount { get; set; }
 
        public string MobilePhone { get; set; }
 
        public string ReadTypeCD { get; set; }
 
        public string WXID { get; set; }
 
        public virtual ICollection<MOculistHos> MOculistHos_UserIDList { get; set; }
        public virtual ICollection<EEyeImageAttachmentHis> EEyeImageAttachmentHis_InsUserIDList { get; set; }
        public virtual ICollection<EEyeImageAttachmentHis> EEyeImageAttachmentHis_UpdUserIDList { get; set; }
        public virtual ICollection<EAutoReadREC> EAutoReadREC_UpdUserIDList { get; set; }
        public virtual ICollection<EAutoReadREC> EAutoReadREC_InsUserIDList { get; set; }
        public virtual ICollection<EEyeImageBleedingHis> EEyeImageBleedingHis_InsUserIDList { get; set; }
        public virtual ICollection<EEyeImageBleedingHis> EEyeImageBleedingHis_UpdUserIDList { get; set; }
        public virtual ICollection<EDocBaseInfo> EDocBaseInfo_UserIDList { get; set; }
        public virtual ICollection<EDocBaseInfo> EDocBaseInfo_UpdUserIDList { get; set; }
        public virtual ICollection<EDocBaseInfo> EDocBaseInfo_InsUserIDList { get; set; }
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_InsUserIDList { get; set; }
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_UpdUserIDList { get; set; }
        public virtual ICollection<EDocSettleHDR> EDocSettleHDR_UserIDList { get; set; }
        public virtual ICollection<EDocSettleHDR> EDocSettleHDR_InsUserIDList { get; set; }
        public virtual ICollection<EDocSettleHDR> EDocSettleHDR_UpdUserIDList { get; set; }
        public virtual ICollection<EExamDoc> EExamDoc_UserIDList { get; set; }
        public virtual ICollection<EExamDoc> EExamDoc_UpdUserIDList { get; set; }
        public virtual ICollection<EExamDoc> EExamDoc_InsUserIDList { get; set; }
        public virtual ICollection<EGlaucomaReadREC> EGlaucomaReadREC_UserIDList { get; set; }
        public virtual ICollection<EGlaucomaReadREC> EGlaucomaReadREC_InsUserIDList { get; set; }
        public virtual ICollection<EGlaucomaReadREC> EGlaucomaReadREC_UpdUserIDList { get; set; }
        public virtual ICollection<MUserDocLevel> MUserDocLevel_UserIDList { get; set; }
        public virtual ICollection<EHosCardInfo> EHosCardInfo_UpdUserIDList { get; set; }
        public virtual ICollection<EHosCardInfo> EHosCardInfo_InsUserIDList { get; set; }
        public virtual ICollection<EHosSettleDTL> EHosSettleDTL_InsUserIDList { get; set; }
        public virtual ICollection<EHosSettleDTL> EHosSettleDTL_UpdUserIDList { get; set; }
        public virtual ICollection<EHosSettleHDR> EHosSettleHDR_UpdUserIDList { get; set; }
        public virtual ICollection<EHosSettleHDR> EHosSettleHDR_InsUserIDList { get; set; }
        public virtual ICollection<EManualReadREC> EManualReadREC_UpdUserIDList { get; set; }
        public virtual ICollection<EManualReadREC> EManualReadREC_InsUserIDList { get; set; }
        public virtual ICollection<EManualReadREC> EManualReadREC_UserIDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_InsUserIDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_UpdUserIDList { get; set; }
        public virtual ICollection<ENotice> ENotice_UserIDList { get; set; }
        public virtual ICollection<ENotice> ENotice_UpdUserIDList { get; set; }
        public virtual ICollection<ENotice> ENotice_InsUserIDList { get; set; }
        public virtual ICollection<EReadedImgREC> EReadedImgREC_UserIDList { get; set; }
        public virtual ICollection<EReadedImgREC> EReadedImgREC_UpdUserIDList { get; set; }
        public virtual ICollection<EReadedImgREC> EReadedImgREC_InsUserIDList { get; set; }
        public virtual ICollection<MDocHos> MDocHos_UserIDList { get; set; }
        public virtual ICollection<MExamDocAttachment> MExamDocAttachment_UploadUserIDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_UploadUserIDList { get; set; }
        public virtual ICollection<MEyeImageAttachment> MEyeImageAttachment_UploadUserIDList { get; set; }
        public virtual ICollection<EReturnHis> EReturnHis_ReturnUserIDList { get; set; }
        public virtual ICollection<EReturnHis> EReturnHis_InsUserIDList { get; set; }
        public virtual ICollection<EReturnHis> EReturnHis_UpdUserIDList { get; set; }
        public virtual ICollection<MHospital> MHospital_InsUserIDList { get; set; }
        public virtual ICollection<MHospital> MHospital_UpdUserIDList { get; set; }
        public virtual ICollection<MLoginLog> MLoginLog_UserIDList { get; set; }
        public virtual ICollection<MMessageInfo> MMessageInfo_UserIDList { get; set; }
        public virtual ICollection<MSalesman> MSalesman_InsUserIDList { get; set; }
        public virtual ICollection<MSalesman> MSalesman_UpdUserIDList { get; set; }
        public virtual ICollection<MRegion> MRegion_InsUserIDList { get; set; }
        public virtual ICollection<MRegion> MRegion_UpdUserIDList { get; set; }
        public virtual ICollection<MRegionAddress> MRegionAddress_InsUserIDList { get; set; }
        public virtual ICollection<MRegionAddress> MRegionAddress_UpdUserIDList { get; set; }
        public virtual ICollection<EMonthPlan> EMonthPlan_InsUserIDList { get; set; }
        public virtual ICollection<EMonthPlan> EMonthPlan_UpdUserIDList { get; set; }
        public virtual ICollection<MUserRole> MUserRole_UserIDList { get; set; }
        public virtual ICollection<EOrderPlan> EOrderPlan_InsUserIDList { get; set; }
        public virtual ICollection<EOrderPlan> EOrderPlan_UpdUserIDList { get; set; }
        public virtual ICollection<EManualReadRECOculist> EManualReadRECOculist_InsUserIDList { get; set; }
        public virtual ICollection<EManualReadRECOculist> EManualReadRECOculist_UpdUserIDList { get; set; }
        public virtual ICollection<EDocDuty> EDocDuty_UserIDList { get; set; }
        public virtual ICollection<EAbandonHis> EAbandonHis_InsUserIDList { get; set; }
        public virtual ICollection<EAbandonHis> EAbandonHis_UpdUserIDList { get; set; }
        public virtual ICollection<EAutoReadRECOculist> EAutoReadRECOculist_InsUserIDList { get; set; }
        public virtual ICollection<EAutoReadRECOculist> EAutoReadRECOculist_UpdUserIDList { get; set; }
        public virtual MCodeTable SexCD_FK { get; set; }
        public virtual MCodeTable UserTypeCD_FK { get; set; }
        public virtual MCodeTable JobTitleCD_FK { get; set; }
        public virtual MCodeTable EducationCD_FK { get; set; }
        public virtual MCodeTable ReadTypeCD_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MOffice OfficeCD_FK { get; set; }
    }
}
