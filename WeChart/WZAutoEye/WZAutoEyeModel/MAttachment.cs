using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ������Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MAttachment
    {
        [Key]
        public Guid AttachmentID { get; set; }
 
        [DisplayName("������:Type1.EyeImage:�ϴ��۵�ͼ��")]
        public string ObjectType { get; set; }
 
        [DisplayName("������ID")]
        public Nullable<Guid> ObjectID { get; set; }
 
        [DisplayName("��������")]
        public string AttachmentName { get; set; }
 
        [DisplayName("������С")]
        public Nullable<int> AttachmentSize { get; set; }
 
        [DisplayName("��������")]
        public string AttachmentType { get; set; }
 
        [DisplayName("����·��")]
        public string AttachmentPath { get; set; }
 
        [DisplayName("�ϴ�ʱ��")]
        public Nullable<DateTime> UploadTime { get; set; }
 
        [DisplayName("�ϴ���")]
        public Nullable<Guid> UploadUserID { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
    }
}
