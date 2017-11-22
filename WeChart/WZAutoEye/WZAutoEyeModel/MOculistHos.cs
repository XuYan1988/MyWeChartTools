using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ƬԴ�ۿ�ҽ�����ձ���Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MOculistHos
    {
        [Key]
        public Guid OculistHosID { get; set; }
 
        [DisplayName("�û�ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
    }
}
