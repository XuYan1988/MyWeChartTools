using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �˿����ͱ���Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MPort
    {
        public MPort()
        {
          this.MLoginLog_PortCDList = new List<MLoginLog>();
          this.MUserRole_PortCDList = new List<MUserRole>();
        }
 
        [Key]
        public string PortCD { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
        public virtual ICollection<MLoginLog> MLoginLog_PortCDList { get; set; }
        public virtual ICollection<MUserRole> MUserRole_PortCDList { get; set; }
    }
}
