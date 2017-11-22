using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽԺ�㿨��Ϣ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EHosCardInfo
    {
        [Key]
        public Guid HosCardInfoID { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("����")]
        public string CardNo { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> CardNum { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
    }
}
