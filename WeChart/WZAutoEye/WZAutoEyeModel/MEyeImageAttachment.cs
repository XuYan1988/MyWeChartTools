using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 眼底复查图像附件表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年09月14日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
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

        [DisplayName("ID主键")]
        public Nullable<Guid> EyeImageID { get; set; }

        [DisplayName("眼底图像类型（包含左、右眼）   CodeCD:UploadEI")]
        public string EITypeCD { get; set; }

        [DisplayName("图像附件名称")]
        public string EIAttachmentName { get; set; }

        [DisplayName("图像附件大小")]
        public Nullable<int> EIAttachmentSize { get; set; }

        [DisplayName("图像附件类型")]
        public string EIAttachmentType { get; set; }

        [DisplayName("图像附件路径")]
        public string EIAttachmentPath { get; set; }

        [DisplayName("上传时间")]
        public Nullable<DateTime> UploadTime { get; set; }

        [DisplayName("上传者")]
        public Nullable<Guid> UploadUserID { get; set; }

        [DisplayName("备注")]
        public string Remark { get; set; }

        [DisplayName("原片上传顺序，1或者2。1.代表第一张原图对应的所有图像，2.代表第二张原图对应的所有图像")]
        public Nullable<int> UploadOrder { get; set; }

        [DisplayName("自动阅片记录ID")]
        public Nullable<Guid> AutoReadID { get; set; }

        [DisplayName("青光眼阅片记录ID")]
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
