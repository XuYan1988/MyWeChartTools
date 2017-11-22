using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �Զ���Ƭ��¼��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EAutoReadREC
    {
        public EAutoReadREC()
        {
          this.EDocSettleDTL_AutoReadIDList = new List<EDocSettleDTL>();
          this.MEyeImageAttachment_AutoReadIDList = new List<MEyeImageAttachment>();
        }
 
        [Key]
        public Guid AutoReadID { get; set; }
 
        [DisplayName("ID����")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("��Ƭ�����Ľ���")]
        public string Suggestion { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("��λ")]
        public string Unit { get; set; }
 
        [DisplayName("����ģ��ģʽ��1.�ֶ�ģ��1 ; 2.�Զ�ģ��1; 3.�Զ�ģ��2;  4.�����ģ��")]
        public string ReportTempletCD { get; set; }
 
        public bool SettleStatus { get; set; }
 
        public bool EyeOffice { get; set; }
 
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_AutoReadIDList { get; set; }
        public virtual ICollection<MEyeImageAttachment> MEyeImageAttachment_AutoReadIDList { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MCodeTable Unit_FK { get; set; }
        public virtual MCodeTable ReportTempletCD_FK { get; set; }
    }
}