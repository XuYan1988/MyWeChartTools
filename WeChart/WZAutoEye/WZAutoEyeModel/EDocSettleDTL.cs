using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��Ƭҽ������DTL��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EDocSettleDTL
    {
        [Key]
        public Guid DocSettleDID { get; set; }
 
        [DisplayName("HID")]
        public Nullable<Guid> DocSettleHID { get; set; }
 
        [DisplayName("�˹���Ƭ��¼ID")]
        public Nullable<Guid> ReadRECID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> ExamDocID { get; set; }
 
        public Nullable<Guid> GlaucomaReadID { get; set; }
 
        public Nullable<Guid> AutoReadID { get; set; }
 
        public virtual EGlaucomaReadREC GlaucomaReadID_FK { get; set; }
        public virtual EDocSettleHDR DocSettleHID_FK { get; set; }
        public virtual EManualReadREC ReadRECID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual EExamDoc ExamDocID_FK { get; set; }
        public virtual EAutoReadREC AutoReadID_FK { get; set; }
    }
}
