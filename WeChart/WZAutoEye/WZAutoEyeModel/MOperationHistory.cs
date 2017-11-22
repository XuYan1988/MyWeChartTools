using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ������־��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MOperationHistory
    {
        [Key]
        public Guid OperationHistoryID { get; set; }
 
        [DisplayName("����ģ��")]
        public string Operation { get; set; }
 
        [DisplayName("������")]
        public string Operator { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> OperateTime { get; set; }
 
        [DisplayName("�Ƿ�����ɹ�")]
        public Nullable<bool> IsSuccess { get; set; }
 
    }
}
