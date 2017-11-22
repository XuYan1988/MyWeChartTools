using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 附件信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MAttachment
    {
        [Key]
        public Guid AttachmentID { get; set; }
 
        [DisplayName("关联表:Type1.EyeImage:上传眼底图低")]
        public string ObjectType { get; set; }
 
        [DisplayName("关联表ID")]
        public Nullable<Guid> ObjectID { get; set; }
 
        [DisplayName("附件名称")]
        public string AttachmentName { get; set; }
 
        [DisplayName("附件大小")]
        public Nullable<int> AttachmentSize { get; set; }
 
        [DisplayName("附件类型")]
        public string AttachmentType { get; set; }
 
        [DisplayName("附件路径")]
        public string AttachmentPath { get; set; }
 
        [DisplayName("上传时间")]
        public Nullable<DateTime> UploadTime { get; set; }
 
        [DisplayName("上传者")]
        public Nullable<Guid> UploadUserID { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
    }
}
