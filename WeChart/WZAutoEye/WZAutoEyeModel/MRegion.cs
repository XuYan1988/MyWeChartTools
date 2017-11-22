using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: �����������Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MRegion
    {
        public MRegion()
        {
          this.MRegionAddress_RegionCDList = new List<MRegionAddress>();
          this.EOrderPlan_RegionCDList = new List<EOrderPlan>();
        }
 
        [Key]
        public string RegionCD { get; set; }
 
        [DisplayName("������ID")]
        public Nullable<Guid> SalesmanID { get; set; }
 
        [DisplayName("��������")]
        public string RegionNM { get; set; }
 
        [DisplayName("��RegionCD")]
        public string PRegionCD { get; set; }
 
        [DisplayName("��ע")]
        public string Remark { get; set; }
 
        [DisplayName("��������")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("������")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("������")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("��������")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual ICollection<MRegionAddress> MRegionAddress_RegionCDList { get; set; }
        public virtual ICollection<EOrderPlan> EOrderPlan_RegionCDList { get; set; }
        public virtual MSalesman SalesmanID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
