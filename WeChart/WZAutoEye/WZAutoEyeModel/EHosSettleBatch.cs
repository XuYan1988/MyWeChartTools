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
    public partial class EHosSettleBatch
    {
        public EHosSettleBatch()
        {
          this.EHosSettleHDR_HosSettleBIDList = new List<EHosSettleHDR>();
        }
 
        [Key]
        public Guid HosSettleBID { get; set; }
 
        public string HosSettleBNO { get; set; }
 
        public Nullable<int> HosCount { get; set; }
 
        public Nullable<decimal> HosSum { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public Nullable<DateTime> StartDate { get; set; }
 
        public Nullable<DateTime> EndDate { get; set; }
 
        public virtual ICollection<EHosSettleHDR> EHosSettleHDR_HosSettleBIDList { get; set; }
    }
}
