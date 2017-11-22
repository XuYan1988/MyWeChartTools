using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ����ҽ����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EExamDoc
    {
        public EExamDoc()
        {
          this.EDocSettleDTL_ExamDocIDList = new List<EDocSettleDTL>();
          this.MExamDocAttachment_ExamDocIDList = new List<MExamDocAttachment>();
        }
 
        [Key]
        public Guid ExamDocID { get; set; }
 
        [DisplayName("��Ƭҽ��")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("����")]
        public string Suggestion { get; set; }
 
        [DisplayName("�Ƿ��ۿ�:0.��;1.��")]
        public bool EyeOffice { get; set; }
 
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
 
        [DisplayName("��Ƭ״̬")]
        public string StatusCD { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> BaseNum { get; set; }
 
        [DisplayName("ϵ��")]
        public Nullable<decimal> Quotiety { get; set; }
 
        [DisplayName("��Ƭʱ��")]
        public Nullable<DateTime> ReadTime { get; set; }
 
        [DisplayName("����״̬��1.�ѽ�;0.δ��")]
        public bool SettleStatus { get; set; }
 
        [DisplayName("����:   Impression-1:������ã�һ�긴���۵���   Impression-2:ת�ۿƽ�һ����飬ȷ�")]
        public string ImpressionCD { get; set; }
 
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_ExamDocIDList { get; set; }
        public virtual ICollection<MExamDocAttachment> MExamDocAttachment_ExamDocIDList { get; set; }
        public virtual MCodeTable ImpressionCD_FK { get; set; }
        public virtual MCodeTable StatusCD_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
    }
}
