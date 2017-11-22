using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �۵�ͼ����Ϣ��Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MEyeImage
    {
        public MEyeImage()
        {
          this.EAutoReadRECOculist_EyeImageIDList = new List<EAutoReadRECOculist>();
          this.EEyeImageAttachmentHis_EyeImageIDList = new List<EEyeImageAttachmentHis>();
          this.EAutoReadREC_EyeImageIDList = new List<EAutoReadREC>();
          this.EExamDoc_EyeImageIDList = new List<EExamDoc>();
          this.EGlaucomaReadREC_EyeImageIDList = new List<EGlaucomaReadREC>();
          this.EManualReadREC_EyeImageIDList = new List<EManualReadREC>();
          this.EReportFeedback_EyeImageIDList = new List<EReportFeedback>();
          this.EReadedImgREC_EyeImageIDList = new List<EReadedImgREC>();
          this.MEyeImageAttachment_EyeImageIDList = new List<MEyeImageAttachment>();
          this.EReturnHis_EyeImageIDList = new List<EReturnHis>();
          this.EManualReadRECOculist_EyeImageIDList = new List<EManualReadRECOculist>();
        }
 
        [Key]
        public Guid EyeImageID { get; set; }
 
        [DisplayName("���")]
        public string ImageCode { get; set; }
 
        [DisplayName("�Զ��ϴ�   0���ֶ��ϴ�   1���Զ��ϴ�")]
        public bool AutoUpload { get; set; }
 
        [DisplayName("���֣�1.����;2.��Ѫѹ;3.��ͨɸ��")]
        public string DistinguishCD { get; set; }
 
        [DisplayName("���֤")]
        public string IDCard { get; set; }
 
        [DisplayName("����")]
        public string PatientNM { get; set; }
 
        [DisplayName("����")]
        public Nullable<int> Age { get; set; }
 
        [DisplayName("�Ա�1.��;2.Ů")]
        public string SexCD { get; set; }
 
        [DisplayName("ҽ������   ���Զ��ϴ��������е�����������Ǵ���ҽ����������ҽ��")]
        public string RecordDoctorNM { get; set; }
 
        [DisplayName("����ҽ��")]
        public Nullable<Guid> PrescriptionDoctorID { get; set; }
 
        [DisplayName("ҽԺ")]
        public string HospitalCD { get; set; }
 
        [DisplayName("��ѹ(����)")]
        public Nullable<int> IntraOcularTensionLeft { get; set; }
 
        [DisplayName("Ѫ��")]
        public Nullable<decimal> BloodSugar { get; set; }
 
        [DisplayName("����")]
        public Nullable<decimal> Weight { get; set; }
 
        [DisplayName("����")]
        public string Email { get; set; }
 
        [DisplayName("�ֻ�")]
        public string Phone { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
        [DisplayName("��ѹ(����)")]
        public Nullable<int> IntraOcularTensionRight { get; set; }
 
        [DisplayName("����(����)")]
        public Nullable<decimal> VisionLeft { get; set; }
 
        [DisplayName("����(����)")]
        public Nullable<decimal> VisionRight { get; set; }
 
        [DisplayName("��������(����)")]
        public Nullable<decimal> CorrectedVisionLeft { get; set; }
 
        [DisplayName("��������(����)")]
        public Nullable<decimal> CorrectedVisionRight { get; set; }
 
        [DisplayName("״̬")]
        public string StatusCD { get; set; }
 
        [DisplayName("�ϴ�ʱ��")]
        public Nullable<DateTime> UploadTime { get; set; }
 
        [DisplayName("�ϴ���")]
        public Nullable<Guid> UploadUserID { get; set; }
 
        [DisplayName("HosCameraID")]
        public Nullable<Guid> HosCameraID { get; set; }
 
        [DisplayName("�Ƿ��Ѵ�ӡ��0.δ��ӡ��,1.�Ѵ�ӡ��")]
        public Nullable<bool> IsPrinted { get; set; }
 
        [DisplayName("�ϴ��˻ش���ͼ����Ƭҽ��:���UserID")]
        public Nullable<Guid> ReturnDoc { get; set; }
 
        [DisplayName("�������ͣ�   ProcessType-1.�˹�����   ProcessType-2.�Զ�����   ProcessType-3.���������")]
        public string ProcessTypeCD { get; set; }
 
        [DisplayName("������ͣ�   CheckType-1.����   CheckType-2.���   CheckType-3:�����")]
        public string CheckTypeCD { get; set; }
 
        public string Complain { get; set; }
 
        public Nullable<Guid> PatientID { get; set; }
 
        public string DocLevelCD { get; set; }
 
        public Nullable<decimal> PPBloodSugar { get; set; }
 
        public bool IsReception { get; set; }
 
        public virtual ICollection<EAutoReadRECOculist> EAutoReadRECOculist_EyeImageIDList { get; set; }
        public virtual ICollection<EEyeImageAttachmentHis> EEyeImageAttachmentHis_EyeImageIDList { get; set; }
        public virtual ICollection<EAutoReadREC> EAutoReadREC_EyeImageIDList { get; set; }
        public virtual ICollection<EExamDoc> EExamDoc_EyeImageIDList { get; set; }
        public virtual ICollection<EGlaucomaReadREC> EGlaucomaReadREC_EyeImageIDList { get; set; }
        public virtual ICollection<EManualReadREC> EManualReadREC_EyeImageIDList { get; set; }
        public virtual ICollection<EReportFeedback> EReportFeedback_EyeImageIDList { get; set; }
        public virtual ICollection<EReadedImgREC> EReadedImgREC_EyeImageIDList { get; set; }
        public virtual ICollection<MEyeImageAttachment> MEyeImageAttachment_EyeImageIDList { get; set; }
        public virtual ICollection<EReturnHis> EReturnHis_EyeImageIDList { get; set; }
        public virtual ICollection<EManualReadRECOculist> EManualReadRECOculist_EyeImageIDList { get; set; }
        public virtual MCodeTable CheckTypeCD_FK { get; set; }
        public virtual MCodeTable DistinguishCD_FK { get; set; }
        public virtual MCodeTable StatusCD_FK { get; set; }
        public virtual MCodeTable SexCD_FK { get; set; }
        public virtual MCodeTable DocLevelCD_FK { get; set; }
        public virtual MCodeTable ProcessTypeCD_FK { get; set; }
        public virtual MPrescriptionDoctor PrescriptionDoctorID_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MPatient PatientID_FK { get; set; }
        public virtual MUser UploadUserID_FK { get; set; }
        public virtual MHosCamera HosCameraID_FK { get; set; }
    }
}
