using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 片源眼科医生对照表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MOculistHos
    {
        [Key]
        public Guid OculistHosID { get; set; }
 
        [DisplayName("用户ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("医院CD")]
        public string HospitalCD { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        public virtual MHospital HospitalCD_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
    }
}
