using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽԺ����DTL��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EHosSettleDTL
    {
        [Key]
        public Guid HosSettleDID { get; set; }
 
        [DisplayName("HID")]
        public Nullable<Guid> HosSettleHID { get; set; }
 
        [DisplayName("����Ƭ��¼ID")]
        public Nullable<Guid> ReadedImgID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual EHosSettleHDR HosSettleHID_FK { get; set; }
        public virtual EReadedImgREC ReadedImgID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
