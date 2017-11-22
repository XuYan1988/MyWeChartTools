using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 菜单信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MMenu
    {
        public MMenu()
        {
          this.MRoleMenu_MenuCDList = new List<MRoleMenu>();
        }
 
        [Key]
        public string MenuCD { get; set; }
 
        [DisplayName("父级菜单CD")]
        public string ParentMenuCD { get; set; }
 
        [DisplayName("菜单名称")]
        public string MenuName { get; set; }
 
        [DisplayName("菜单名称_英文")]
        public string MenuName_EN { get; set; }
 
        [DisplayName("菜单KEY")]
        public string MenuKey { get; set; }
 
        [DisplayName("菜单URL")]
        public string MenuURL { get; set; }
 
        [DisplayName("排序")]
        public Nullable<int> OrderNum { get; set; }
 
        [DisplayName("菜单:0.左菜单;1.右菜单")]
        public bool LeftOrRight { get; set; }
 
        [DisplayName("MENU前面小图标")]
        public string ImgUrl { get; set; }
 
        public virtual ICollection<MRoleMenu> MRoleMenu_MenuCDList { get; set; }
    }
}
