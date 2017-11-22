using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 评估眼底复查图像参数信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MExamDocBleeding
    {
        [Key]
        public Guid ExBleedingID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> ExamAttachmentID { get; set; }
 
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
 
        public virtual MExamDocAttachment ExamAttachmentID_FK { get; set; }
    }
}
