using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 大区省市对应表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MRegionAddress
    {
        [Key]
        public Guid RegionAddressID { get; set; }
 
        [DisplayName("RegionCD")]
        public string RegionCD { get; set; }
 
        [DisplayName("地址CD")]
        public string AddressCD { get; set; }
 
        [DisplayName("更新日期")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建日期")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MRegion RegionCD_FK { get; set; }
        public virtual MAddress AddressCD_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
