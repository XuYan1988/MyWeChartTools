using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EEyeImageAttachmentHisMap : EntityTypeConfiguration<EEyeImageAttachmentHis>
    {
      public EEyeImageAttachmentHisMap()
      {
        //主键
        this.HasKey(t => t.EIAttachmentHisID);
        
        //属性
        
        this.Property(t => t.EIAttachmentPath)
            .HasMaxLength(200);
        
        this.Property(t => t.EIAttachmentDRPath)
            .HasMaxLength(200);
        
        this.Property(t => t.EIAttachmentMISPath)
            .HasMaxLength(200);
        
        this.Property(t => t.EIAttachmentMISCoorPath)
            .HasMaxLength(200);
        
        this.Property(t => t.EIAttachmentERRPath)
            .HasMaxLength(200);
        
        this.Property(t => t.EIAttachmentERRCoorPath)
            .HasMaxLength(200);
        
        this.Property(t => t.ProcessStatusCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("EEyeImageAttachmentHis");
        this.Property(t => t.EIAttachmentHisID).HasColumnName("EIAttachmentHisID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.EIAttachmentID).HasColumnName("EIAttachmentID");
        this.Property(t => t.EIAttachmentPath).HasColumnName("EIAttachmentPath");
        this.Property(t => t.EIAttachmentDRPath).HasColumnName("EIAttachmentDRPath");
        this.Property(t => t.EIAttachmentMISPath).HasColumnName("EIAttachmentMISPath");
        this.Property(t => t.EIAttachmentMISCoorPath).HasColumnName("EIAttachmentMISCoorPath");
        this.Property(t => t.EIAttachmentERRPath).HasColumnName("EIAttachmentERRPath");
        this.Property(t => t.EIAttachmentERRCoorPath).HasColumnName("EIAttachmentERRCoorPath");
        this.Property(t => t.ProcessStatusCD).HasColumnName("ProcessStatusCD");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EEyeImageAttachmentHis_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.ProcessStatusCD_FK)
            .WithMany(t => t.EEyeImageAttachmentHis_ProcessStatusCDList)
            .HasForeignKey(d => d.ProcessStatusCD);
        this.HasOptional(t => t.EIAttachmentID_FK)
            .WithMany(t => t.EEyeImageAttachmentHis_EIAttachmentIDList)
            .HasForeignKey(d => d.EIAttachmentID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EEyeImageAttachmentHis_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EEyeImageAttachmentHis_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}
