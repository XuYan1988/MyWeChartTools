using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年05月05日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EAbandonHisMap : EntityTypeConfiguration<EAbandonHis>
    {
      public EAbandonHisMap()
      {
        //主键
        this.HasKey(t => t.AbandonHisID);
        
        //属性
        
        this.Property(t => t.EIAttachmentPath)
            .HasMaxLength(200);
        
        this.Property(t => t.BleedingAmount)
            .HasMaxLength(100);
        
        this.Property(t => t.ExudeAmount)
            .HasMaxLength(100);
        
        this.Property(t => t.ImageQualityCD)
            .HasMaxLength(64);
        
        this.Property(t => t.DetailQualityCD)
            .HasMaxLength(64);
        
        this.Property(t => t.LensSituationCD)
            .HasMaxLength(64);
        
        this.Property(t => t.UnitCD)
            .HasMaxLength(64);
        
        this.Property(t => t.EyeType)
            .HasMaxLength(50);
        
        this.Property(t => t.Suggestion)
            .HasMaxLength(200);
        
        this.Property(t => t.ProcessTime)
            .HasMaxLength(100);
        
        //表与列的对应
        this.ToTable("EAbandonHis");
        this.Property(t => t.AbandonHisID).HasColumnName("AbandonHisID");
        this.Property(t => t.EIAttachmentID).HasColumnName("EIAttachmentID");
        this.Property(t => t.EIAttachmentPath).HasColumnName("EIAttachmentPath");
        this.Property(t => t.BleedingAmount).HasColumnName("BleedingAmount");
        this.Property(t => t.BleedingArea).HasColumnName("BleedingArea");
        this.Property(t => t.BleedingMostArea).HasColumnName("BleedingMostArea");
        this.Property(t => t.ExudeAmount).HasColumnName("ExudeAmount");
        this.Property(t => t.ExudeArea).HasColumnName("ExudeArea");
        this.Property(t => t.ExudeMostArea).HasColumnName("ExudeMostArea");
        this.Property(t => t.ImageQualityCD).HasColumnName("ImageQualityCD");
        this.Property(t => t.DetailQualityCD).HasColumnName("DetailQualityCD");
        this.Property(t => t.LensSituationCD).HasColumnName("LensSituationCD");
        this.Property(t => t.UnitCD).HasColumnName("UnitCD");
        this.Property(t => t.EyeType).HasColumnName("EyeType");
        this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        this.Property(t => t.Stain).HasColumnName("Stain");
        this.Property(t => t.ProcessTime).HasColumnName("ProcessTime");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.EIAttachmentID_FK)
            .WithMany(t => t.EAbandonHis_EIAttachmentIDList)
            .HasForeignKey(d => d.EIAttachmentID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EAbandonHis_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EAbandonHis_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}
