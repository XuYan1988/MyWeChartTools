using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 报告反馈表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EReportFeedback
    {
        [Key]
        public Guid ReportFeedbackID { get; set; }
 
        [DisplayName("ID主键")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("问题")]
        public string Question { get; set; }
 
        [DisplayName("回答")]
        public string Answer { get; set; }
 
        [DisplayName("反馈状态：   FeedbackStatus-1：未处理   FeedbackStatus-2：处理中   FeedbackStatus-3：已处理")]
        public string FeedbackStatusCD { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public string QuestionTypeCD { get; set; }
 
        public string MisAttributionCD { get; set; }
 
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MCodeTable FeedbackStatusCD_FK { get; set; }
        public virtual MCodeTable QuestionTypeCD_FK { get; set; }
        public virtual MCodeTable MisAttributionCD_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
