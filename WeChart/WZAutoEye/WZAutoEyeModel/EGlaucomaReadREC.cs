using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �������Ƭ��¼��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EGlaucomaReadREC
    {
        public EGlaucomaReadREC()
        {
          this.EDocSettleDTL_GlaucomaReadIDList = new List<EDocSettleDTL>();
          this.MEyeImageAttachment_GlaucomaReadIDList = new List<MEyeImageAttachment>();
        }
 
        [Key]
        public Guid GlaucomaReadID { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> BaseNum { get; set; }
 
        [DisplayName("ϵ��")]
        public Nullable<decimal> Quotiety { get; set; }
 
        [DisplayName("�˹���Ƭʱ��")]
        public Nullable<DateTime> ManualReadTime { get; set; }
 
        [DisplayName("����״̬��1.�ѽ�;0.δ��   ����Ƭҽ�����н����״̬")]
        public bool SettleStatus { get; set; }
 
        [DisplayName("�Զ���Ƭʱ��")]
        public Nullable<DateTime> AutoReadTime { get; set; }
 
        [DisplayName("ӡ��")]
        public string Suggestion { get; set; }
 
        [DisplayName("����")]
        public string Impression { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("ID����")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("�û�ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("����ģ��ģʽ��1.�ֶ�ģ��1 ; 2.�Զ�ģ��1; 3.�Զ�ģ��2;  4.�����ģ��")]
        public string ReportTempletCD { get; set; }
 
        [DisplayName("������ڲ�״̬��1.������; 2.�˹�������; 3.�Զ�������; 4.�������")]
        public string GlaucomaStatusCD { get; set; }
 
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_GlaucomaReadIDList { get; set; }
        public virtual ICollection<MEyeImageAttachment> MEyeImageAttachment_GlaucomaReadIDList { get; set; }
        public virtual MCodeTable GlaucomaStatusCD_FK { get; set; }
        public virtual MCodeTable ReportTempletCD_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
