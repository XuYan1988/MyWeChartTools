using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 阅片医生结算DTL信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EDocSettleDTL
    {
        [Key]
        public Guid DocSettleDID { get; set; }
 
        [DisplayName("HID")]
        public Nullable<Guid> DocSettleHID { get; set; }
 
        [DisplayName("人工阅片记录ID")]
        public Nullable<Guid> ReadRECID { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> ExamDocID { get; set; }
 
        public Nullable<Guid> GlaucomaReadID { get; set; }
 
        public Nullable<Guid> AutoReadID { get; set; }
 
        public virtual EGlaucomaReadREC GlaucomaReadID_FK { get; set; }
        public virtual EDocSettleHDR DocSettleHID_FK { get; set; }
        public virtual EManualReadREC ReadRECID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual EExamDoc ExamDocID_FK { get; set; }
        public virtual EAutoReadREC AutoReadID_FK { get; set; }
    }
}
