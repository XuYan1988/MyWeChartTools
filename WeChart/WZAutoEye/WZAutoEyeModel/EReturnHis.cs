using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医生退回记录信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class EReturnHis
    {
        [Key]
        public Guid ReturnHisID { get; set; }
 
        [DisplayName("ID主键")]
        public Nullable<Guid> EyeImageID { get; set; }
 
        [DisplayName("退回医生ID")]
        public Nullable<Guid> ReturnUserID { get; set; }
 
        [DisplayName("已读")]
        public bool Readed { get; set; }
 
        [DisplayName("医生级别CD   DocLevel-1：一级   DocLevel-2：二级   DocLevel-3：三级")]
        public string DocLevelCD { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MEyeImage EyeImageID_FK { get; set; }
        public virtual MUser ReturnUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MCodeTable DocLevelCD_FK { get; set; }
    }
}
