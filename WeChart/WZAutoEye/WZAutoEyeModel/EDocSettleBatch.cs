using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EDocSettleBatch
    {
        public EDocSettleBatch()
        {
          this.EDocSettleHDR_DocSettleBIDList = new List<EDocSettleHDR>();
        }
 
        [Key]
        public Guid DocSettleBID { get; set; }
 
        public string DocSettleBNO { get; set; }
 
        public Nullable<int> DocCount { get; set; }
 
        public Nullable<decimal> DocSumPoint { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public Nullable<DateTime> StartDate { get; set; }
 
        public Nullable<DateTime> EndDate { get; set; }
 
        public virtual ICollection<EDocSettleHDR> EDocSettleHDR_DocSettleBIDList { get; set; }
    }
}
