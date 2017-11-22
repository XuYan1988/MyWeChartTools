using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ϵͳ���ã�ֻ��һ����¼����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��10��12��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MSystemConfig
    {
        [Key]
        public Guid SystemConfigID { get; set; }

        [DisplayName("��Ƭģʽ��   ReadType-1������ģʽ   ReadType-2������ģʽ")]
        public string ReadTypeCD { get; set; }

        [DisplayName("�ɷ��˻أ�   0�������˻�   1�����˻�")]
        public bool CanReturn { get; set; }

        [DisplayName("�˻ش���")]
        public Nullable<int> ReturnCount { get; set; }

        [DisplayName("�㿨��ֵԤ������")]
        public Nullable<int> WarningCount { get; set; }

        [DisplayName("������ʾʱ�䣨�£�")]
        public Nullable<int> RetentionTime { get; set; }

        [DisplayName("�����ӻ�ʱ��(Сʱ)")]
        public Nullable<int> ErrorCorrectionDelayTime { get; set; }

        public bool ReturnType { get; set; }

        public virtual MCodeTable ReadTypeCD_FK { get; set; }
    }
}
