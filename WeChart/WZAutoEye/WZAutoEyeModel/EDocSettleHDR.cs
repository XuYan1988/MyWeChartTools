using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医生结算HDR信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EDocSettleHDR
    {
        public EDocSettleHDR()
        {
          this.EDocSettleDTL_DocSettleHIDList = new List<EDocSettleDTL>();
        }
 
        [Key]
        public Guid DocSettleHID { get; set; }
 
        [DisplayName("用户ID（阅片医生）")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("本次结算点数")]
        public Nullable<decimal> DocPoint { get; set; }
 
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
 
        [DisplayName("总点数")]
        public Nullable<decimal> SumPoint { get; set; }
 
        [DisplayName("未结点数")]
        public Nullable<decimal> NotClearPoint { get; set; }
 
        [DisplayName("已结点数")]
        public Nullable<decimal> ClearPoint { get; set; }
 
        public Nullable<Guid> DocSettleBID { get; set; }
 
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_DocSettleHIDList { get; set; }
        public virtual EDocSettleBatch DocSettleBID_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
