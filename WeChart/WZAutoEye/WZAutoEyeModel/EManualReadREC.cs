using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �˹���Ƭ��¼��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EManualReadREC
    {
        public EManualReadREC()
        {
          this.EDocSettleDTL_ReadRECIDList = new List<EDocSettleDTL>();
        }
 
        [Key]
        public Guid ManualReadID { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> BaseNum { get; set; }
 
        [DisplayName("ϵ��")]
        public Nullable<decimal> Quotiety { get; set; }
 
        [DisplayName("��Ƭʱ��")]
        public Nullable<DateTime> ReadTime { get; set; }
 
        [DisplayName("����״̬��1.�ѽ�;0.δ��   ����Ƭҽ�����н����״̬")]
        public bool SettleStatus { get; set; }
 
        [DisplayName("�Ƿ��ۿ�:0.��;1.��")]
        public bool EyeOffice { get; set; }
 
        [DisplayName("ӡ��Ĭ��ֵ���۵�δ�������쳣")]
        public string Suggestion { get; set; }
 
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
 
        [DisplayName("����:   Impression-1:������ã�һ�긴���۵���   Impression-2:ת�ۿƽ�һ����飬ȷ�")]
        public string ImpressionCD { get; set; }
 
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_ReadRECIDList { get; set; }
        public virtual MCodeTable ImpressionCD_FK { get; set; }
        public virtual MCodeTable ReportTempletCD_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
    }
}
