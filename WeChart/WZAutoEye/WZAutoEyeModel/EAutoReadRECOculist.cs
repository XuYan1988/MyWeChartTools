using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 自动阅片记录眼科信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EAutoReadRECOculist
    {
        [Key]
        public Guid AutoReadOLID { get; set; }
 
        [DisplayName("ID主键")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("结算状态：1.已结;0.未结   给阅片医生进行结算的状态")]
        public bool SettleStatus { get; set; }
 
        [DisplayName("阅片给出的建议")]
        public string Suggestion { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("单位")]
        public string Unit { get; set; }
 
        [DisplayName("报告模板模式：1.手动模板1 ; 2.自动模板1; 3.自动模板2;  4.青光眼模板")]
        public string ReportTempletCD { get; set; }
 
        public bool EyeOffice { get; set; }
 
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MCodeTable ReportTempletCD_FK { get; set; }
    }
}
