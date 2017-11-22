using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �۵׸���ͼ���Ѫ/�����ۿ���Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MEyeImageBleedingOculist
    {
        [Key]
        public Guid EIBleedingOLID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> EIAttachmentID { get; set; }
 
        [DisplayName("��Ѫ����")]
        public string BleedingAmount { get; set; }
 
        [DisplayName("��Ѫ�����")]
        public Nullable<decimal> BleedingArea { get; set; }
 
        [DisplayName("��Ѫ������")]
        public Nullable<decimal> BleedingMostArea { get; set; }
 
        [DisplayName("��������")]
        public string ExudeAmount { get; set; }
 
        [DisplayName("���������")]
        public Nullable<decimal> ExudeArea { get; set; }
 
        [DisplayName("����������")]
        public Nullable<decimal> ExudeMostArea { get; set; }
 
        [DisplayName("ͼ������ImageQuality:1.�ǳ���;2.��;3.һ��;4.��;5.�ǳ���")]
        public string ImageQualityCD { get; set; }
 
        [DisplayName("ϸ������ImageQuality:1.�ǳ���;2.��;3.һ��;4.��;5.�ǳ���")]
        public string DetailQualityCD { get; set; }
 
        [DisplayName("��ͷ���LensSituation��1.�ɾ�; 2.��")]
        public string LensSituationCD { get; set; }
 
        [DisplayName("��λ")]
        public string UnitCD { get; set; }
 
        [DisplayName("�����ָ��-Mean Value of Cup/Disc Radius Ratio_����")]
        public Nullable<decimal> MVOCDRR_OD { get; set; }
 
        [DisplayName("�����ָ��-Mean Value of Cup/Disc Radius Ratio_����")]
        public Nullable<decimal> MVOCDRR_OS { get; set; }
 
        [DisplayName("�����ָ��-Mean Value of Cup/Disc Radius Ratio_�����ο�ָ��")]
        public Nullable<decimal> MVOCDRR_Normal { get; set; }
 
        [DisplayName("�����ָ��-ISNT score_����")]
        public Nullable<decimal> IsntScore_OD { get; set; }
 
        [DisplayName("�����ָ��-ISNT score_����")]
        public Nullable<decimal> IsntScore_OS { get; set; }
 
        [DisplayName("�����ָ��-ISNT score_�����ο�ָ��")]
        public Nullable<decimal> IsntScore_Normal { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Inferior_����")]
        public Nullable<decimal> Inferior_OD { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Inferior_����")]
        public Nullable<decimal> Inferior_OS { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Inferior_�����ο�ָ��")]
        public Nullable<decimal> Inferior_Normal { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Superior_����")]
        public Nullable<decimal> Superior_OD { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Superior_����")]
        public Nullable<decimal> Superior_OS { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Superior_�����ο�ָ��")]
        public Nullable<decimal> Superior_Normal { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Nasal_����")]
        public Nullable<decimal> Nasal_OD { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Nasal_����")]
        public Nullable<decimal> Nasal_OS { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Nasal_�����ο�ָ��")]
        public Nullable<decimal> Nasal_Normal { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Temporal_����")]
        public Nullable<decimal> Temporal_OD { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Temporal_����")]
        public Nullable<decimal> Temporal_OS { get; set; }
 
        [DisplayName("�����ָ��-Cup/Disc Radius Ratio-Temporal_�����ο�ָ��")]
        public Nullable<decimal> Temporal_Normal { get; set; }
 
        [DisplayName("Ӱ������ֵ-C/D��Ĭ��ֵ��0.3")]
        public string C_D { get; set; }
 
        [DisplayName("Ӱ������ֵ-������̬��Ĭ��ֵ����")]
        public string DiskEdgeShape { get; set; }
 
        [DisplayName("Ӱ������ֵ-A/C��Ĭ��ֵ���п�")]
        public string A_V { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ư���_��Ѫ��Ĭ��ֵ��δ������")]
        public string MacularRegion_Hemorrhage { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ư���_������Ĭ��ֵ��δ������")]
        public string MacularRegion_Exudation { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ܱ�����Ĥ_��Ѫ��Ĭ��ֵ��δ������")]
        public string PeripheralRetina_Hemorrhage { get; set; }
 
        [DisplayName("Ӱ������ֵ-�ܱ�����Ĥ_������Ĭ��ֵ��δ������")]
        public string PeripheralRetina_Exudation { get; set; }
 
        [DisplayName("Ӱ������ֵ-������Ĭ��ֵ����")]
        public string Other { get; set; }
 
        public virtual MEyeImageAttachment EIAttachmentID_FK { get; set; }
        public virtual MCodeTable ImageQualityCD_FK { get; set; }
        public virtual MCodeTable DetailQualityCD_FK { get; set; }
        public virtual MCodeTable LensSituationCD_FK { get; set; }
        public virtual MCodeTable UnitCD_FK { get; set; }
    }
}
