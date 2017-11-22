using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �����۵׸���ͼ�������Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MExamDocBleeding
    {
        [Key]
        public Guid ExBleedingID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> ExamAttachmentID { get; set; }
 
        [DisplayName("Ӱ������ֵ-C/D��Ĭ��ֵ��0.3")]
        public string C_D { get; set; }
 
        [DisplayName("Ӱ������ֵ-������̬��Ĭ��ֵ����")]
        public string DiskEdgeShape { get; set; }
 
        [DisplayName("Ӱ������ֵ-A/C��Ĭ��ֵ���п�")]
        public string A_V { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ư���_��Ѫ��Ĭ��ֵ��δ������")]
        public string MacularRegion_Hemorrhage { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ư���_������Ĭ��ֵ��δ������")]
        public string MacularRegion_Exudation { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ܱ�����Ĥ_��Ѫ��Ĭ��ֵ��δ������")]
        public string PeripheralRetina_Hemorrhage { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ܱ�����Ĥ_������Ĭ��ֵ��δ������")]
        public string PeripheralRetina_Exudation { get; set; }
 
        [DisplayName("Ӱ������ֵ-������Ĭ��ֵ����")]
        public string Other { get; set; }
 
        public virtual MExamDocAttachment ExamAttachmentID_FK { get; set; }
    }
}
