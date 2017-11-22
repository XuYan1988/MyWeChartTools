using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 眼底复查图像出血/渗出眼科信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MEyeImageBleedingOculist
    {
        [Key]
        public Guid EIBleedingOLID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> EIAttachmentID { get; set; }
 
        [DisplayName("出血数量")]
        public string BleedingAmount { get; set; }
 
        [DisplayName("出血总面积")]
        public Nullable<decimal> BleedingArea { get; set; }
 
        [DisplayName("出血最大面积")]
        public Nullable<decimal> BleedingMostArea { get; set; }
 
        [DisplayName("渗出数量")]
        public string ExudeAmount { get; set; }
 
        [DisplayName("渗出总面积")]
        public Nullable<decimal> ExudeArea { get; set; }
 
        [DisplayName("渗出最大面积")]
        public Nullable<decimal> ExudeMostArea { get; set; }
 
        [DisplayName("图像整体ImageQuality:1.非常好;2.好;3.一般;4.差;5.非常差")]
        public string ImageQualityCD { get; set; }
 
        [DisplayName("细节质量ImageQuality:1.非常好;2.好;3.一般;4.差;5.非常差")]
        public string DetailQualityCD { get; set; }
 
        [DisplayName("镜头情况LensSituation：1.干净; 2.脏")]
        public string LensSituationCD { get; set; }
 
        [DisplayName("单位")]
        public string UnitCD { get; set; }
 
        [DisplayName("青光眼指标-Mean Value of Cup/Disc Radius Ratio_右眼")]
        public Nullable<decimal> MVOCDRR_OD { get; set; }
 
        [DisplayName("青光眼指标-Mean Value of Cup/Disc Radius Ratio_左眼")]
        public Nullable<decimal> MVOCDRR_OS { get; set; }
 
        [DisplayName("青光眼指标-Mean Value of Cup/Disc Radius Ratio_正常参考指标")]
        public Nullable<decimal> MVOCDRR_Normal { get; set; }
 
        [DisplayName("青光眼指标-ISNT score_右眼")]
        public Nullable<decimal> IsntScore_OD { get; set; }
 
        [DisplayName("青光眼指标-ISNT score_左眼")]
        public Nullable<decimal> IsntScore_OS { get; set; }
 
        [DisplayName("青光眼指标-ISNT score_正常参考指标")]
        public Nullable<decimal> IsntScore_Normal { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Inferior_右眼")]
        public Nullable<decimal> Inferior_OD { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Inferior_左眼")]
        public Nullable<decimal> Inferior_OS { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Inferior_正常参考指标")]
        public Nullable<decimal> Inferior_Normal { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Superior_右眼")]
        public Nullable<decimal> Superior_OD { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Superior_左眼")]
        public Nullable<decimal> Superior_OS { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Superior_正常参考指标")]
        public Nullable<decimal> Superior_Normal { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Nasal_右眼")]
        public Nullable<decimal> Nasal_OD { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Nasal_左眼")]
        public Nullable<decimal> Nasal_OS { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Nasal_正常参考指标")]
        public Nullable<decimal> Nasal_Normal { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Temporal_右眼")]
        public Nullable<decimal> Temporal_OD { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Temporal_左眼")]
        public Nullable<decimal> Temporal_OS { get; set; }
 
        [DisplayName("青光眼指标-Cup/Disc Radius Ratio-Temporal_正常参考指标")]
        public Nullable<decimal> Temporal_Normal { get; set; }
 
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
 
        public virtual MEyeImageAttachment EIAttachmentID_FK { get; set; }
        public virtual MCodeTable ImageQualityCD_FK { get; set; }
        public virtual MCodeTable DetailQualityCD_FK { get; set; }
        public virtual MCodeTable LensSituationCD_FK { get; set; }
        public virtual MCodeTable UnitCD_FK { get; set; }
    }
}
