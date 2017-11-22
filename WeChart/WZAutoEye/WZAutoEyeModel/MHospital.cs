using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽԺ����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��10��23��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
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
 
        [DisplayName("��ַCD")]
        public string AddressCD { get; set; }
 
        [DisplayName("ҽԺ����")]
        public string HospitalName { get; set; }
 
        [DisplayName("��ַ����")]
        public string AddressName { get; set; }
 
        [DisplayName("ҽԺ����_Ӣ��")]
        public string HospitalName_EN { get; set; }
 
        [DisplayName("��ַ����_Ӣ��")]
        public string AddressName_EN { get; set; }
 
        [DisplayName("������ͣ�   Hospital-1.����   Hospital-2.���   Hospital-3:�����")]
        public string CheckTypeCD { get; set; }
 
        [DisplayName("�������ͣ�   ProcessType-1.�˹�����   ProcessType-2.�Զ�����   ProcessType-3.���������")]
        public string ProcessTypeCD { get; set; }
 
        [DisplayName("�ܷ����   0�����ɷ���   1���ɷ���")]
        public bool CanAccess { get; set; }
 
        [DisplayName("���е㿨��")]
        public Nullable<decimal> NowCardCount { get; set; }
 
        [DisplayName("����ģʽ��1.�㿨;2.�½�")]
        public string SettleTypeCD { get; set; }
 
        [DisplayName("ͼ�������Ƿ���ʾ��0.����ʾ;1.��ʾ")]
        public bool ImageQualityView { get; set; }
 
        [DisplayName("��ͷ���(��/�ɾ�)�Ƿ���ʾ��0.����ʾ;1.��ʾ")]
        public bool LensSituationView { get; set; }
 
        [DisplayName("�Զ����棺0.�ر�;1.����")]
        public bool AutoReport { get; set; }
 
        [DisplayName("ʡīģʽ��0.�ر�;1.����")]
        public bool SaveInk { get; set; }
 
        [DisplayName("����ģ��ģʽ��1.�ֶ�ģ��1 ; 2.�Զ�ģ��1; 3.�Զ�ģ��2")]
        public string ReportTempletCD { get; set; }
 
        [DisplayName("��Ѫ������ʾ���ͣ�0.�Ӽ��ţ�1.����")]
        public Nullable<bool> BleedingNumType { get; set; }
 
        public string TemplateRemarkOne { get; set; }
 
        public string TemplateRemarkTwo { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public string CameraCD { get; set; }
 
        public string BindRuleCD { get; set; }
 
        [DisplayName("�Ƿ�ǩԼ   0����   1����")]
        public bool Signed { get; set; }
 
        [DisplayName("ǩԼ�۸�")]
        public Nullable<decimal> SignedAmount { get; set; }
 
        [DisplayName("ǩԼʱ��")]
        public Nullable<DateTime> SignedDate { get; set; }
 
        [DisplayName("���Ȩ��   CameraOwner-1��ҽԺ����   CameraOwner-2���Ϲ��ṩ   CameraOwner-3�������������   CameraOwner-99������")]
        public string CameraOwnerCD { get; set; }
 
        [DisplayName("ҽԺ�ȼ�   HospitalLevel-1��һ��ҽԺ   HospitalLevel-2������ҽԺ   HospitalLevel-3������ҽԺ   HospitalLevel-4��������������   HospitalLevel-5���������   HospitalLevel-6��ҩ��   HospitalLevel-99������")]
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
