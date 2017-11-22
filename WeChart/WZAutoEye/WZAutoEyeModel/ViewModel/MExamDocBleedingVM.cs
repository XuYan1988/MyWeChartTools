using WZAutoEye.WZAutoEyeMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WZAutoEyeModel.ViewModel
{
    [Serializable]
    public partial class MExamDocBleedingVM
    {
        [Key]
        public Guid ExBleedingID { get; set; }

        [DisplayName("ID")]
        public Nullable<Guid> ExamDocID { get; set; }

        [DisplayName("ID")]
        public Nullable<Guid> EIAttachmentID { get; set; }

        [DisplayName("影像描述值-C/D，默认值：0.3")]
        public string C_D { get; set; }

        [DisplayName("影像描述值-盘沿形态，默认值：可")]
        public string DiskEdgeShape { get; set; }

        [DisplayName("影像描述值-A/C，默认值：尚可")]
        public string A_V { get; set; }

        [DisplayName("影像描述值-黄斑区_出血，默认值：未见明显")]
        public string MacularRegion_Hemorrhage { get; set; }

        [DisplayName("影像描述值-黄斑区_渗出，默认值：未见明显")]
        public string MacularRegion_Exudation { get; set; }

        [DisplayName("影像描述值-周边视网膜_出血，默认值：未见明显")]
        public string PeripheralRetina_Hemorrhage { get; set; }

        [DisplayName("影像描述值-周边视网膜_渗出，默认值：未见明显")]
        public string PeripheralRetina_Exudation { get; set; }

        [DisplayName("影像描述值-其他，默认值：无")]
        public string Other { get; set; }

        [DisplayName("眼睛类型-左右青光，默认值：无")]
        public string ExamTypeCD { get; set; }

        public virtual EExamDoc ExamDocID_FK { get; set; }
        public virtual MEyeImageAttachment EIAttachmentID_FK { get; set; }
    }
}
