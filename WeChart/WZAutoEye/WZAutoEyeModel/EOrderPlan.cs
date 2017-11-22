using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �´�ƻ���Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class EOrderPlan
    {
        [Key]
        public Guid OrderPlanID { get; set; }
 
        [DisplayName("RegionCD")]
        public string RegionCD { get; set; }
 
        [DisplayName("���")]
        public string PlanYear { get; set; }
 
        [DisplayName("�¶�")]
        public string PlanMonth { get; set; }
 
        [DisplayName("�ƻ�ɸ������")]
        public Nullable<int> ScreenQuantity { get; set; }
 
        [DisplayName("�ƻ���������")]
        public Nullable<int> DevelopQuantity { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("����ʱ��")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MRegion RegionCD_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
