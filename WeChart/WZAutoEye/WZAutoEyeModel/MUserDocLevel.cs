using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 医生阅片级别信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MUserDocLevel
    {
        [Key]
        public Guid UserDocLevelID { get; set; }
 
        [DisplayName("用户ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("级别CD：   DocLevel-1：一级   DocLevel-2：二级   DocLevel-3：三级")]
        public string DocLevelCD { get; set; }
 
        [DisplayName("流程类型CD：   ProcessType-1：人工流程   ProcessType-2：自动流程   ProcessType-3：青光眼流程")]
        public string ProcessTypeCD { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MCodeTable DocLevelCD_FK { get; set; }
        public virtual MCodeTable ProcessTypeCD_FK { get; set; }
    }
}
