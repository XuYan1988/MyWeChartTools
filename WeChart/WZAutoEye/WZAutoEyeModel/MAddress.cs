using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 地址码表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
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
 
        [DisplayName("父级地址")]
        public string ParentAddressCD { get; set; }
 
        [DisplayName("地址名称(英文)")]
        public string Name_EN { get; set; }
 
        [DisplayName("地址名称(中文)")]
        public string Name { get; set; }
 
        [DisplayName("排序")]
        public Nullable<byte> OrderNum { get; set; }
 
        public virtual ICollection<MHospital> MHospital_AddressCDList { get; set; }
        public virtual ICollection<MRegionAddress> MRegionAddress_AddressCDList { get; set; }
        public virtual ICollection<EMonthPlan> EMonthPlan_AddressCDList { get; set; }
    }
}
