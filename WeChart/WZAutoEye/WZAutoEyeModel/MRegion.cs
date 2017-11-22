using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 销售区域表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
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
 
        [DisplayName("负责人ID")]
        public Nullable<Guid> SalesmanID { get; set; }
 
        [DisplayName("区域名称")]
        public string RegionNM { get; set; }
 
        [DisplayName("父RegionCD")]
        public string PRegionCD { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        [DisplayName("更新日期")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建日期")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual ICollection<MRegionAddress> MRegionAddress_RegionCDList { get; set; }
        public virtual ICollection<EOrderPlan> EOrderPlan_RegionCDList { get; set; }
        public virtual MSalesman SalesmanID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
