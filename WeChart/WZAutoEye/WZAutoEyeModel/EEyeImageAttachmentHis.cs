using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EEyeImageAttachmentHis
    {
        [Key]
        public Guid EIAttachmentHisID { get; set; }
 
        public Nullable<Guid> EyeImageID { get; set; }
 
        public Nullable<Guid> EIAttachmentID { get; set; }
 
        public string EIAttachmentPath { get; set; }
 
        public string EIAttachmentDRPath { get; set; }
 
        public string EIAttachmentMISPath { get; set; }
 
        public string EIAttachmentMISCoorPath { get; set; }
 
        public string EIAttachmentERRPath { get; set; }
 
        public string EIAttachmentERRCoorPath { get; set; }
 
        public string ProcessStatusCD { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MCodeTable ProcessStatusCD_FK { get; set; }
        public virtual MEyeImageAttachment EIAttachmentID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
