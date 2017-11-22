using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 眼底复查图像附件表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年09月14日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MEyeImageAttachmentMap : EntityTypeConfiguration<MEyeImageAttachment>
    {
        public MEyeImageAttachmentMap()
        {
            //主键
            this.HasKey(t => t.EIAttachmentID);

            //属性

            this.Property(t => t.EITypeCD)
                .HasMaxLength(64);

            this.Property(t => t.EIAttachmentName)
                .HasMaxLength(100);

            this.Property(t => t.EIAttachmentType)
                .HasMaxLength(10);

            this.Property(t => t.EIAttachmentPath)
                .HasMaxLength(200);

            this.Property(t => t.Remark)
                .HasMaxLength(500);

            this.Property(t => t.EyeMiddle_X)
                .HasMaxLength(20);

            this.Property(t => t.EyeMiddle_Y)
                .HasMaxLength(20);

            this.Property(t => t.EyeInner_X)
                .HasMaxLength(20);

            this.Property(t => t.EyeInner_Y)
                .HasMaxLength(20);

            this.Property(t => t.EIASHA128)
                .HasMaxLength(128);

            //表与列的对应
            this.ToTable("MEyeImageAttachment");
            this.Property(t => t.EIAttachmentID).HasColumnName("EIAttachmentID");
            this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
            this.Property(t => t.EITypeCD).HasColumnName("EITypeCD");
            this.Property(t => t.EIAttachmentName).HasColumnName("EIAttachmentName");
            this.Property(t => t.EIAttachmentSize).HasColumnName("EIAttachmentSize");
            this.Property(t => t.EIAttachmentType).HasColumnName("EIAttachmentType");
            this.Property(t => t.EIAttachmentPath).HasColumnName("EIAttachmentPath");
            this.Property(t => t.UploadTime).HasColumnName("UploadTime");
            this.Property(t => t.UploadUserID).HasColumnName("UploadUserID");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.UploadOrder).HasColumnName("UploadOrder");
            this.Property(t => t.AutoReadID).HasColumnName("AutoReadID");
            this.Property(t => t.GlaucomaReadID).HasColumnName("GlaucomaReadID");
            this.Property(t => t.EyeMiddle_X).HasColumnName("EyeMiddle_X");
            this.Property(t => t.EyeMiddle_Y).HasColumnName("EyeMiddle_Y");
            this.Property(t => t.EyeInner_X).HasColumnName("EyeInner_X");
            this.Property(t => t.EyeInner_Y).HasColumnName("EyeInner_Y");
            this.Property(t => t.EIASHA128).HasColumnName("EIASHA128");

            //外键关系
            this.HasOptional(t => t.GlaucomaReadID_FK)
                .WithMany(t => t.MEyeImageAttachment_GlaucomaReadIDList)
                .HasForeignKey(d => d.GlaucomaReadID);
            this.HasOptional(t => t.EyeImageID_FK)
                .WithMany(t => t.MEyeImageAttachment_EyeImageIDList)
                .HasForeignKey(d => d.EyeImageID);
            this.HasOptional(t => t.UploadUserID_FK)
                .WithMany(t => t.MEyeImageAttachment_UploadUserIDList)
                .HasForeignKey(d => d.UploadUserID);
            this.HasOptional(t => t.AutoReadID_FK)
                .WithMany(t => t.MEyeImageAttachment_AutoReadIDList)
                .HasForeignKey(d => d.AutoReadID);
            this.HasOptional(t => t.EITypeCD_FK)
                .WithMany(t => t.MEyeImageAttachment_EITypeCDList)
                .HasForeignKey(d => d.EITypeCD);
        }
    }
}
