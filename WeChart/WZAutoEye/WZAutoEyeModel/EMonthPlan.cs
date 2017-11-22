using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 月度计划表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EMonthPlan
    {
        [Key]
        public Guid MonthPlanID { get; set; }
 
        [DisplayName("地址CD")]
        public string AddressCD { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("计划类型CD：   PlanType-1：筛查计划   PlanType-2：开发计划   ")]
        public string PlanTypeCD { get; set; }
 
        [DisplayName("年度")]
        public string PlanYear { get; set; }
 
        [DisplayName("月度")]
        public string PlanMonth { get; set; }
 
        [DisplayName("计划数量")]
        public Nullable<int> PlanQuantity { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MAddress AddressCD_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MCodeTable PlanTypeCD_FK { get; set; }
    }
}
