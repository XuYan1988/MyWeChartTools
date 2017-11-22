using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model
{
    /// <summary>
    /// 文件说明: 评估用眼底复查图像附件表信息实体
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 特别说明：本文件由代码生成工具自动生成，请勿轻易修改！
    /// </summary>
    [Serializable]
    public partial class MExamDocAttachment
    {
        public MExamDocAttachment()
        {
          this.MExamDocBleeding_ExamAttachmentIDList = new List<MExamDocBleeding>();
        }
 
        [Key]
        public Guid ExamAttachmentID { get; set; }
 
        [DisplayName("眼底图像类型（包含左、右眼）   CodeCD:UploadEI")]
        public string ExamTypeCD { get; set; }
 
        [DisplayName("图像附件名称")]
        public string ExamAttachmentName { get; set; }
 
        [DisplayName("图像附件大小")]
        public Nullable<int> ExamAttachmentSize { get; set; }
 
        [DisplayName("图像附件类型")]
        public string ExamAttachmentType { get; set; }
 
        [DisplayName("图像附件路径")]
        public string ExamAttachmentPath { get; set; }
 
        [DisplayName("上传时间")]
        public Nullable<DateTime> UploadTime { get; set; }
 
        [DisplayName("上传者")]
        public Nullable<Guid> UploadUserID { get; set; }
 
        [DisplayName("ID")]
        public Nullable<Guid> ExamDocID { get; set; }
 
        [DisplayName("备注")]
        public string Remark { get; set; }
 
        [DisplayName("原片上传顺序，1或者2。1.代表第一张原图对应的所有图像，2.代表第二张原图对应的所有图像")]
        public Nullable<int> UploadOrder { get; set; }
 
        public virtual ICollection<MExamDocBleeding> MExamDocBleeding_ExamAttachmentIDList { get; set; }
        public virtual EExamDoc ExamDocID_FK { get; set; }
        public virtual MCodeTable ExamTypeCD_FK { get; set; }
        public virtual MUser UploadUserID_FK { get; set; }
    }
}
