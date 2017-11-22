using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医院结算HDR信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EHosSettleHDR
    {
        public EHosSettleHDR()
        {
          this.EHosSettleDTL_HosSettleHIDList = new List<EHosSettleDTL>();
        }
 
        [Key]
        public Guid HosSettleHID { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("单价")]
        public Nullable<decimal> Price { get; set; }
 
        [DisplayName("数量")]
        public Nullable<int> Quantity { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("开始日期")]
        public Nullable<DateTime> StartDate { get; set; }
 
        [DisplayName("结束日期")]
        public Nullable<DateTime> EndDate { get; set; }
 
        public string Remark { get; set; }
 
        public Nullable<Guid> HosSettleBID { get; set; }
 
        public virtual ICollection<EHosSettleDTL> EHosSettleDTL_HosSettleHIDList { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual EHosSettleBatch HosSettleBID_FK { get; set; }
    }
}
