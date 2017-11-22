using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 评估用眼底复查图像附件表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MExamDocAttachmentMap : EntityTypeConfiguration<MExamDocAttachment>
    {
      public MExamDocAttachmentMap()
      {
        //主键
        this.HasKey(t => t.ExamAttachmentID);
        
        //属性
        
        this.Property(t => t.ExamTypeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.ExamAttachmentName)
            .HasMaxLength(100);
        
        this.Property(t => t.ExamAttachmentType)
            .HasMaxLength(10);
        
        this.Property(t => t.ExamAttachmentPath)
            .HasMaxLength(200);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //表与列的对应
        this.ToTable("MExamDocAttachment");
        this.Property(t => t.ExamAttachmentID).HasColumnName("ExamAttachmentID");
        this.Property(t => t.ExamTypeCD).HasColumnName("ExamTypeCD");
        this.Property(t => t.ExamAttachmentName).HasColumnName("ExamAttachmentName");
        this.Property(t => t.ExamAttachmentSize).HasColumnName("ExamAttachmentSize");
        this.Property(t => t.ExamAttachmentType).HasColumnName("ExamAttachmentType");
        this.Property(t => t.ExamAttachmentPath).HasColumnName("ExamAttachmentPath");
        this.Property(t => t.UploadTime).HasColumnName("UploadTime");
        this.Property(t => t.UploadUserID).HasColumnName("UploadUserID");
        this.Property(t => t.ExamDocID).HasColumnName("ExamDocID");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UploadOrder).HasColumnName("UploadOrder");
        
         //外键关系
        this.HasOptional(t => t.ExamDocID_FK)
            .WithMany(t => t.MExamDocAttachment_ExamDocIDList)
            .HasForeignKey(d => d.ExamDocID);
        this.HasOptional(t => t.ExamTypeCD_FK)
            .WithMany(t => t.MExamDocAttachment_ExamTypeCDList)
            .HasForeignKey(d => d.ExamTypeCD);
        this.HasOptional(t => t.UploadUserID_FK)
            .WithMany(t => t.MExamDocAttachment_UploadUserIDList)
            .HasForeignKey(d => d.UploadUserID);
      }
    }
}
