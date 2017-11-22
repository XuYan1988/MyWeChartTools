using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 角色信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MRole
    {
        public MRole()
        {
          this.MRoleMenu_RoleIDList = new List<MRoleMenu>();
          this.MUserRole_RoleIDList = new List<MUserRole>();
        }
 
        [Key]
        public Guid RoleID { get; set; }
 
        [DisplayName("角色名称")]
        public string RoleName { get; set; }
 
        [DisplayName("角色名称_英文")]
        public string RoleName_EN { get; set; }
 
        public virtual ICollection<MRoleMenu> MRoleMenu_RoleIDList { get; set; }
        public virtual ICollection<MUserRole> MUserRole_RoleIDList { get; set; }
    }
}
