using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �¶ȼƻ�����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EMonthPlan
    {
        [Key]
        public Guid MonthPlanID { get; set; }
 
        [DisplayName("��ַCD")]
        public string AddressCD { get; set; }
 
        [DisplayName("ҽԺCD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("�ƻ�����CD��   PlanType-1��ɸ��ƻ�   PlanType-2�������ƻ�   ")]
        public string PlanTypeCD { get; set; }
 
        [DisplayName("���")]
        public string PlanYear { get; set; }
 
        [DisplayName("�¶�")]
        public string PlanMonth { get; set; }
 
        [DisplayName("�ƻ�����")]
        public Nullable<int> PlanQuantity { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MAddress AddressCD_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MCodeTable PlanTypeCD_FK { get; set; }
    }
}
