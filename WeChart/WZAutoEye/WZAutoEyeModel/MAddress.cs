using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// �ļ�˵��: ��ַ�����Ϣʵ��
    /// ��    ��: Ԭ����
    /// ��������: 2017��08��17��
    /// ����ģ��: CTSR.Template.Model.MVC_Model_01 ��
    /// �ر�˵�������ļ��ɴ������ɹ����Զ����ɣ����������޸ģ�
    /// </summary>
    [Serializable]
    public partial class MAddress
    {
        public MAddress()
        {
          this.MHospital_AddressCDList = new List<MHospital>();
          this.MRegionAddress_AddressCDList = new List<MRegionAddress>();
          this.EMonthPlan_AddressCDList = new List<EMonthPlan>();
        }
 
        [Key]
        public string AddressCD { get; set; }
 
        [DisplayName("������ַ")]
        public string ParentAddressCD { get; set; }
 
        [DisplayName("��ַ����(Ӣ��)")]
        public string Name_EN { get; set; }
 
        [DisplayName("��ַ����(����)")]
        public string Name { get; set; }
 
        [DisplayName("����")]
        public Nullable<byte> OrderNum { get; set; }
 
        public virtual ICollection<MHospital> MHospital_AddressCDList { get; set; }
        public virtual ICollection<MRegionAddress> MRegionAddress_AddressCDList { get; set; }
        public virtual ICollection<EMonthPlan> EMonthPlan_AddressCDList { get; set; }
    }
}
