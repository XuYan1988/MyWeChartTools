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
    public partial class EHosSettleBatch
    {
        public EHosSettleBatch()
        {
          this.EHosSettleHDR_HosSettleBIDList = new List<EHosSettleHDR>();
        }
 
        [Key]
        public Guid HosSettleBID { get; set; }
 
        public string HosSettleBNO { get; set; }
 
        public Nullable<int> HosCount { get; set; }
 
        public Nullable<decimal> HosSum { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public Nullable<DateTime> StartDate { get; set; }
 
        public Nullable<DateTime> EndDate { get; set; }
 
        public virtual ICollection<EHosSettleHDR> EHosSettleHDR_HosSettleBIDList { get; set; }
    }
}
