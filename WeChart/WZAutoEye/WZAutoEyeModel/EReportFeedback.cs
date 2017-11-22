using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ���淴������Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EReportFeedback
    {
        [Key]
        public Guid ReportFeedbackID { get; set; }
 
        [DisplayName("ID����")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("����")]
        public string Question { get; set; }
 
        [DisplayName("�ش�")]
        public string Answer { get; set; }
 
        [DisplayName("����״̬��   FeedbackStatus-1��δ����   FeedbackStatus-2��������   FeedbackStatus-3���Ѵ���")]
        public string FeedbackStatusCD { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public string QuestionTypeCD { get; set; }
 
        public string MisAttributionCD { get; set; }
 
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MCodeTable FeedbackStatusCD_FK { get; set; }
        public virtual MCodeTable QuestionTypeCD_FK { get; set; }
        public virtual MCodeTable MisAttributionCD_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
