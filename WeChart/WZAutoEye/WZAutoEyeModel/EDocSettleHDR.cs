using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽ������HDR��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EDocSettleHDR
    {
        public EDocSettleHDR()
        {
          this.EDocSettleDTL_DocSettleHIDList = new List<EDocSettleDTL>();
        }
 
        [Key]
        public Guid DocSettleHID { get; set; }
 
        [DisplayName("�û�ID����Ƭҽ����")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("���ν������")]
        public Nullable<decimal> DocPoint { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("��ʼ����")]
        public Nullable<DateTime> StartDate { get; set; }
 
        [DisplayName("��������")]
        public Nullable<DateTime> EndDate { get; set; }
 
        [DisplayName("�ܵ���")]
        public Nullable<decimal> SumPoint { get; set; }
 
        [DisplayName("δ�����")]
        public Nullable<decimal> NotClearPoint { get; set; }
 
        [DisplayName("�ѽ����")]
        public Nullable<decimal> ClearPoint { get; set; }
 
        public Nullable<Guid> DocSettleBID { get; set; }
 
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_DocSettleHIDList { get; set; }
        public virtual EDocSettleBatch DocSettleBID_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
