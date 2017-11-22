using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 用户角色表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MUserRole
    {
        [Key]
        public Guid UserRoleID { get; set; }
 
        [DisplayName("角色ID")]
        public Nullable<Guid> RoleID { get; set; }
 
        [DisplayName("用户ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("端口CD")]
        public string PortCD { get; set; }
 
        public virtual MRole RoleID_FK { get; set; }
        public virtual MUser UserID_FK { get; set; }
        public virtual MPort PortCD_FK { get; set; }
    }
}
