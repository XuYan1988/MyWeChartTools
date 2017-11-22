using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 青光眼阅片记录信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EGlaucomaReadREC
    {
        public EGlaucomaReadREC()
        {
          this.EDocSettleDTL_GlaucomaReadIDList = new List<EDocSettleDTL>();
          this.MEyeImageAttachment_GlaucomaReadIDList = new List<MEyeImageAttachment>();
        }
 
        [Key]
        public Guid GlaucomaReadID { get; set; }
 
        [DisplayName("基数")]
        public Nullable<decimal> BaseNum { get; set; }
 
        [DisplayName("系数")]
        public Nullable<decimal> Quotiety { get; set; }
 
        [DisplayName("人工阅片时间")]
        public Nullable<DateTime> ManualReadTime { get; set; }
 
        [DisplayName("结算状态：1.已结;0.未结   给阅片医生进行结算的状态")]
        public bool SettleStatus { get; set; }
 
        [DisplayName("自动阅片时间")]
        public Nullable<DateTime> AutoReadTime { get; set; }
 
        [DisplayName("印象")]
        public string Suggestion { get; set; }
 
        [DisplayName("建议")]
        public string Impression { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("ID主键")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("用户ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("报告模板模式：1.手动模板1 ; 2.自动模板1; 3.自动模板2;  4.青光眼模板")]
        public string ReportTempletCD { get; set; }
 
        [DisplayName("青光眼内部状态：1.待处理; 2.人工处理中; 3.自动处理中; 4.处理结束")]
        public string GlaucomaStatusCD { get; set; }
 
        public virtual ICollection<EDocSettleDTL> EDocSettleDTL_GlaucomaReadIDList { get; set; }
        public virtual ICollection<MEyeImageAttachment> MEyeImageAttachment_GlaucomaReadIDList { get; set; }
        public virtual MCodeTable GlaucomaStatusCD_FK { get; set; }
        public virtual MCodeTable ReportTempletCD_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
    }
}
