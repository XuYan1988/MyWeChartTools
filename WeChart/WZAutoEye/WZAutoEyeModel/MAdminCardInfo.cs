using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ҽԺ�㿨��Ϣ������Ա����ϵͳ����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MAdminCardInfo
    {
        [Key]
        public Guid AdminCardInfoID { get; set; }
 
        [DisplayName("����")]
        public string CardNo { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> CardNum { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("�㿨����")]
        public string CardPassword { get; set; }
 
    }
}
