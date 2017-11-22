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
    public partial class EAbandonHis
    {
        [Key]
        public Guid AbandonHisID { get; set; }
 
        public Nullable<Guid> EIAttachmentID { get; set; }
 
        public string EIAttachmentPath { get; set; }
 
        public string BleedingAmount { get; set; }
 
        public Nullable<decimal> BleedingArea { get; set; }
 
        public Nullable<decimal> BleedingMostArea { get; set; }
 
        public string ExudeAmount { get; set; }
 
        public Nullable<decimal> ExudeArea { get; set; }
 
        public Nullable<decimal> ExudeMostArea { get; set; }
 
        public string ImageQualityCD { get; set; }
 
        public string DetailQualityCD { get; set; }
 
        public string LensSituationCD { get; set; }
 
        public string UnitCD { get; set; }
 
        public string EyeType { get; set; }
 
        public string Suggestion { get; set; }
 
        public bool Stain { get; set; }
 
        public string ProcessTime { get; set; }
 
        public string Remark { get; set; }
 
        public Nullable<DateTime> UpdTime { get; set; }
 
        public Nullable<Guid> UpdUserID { get; set; }
 
        public Nullable<DateTime> InsTime { get; set; }
 
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MEyeImageAttachment EIAttachmentID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
