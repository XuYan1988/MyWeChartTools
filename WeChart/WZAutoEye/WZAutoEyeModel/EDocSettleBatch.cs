using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EDocSettleBatch
    {
        public EDocSettleBatch()
        {
          this.EDocSettleHDR_DocSettleBIDList = new List<EDocSettleHDR>();
        }
 
        [Key]
        public Guid DocSettleBID { get; set; }
 
        public string DocSettleBNO { get; set; }
 
        public Nullable<int> DocCount { get; set; }
 
        public Nullable<decimal> DocSumPoint { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public Nullable<DateTime> StartDate { get; set; }
 
        public Nullable<DateTime> EndDate { get; set; }
 
        public virtual ICollection<EDocSettleHDR> EDocSettleHDR_DocSettleBIDList { get; set; }
    }
}
