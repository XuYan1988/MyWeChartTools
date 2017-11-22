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
    public partial class EEyeImageBleedingHis
    {
        [Key]
        public Guid EIBleedingHisID { get; set; }
 
        public Nullable<Guid> EIBleedingID { get; set; }
 
        public string BleedingAmount { get; set; }
 
        public Nullable<decimal> BleedingArea { get; set; }
 
        public Nullable<decimal> BleedingMostArea { get; set; }
 
        public string ExudeAmount { get; set; }
 
        public Nullable<decimal> ExudeArea { get; set; }
 
        public Nullable<decimal> ExudeMostArea { get; set; }
 
        public string ImageQualityCD { get; set; }
 
        public string DetailQualityCD { get; set; }
 
        public string LensSituationCD { get; set; }
 
        public string UnitCD { get; set; }
 
        public Nullable<decimal> MVOCDRR_OD { get; set; }
 
        public Nullable<decimal> MVOCDRR_OS { get; set; }
 
        public Nullable<decimal> MVOCDRR_Normal { get; set; }
 
        public Nullable<decimal> IsntScore_OD { get; set; }
 
        public Nullable<decimal> IsntScore_OS { get; set; }
 
        public Nullable<decimal> IsntScore_Normal { get; set; }
 
        public Nullable<decimal> Inferior_OD { get; set; }
 
        public Nullable<decimal> Inferior_OS { get; set; }
 
        public Nullable<decimal> Inferior_Normal { get; set; }
 
        public Nullable<decimal> Superior_OD { get; set; }
 
        public Nullable<decimal> Superior_OS { get; set; }
 
        public Nullable<decimal> Superior_Normal { get; set; }
 
        public Nullable<decimal> Nasal_OD { get; set; }
 
        public Nullable<decimal> Nasal_OS { get; set; }
 
        public Nullable<decimal> Nasal_Normal { get; set; }
 
        public Nullable<decimal> Temporal_OD { get; set; }
 
        public Nullable<decimal> Temporal_OS { get; set; }
 
        public Nullable<decimal> Temporal_Normal { get; set; }
 
        public string C_D { get; set; }
 
        public string DiskEdgeShape { get; set; }
 
        public string A_V { get; set; }
 
        public string MacularRegion_Hemorrhage { get; set; }
 
        public string MacularRegion_Exudation { get; set; }
 
        public string PeripheralRetina_Hemorrhage { get; set; }
 
        public string PeripheralRetina_Exudation { get; set; }
 
        public string Other { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
