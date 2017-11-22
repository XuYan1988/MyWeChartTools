using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽԺ����HDR��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EHosSettleHDR
    {
        public EHosSettleHDR()
        {
          this.EHosSettleDTL_HosSettleHIDList = new List<EHosSettleDTL>();
        }
 
        [Key]
        public Guid HosSettleHID { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> Price { get; set; }
 
        [DisplayName("����")]
        public Nullable<int> Quantity { get; set; }
 
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
 
        public string Remark { get; set; }
 
        public Nullable<Guid> HosSettleBID { get; set; }
 
        public virtual ICollection<EHosSettleDTL> EHosSettleDTL_HosSettleHIDList { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual EHosSettleBatch HosSettleBID_FK { get; set; }
    }
}
