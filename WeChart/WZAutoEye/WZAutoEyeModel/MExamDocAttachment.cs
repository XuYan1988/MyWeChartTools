using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �������۵׸���ͼ�񸽼�����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MExamDocAttachment
    {
        public MExamDocAttachment()
        {
          this.MExamDocBleeding_ExamAttachmentIDList = new List<MExamDocBleeding>();
        }
 
        [Key]
        public Guid ExamAttachmentID { get; set; }
 
        [DisplayName("�۵�ͼ�����ͣ����������ۣ�   CodeCD:UploadEI")]
        public string ExamTypeCD { get; set; }
 
        [DisplayName("ͼ�񸽼�����")]
        public string ExamAttachmentName { get; set; }
 
        [DisplayName("ͼ�񸽼���С")]
        public Nullable<int> ExamAttachmentSize { get; set; }
 
        [DisplayName("ͼ�񸽼�����")]
        public string ExamAttachmentType { get; set; }
 
        [DisplayName("ͼ�񸽼�·��")]
        public string ExamAttachmentPath { get; set; }
 
        [DisplayName("�ϴ�ʱ��")]
        public Nullable<DateTime> UploadTime { get; set; }
 
        [DisplayName("�ϴ���")]
        public Nullable<Guid> UploadUserID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> ExamDocID { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
        [DisplayName("ԭƬ�ϴ�˳��1����2��1.�����һ��ԭͼ��Ӧ������ͼ��2.����ڶ���ԭͼ��Ӧ������ͼ��")]
        public Nullable<int> UploadOrder { get; set; }
 
        public virtual ICollection<MExamDocBleeding> MExamDocBleeding_ExamAttachmentIDList { get; set; }
        public virtual EExamDoc ExamDocID_FK { get; set; }
        public virtual MCodeTable ExamTypeCD_FK { get; set; }
        public virtual MUser UploadUserID_FK { get; set; }
    }
}
