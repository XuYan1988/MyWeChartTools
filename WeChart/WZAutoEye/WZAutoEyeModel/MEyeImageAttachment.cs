using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �۵׸���ͼ�񸽼�����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��09��14��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MEyeImageAttachment
    {
        public MEyeImageAttachment()
        {
            this.MEyeImageBleedingOculist_EIAttachmentIDList = new List<MEyeImageBleedingOculist>();
            this.EEyeImageAttachmentHis_EIAttachmentIDList = new List<EEyeImageAttachmentHis>();
            this.MEyeImageBleeding_EIAttachmentIDList = new List<MEyeImageBleeding>();
            this.EAbandonHis_EIAttachmentIDList = new List<EAbandonHis>();
        }

        [Key]
        public Guid EIAttachmentID { get; set; }

        [DisplayName("ID����")]
        public Nullable<Guid> EyeImageID { get; set; }

        [DisplayName("�۵�ͼ�����ͣ����������ۣ�   CodeCD:UploadEI")]
        public string EITypeCD { get; set; }

        [DisplayName("ͼ�񸽼�����")]
        public string EIAttachmentName { get; set; }

        [DisplayName("ͼ�񸽼���С")]
        public Nullable<int> EIAttachmentSize { get; set; }

        [DisplayName("ͼ�񸽼�����")]
        public string EIAttachmentType { get; set; }

        [DisplayName("ͼ�񸽼�·��")]
        public string EIAttachmentPath { get; set; }

        [DisplayName("�ϴ�ʱ��")]
        public Nullable<DateTime> UploadTime { get; set; }

        [DisplayName("�ϴ���")]
        public Nullable<Guid> UploadUserID { get; set; }

        [DisplayName("��ע")]
        public string Remark { get; set; }

        [DisplayName("ԭƬ�ϴ�˳��1����2��1.�����һ��ԭͼ��Ӧ������ͼ��2.����ڶ���ԭͼ��Ӧ������ͼ��")]
        public Nullable<int> UploadOrder { get; set; }

        [DisplayName("�Զ���Ƭ��¼ID")]
        public Nullable<Guid> AutoReadID { get; set; }

        [DisplayName("�������Ƭ��¼ID")]
        public Nullable<Guid> GlaucomaReadID { get; set; }

        public string EyeMiddle_X { get; set; }

        public string EyeMiddle_Y { get; set; }

        public string EyeInner_X { get; set; }

        public string EyeInner_Y { get; set; }

        public string EIASHA128 { get; set; }

        public virtual ICollection<MEyeImageBleedingOculist> MEyeImageBleedingOculist_EIAttachmentIDList { get; set; }
        public virtual ICollection<EEyeImageAttachmentHis> EEyeImageAttachmentHis_EIAttachmentIDList { get; set; }
        public virtual ICollection<MEyeImageBleeding> MEyeImageBleeding_EIAttachmentIDList { get; set; }
        public virtual ICollection<EAbandonHis> EAbandonHis_EIAttachmentIDList { get; set; }
        public virtual EGlaucomaReadREC GlaucomaReadID_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MUser UploadUserID_FK { get; set; }
        public virtual EAutoReadREC AutoReadID_FK { get; set; }
        public virtual MCodeTable EITypeCD_FK { get; set; }
    }
}
