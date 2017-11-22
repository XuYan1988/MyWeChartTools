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
    public partial class MMessageInfo
    {
        [Key]
        public Guid MessageInfoID { get; set; }
 
        public Nullable<Guid> UserID { get; set; }
 
        public string HospitalCD { get; set; }
 
        public string MessageType { get; set; }
 
        public string MessageContent { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public virtual MCodeTable MessageType_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
    }
}
