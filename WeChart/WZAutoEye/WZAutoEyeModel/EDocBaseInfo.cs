using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医生基数信息信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EDocBaseInfo
    {
        [Key]
        public Guid DocBaseInfo { get; set; }
 
        [DisplayName("基数")]
        public Nullable<decimal> BaseNum { get; set; }
 
        [DisplayName("系数")]
        public Nullable<decimal> Quotiety { get; set; }
 
        [DisplayName("用户ID（阅片医生）")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("生效时间")]
        public Nullable<DateTime> ValidTime { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> Updtime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
    }
}
