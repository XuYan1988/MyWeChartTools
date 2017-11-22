using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��¼��־����¼��¼�ߣ���¼ʱ�䣬��¼�����˳���Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MLoginLog
    {
        [Key]
        public Guid LoginLogID { get; set; }
 
        [DisplayName("��¼��")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("LoginType-1:��¼;LoginType-2:�˳�")]
        public string LoginType { get; set; }
 
        [DisplayName("��¼ʱ��")]
        public Nullable<DateTime> LoginTime { get; set; }
 
        [DisplayName("��¼�˿�")]
        public string PortCD { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MPort PortCD_FK { get; set; }
        public virtual MCodeTable LoginType_FK { get; set; }
    }
}
