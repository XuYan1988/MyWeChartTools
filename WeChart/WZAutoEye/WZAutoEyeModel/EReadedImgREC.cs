using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 被阅片记录信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EReadedImgREC
    {
        public EReadedImgREC()
        {
          this.EHosSettleDTL_ReadedImgIDList = new List<EHosSettleDTL>();
        }
 
        [Key]
        public Guid ReadedImgID { get; set; }
 
        [DisplayName("用户ID(阅片医生)")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("眼底图像ID")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("阅片时间")]
        public Nullable<DateTime> ReadedTime { get; set; }
 
        [DisplayName("结算模式：1.点卡;2.月结")]
        public string SettleTypeCD { get; set; }
 
        [DisplayName("阅片模式：   ProcessType-1：人工流程   ProcessType-2：自动流程")]
        public string ProcessTypeCD { get; set; }
 
        [DisplayName("结算状态：1.已结;0.未结   给医院进行结算的状态")]
        public bool SettleStatus { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual ICollection<EHosSettleDTL> EHosSettleDTL_ReadedImgIDList { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MCodeTable SettleTypeCD_FK { get; set; }
        public virtual MCodeTable ProcessTypeCD_FK { get; set; }
    }
}
