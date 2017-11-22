using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 登录日志：记录登录者，登录时间，登录或者退出信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MLoginLog
    {
        [Key]
        public Guid LoginLogID { get; set; }
 
        [DisplayName("登录者")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("LoginType-1:登录;LoginType-2:退出")]
        public string LoginType { get; set; }
 
        [DisplayName("登录时间")]
        public Nullable<DateTime> LoginTime { get; set; }
 
        [DisplayName("登录端口")]
        public string PortCD { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MPort PortCD_FK { get; set; }
        public virtual MCodeTable LoginType_FK { get; set; }
    }
}
