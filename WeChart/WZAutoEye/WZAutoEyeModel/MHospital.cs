using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医院表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年10月23日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MHospital
    {
        public MHospital()
        {
          this.MOculistHos_HospitalCDList = new List<MOculistHos>();
          this.EHosCardInfo_HospitalCDList = new List<EHosCardInfo>();
          this.EHosSettleHDR_HospitalCDList = new List<EHosSettleHDR>();
          this.EReportFeedback_HospitalCDList = new List<EReportFeedback>();
          this.MDocHos_HospitalCDList = new List<MDocHos>();
          this.MEyeImage_HospitalCDList = new List<MEyeImage>();
          this.MHosCamera_HospitalCDList = new List<MHosCamera>();
          this.MHosConfig_HospitalCDList = new List<MHosConfig>();
          this.MHospitalProjectType_HospitalCDList = new List<MHospitalProjectType>();
          this.MMessageInfo_HospitalCDList = new List<MMessageInfo>();
          this.MOffice_HospitalCDList = new List<MOffice>();
          this.MPrescriptionDoctor_HospitalCDList = new List<MPrescriptionDoctor>();
          this.MUser_HospitalCDList = new List<MUser>();
          this.EMonthPlan_HospitalCDList = new List<EMonthPlan>();
        }
 
        [Key]
        public string HospitalCD { get; set; }
 
        [DisplayName("地址CD")]
        public string AddressCD { get; set; }
 
        [DisplayName("医院名称")]
        public string HospitalName { get; set; }
 
        [DisplayName("地址名称")]
        public string AddressName { get; set; }
 
        [DisplayName("医院名称_英文")]
        public string HospitalName_EN { get; set; }
 
        [DisplayName("地址名称_英文")]
        public string AddressName_EN { get; set; }
 
        [DisplayName("检查类型：   Hospital-1.糖网   Hospital-2.体检   Hospital-3:青光眼")]
        public string CheckTypeCD { get; set; }
 
        [DisplayName("流程类型：   ProcessType-1.人工流程   ProcessType-2.自动流程   ProcessType-3.青光眼流程")]
        public string ProcessTypeCD { get; set; }
 
        [DisplayName("能否访问   0：不可访问   1：可访问")]
        public bool CanAccess { get; set; }
 
        [DisplayName("现有点卡数")]
        public Nullable<decimal> NowCardCount { get; set; }
 
        [DisplayName("结算模式：1.点卡;2.月结")]
        public string SettleTypeCD { get; set; }
 
        [DisplayName("图像质量是否显示：0.不显示;1.显示")]
        public bool ImageQualityView { get; set; }
 
        [DisplayName("镜头情况(脏/干净)是否显示：0.不显示;1.显示")]
        public bool LensSituationView { get; set; }
 
        [DisplayName("自动报告：0.关闭;1.开启")]
        public bool AutoReport { get; set; }
 
        [DisplayName("省墨模式：0.关闭;1.开启")]
        public bool SaveInk { get; set; }
 
        [DisplayName("报告模板模式：1.手动模板1 ; 2.自动模板1; 3.自动模板2")]
        public string ReportTempletCD { get; set; }
 
        [DisplayName("出血数量显示类型：0.加减号，1.数字")]
        public Nullable<bool> BleedingNumType { get; set; }
 
        public string TemplateRemarkOne { get; set; }
 
        public string TemplateRemarkTwo { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public string CameraCD { get; set; }
 
        public string BindRuleCD { get; set; }
 
        [DisplayName("是否签约   0：否   1：是")]
        public bool Signed { get; set; }
 
        [DisplayName("签约价格")]
        public Nullable<decimal> SignedAmount { get; set; }
 
        [DisplayName("签约时间")]
        public Nullable<DateTime> SignedDate { get; set; }
 
        [DisplayName("相机权属   CameraOwner-1：医院自有   CameraOwner-2：上工提供   CameraOwner-3：相机厂商租赁   CameraOwner-99：其他")]
        public string CameraOwnerCD { get; set; }
 
        [DisplayName("医院等级   HospitalLevel-1：一级医院   HospitalLevel-2：二级医院   HospitalLevel-3：三级医院   HospitalLevel-4：社区卫生中心   HospitalLevel-5：体检中心   HospitalLevel-6：药店   HospitalLevel-99：其他")]
        public string HospitalLevelCD { get; set; }
 
        public string ReadTypeCD { get; set; }
 
        public Nullable<Guid> SalesmanID { get; set; }
 
        public string AutoReportTempletCD { get; set; }
 
        public string GlaReportTempletCD { get; set; }
 
        public virtual ICollection<MOculistHos> MOculistHos_HospitalCDList { get; set; }
        public virtual ICollection<EHosCardInfo> EHosCardInfo_HospitalCDList { get; set; }
        public virtual ICollection<EHosSettleHDR> EHosSettleHDR_HospitalCDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_HospitalCDList { get; set; }
        public virtual ICollection<MDocHos> MDocHos_HospitalCDList { get; set; }
        public virtual ICollection<MEyeImage> MEyeImage_HospitalCDList { get; set; }
        public virtual ICollection<MHosCamera> MHosCamera_HospitalCDList { get; set; }
        public virtual ICollection<MHosConfig> MHosConfig_HospitalCDList { get; set; }
        public virtual ICollection<MHospitalProjectType> MHospitalProjectType_HospitalCDList { get; set; }
        public virtual ICollection<MMessageInfo> MMessageInfo_HospitalCDList { get; set; }
        public virtual ICollection<MOffice> MOffice_HospitalCDList { get; set; }
        public virtual ICollection<MPrescriptionDoctor> MPrescriptionDoctor_HospitalCDList { get; set; }
        public virtual ICollection<MUser> MUser_HospitalCDList { get; set; }
        public virtual ICollection<EMonthPlan> EMonthPlan_HospitalCDList { get; set; }
        public virtual MCamera CameraCD_FK { get; set; }
        public virtual MSalesman SalesmanID_FK { get; set; }
        public virtual MCodeTable BindRuleCD_FK { get; set; }
        public virtual MCodeTable AutoReportTempletCD_FK { get; set; }
        public virtual MCodeTable CheckTypeCD_FK { get; set; }
        public virtual MCodeTable GlaReportTempletCD_FK { get; set; }
        public virtual MCodeTable ProcessTypeCD_FK { get; set; }
        public virtual MCodeTable SettleTypeCD_FK { get; set; }
        public virtual MCodeTable ReportTempletCD_FK { get; set; }
        public virtual MCodeTable CameraOwnerCD_FK { get; set; }
        public virtual MCodeTable HospitalLevelCD_FK { get; set; }
        public virtual MCodeTable ReadTypeCD_FK { get; set; }
        public virtual MAddress AddressCD_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
