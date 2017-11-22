using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽ��������Ϣ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EDocBaseInfo
    {
        [Key]
        public Guid DocBaseInfo { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> BaseNum { get; set; }
 
        [DisplayName("ϵ��")]
        public Nullable<decimal> Quotiety { get; set; }
 
        [DisplayName("�û�ID����Ƭҽ����")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("��Чʱ��")]
        public Nullable<DateTime> ValidTime { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> Updtime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
    }
}
