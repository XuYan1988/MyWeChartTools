using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 附件信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MAttachmentMap : EntityTypeConfiguration<MAttachment>
    {
      public MAttachmentMap()
      {
        //主键
        this.HasKey(t => t.AttachmentID);
        
        //属性
        
        this.Property(t => t.ObjectType)
            .HasMaxLength(100);
        
        this.Property(t => t.AttachmentName)
            .HasMaxLength(100);
        
        this.Property(t => t.AttachmentType)
            .HasMaxLength(10);
        
        this.Property(t => t.AttachmentPath)
            .HasMaxLength(200);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //表与列的对应
        this.ToTable("MAttachment");
        this.Property(t => t.AttachmentID).HasColumnName("AttachmentID");
        this.Property(t => t.ObjectType).HasColumnName("ObjectType");
        this.Property(t => t.ObjectID).HasColumnName("ObjectID");
        this.Property(t => t.AttachmentName).HasColumnName("AttachmentName");
        this.Property(t => t.AttachmentSize).HasColumnName("AttachmentSize");
        this.Property(t => t.AttachmentType).HasColumnName("AttachmentType");
        this.Property(t => t.AttachmentPath).HasColumnName("AttachmentPath");
        this.Property(t => t.UploadTime).HasColumnName("UploadTime");
        this.Property(t => t.UploadUserID).HasColumnName("UploadUserID");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}
