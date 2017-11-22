using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 系统公告通知信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class ENotice
    {
        [Key]
        public Guid NoticeID { get; set; }
 
        [DisplayName("通知标题")]
        public string Title { get; set; }
 
        [DisplayName("通知内容")]
        public string Content { get; set; }
 
        [DisplayName("发布通知的用户ID")]
        public Nullable<Guid> UserID { get; set; }
 
        [DisplayName("接收者类型，1、所有账户类型：RoleType-0，2、具体接收账户类型：MCodeTable的RoleTypeCD")]
        public string RecipientType { get; set; }
 
        [DisplayName("是否发布1.发布，0.未发布")]
        public Nullable<bool> IsPublic { get; set; }
 
        [DisplayName("发布时间")]
        public Nullable<DateTime> ReleaseTime { get; set; }
 
        [DisplayName("更新时间")]
        public Nullable<DateTime> UpdTime { get; set; }
 
        [DisplayName("更新者")]
        public Nullable<Guid> UpdUserID { get; set; }
 
        [DisplayName("创建时间")]
        public Nullable<DateTime> InsTime { get; set; }
 
        [DisplayName("创建者")]
        public Nullable<Guid> InsUserID { get; set; }
 
        public virtual MUser UserID_FK { get; set; }
        public virtual MUser UpdUserID_FK { get; set; }
        public virtual MUser InsUserID_FK { get; set; }
    }
}
