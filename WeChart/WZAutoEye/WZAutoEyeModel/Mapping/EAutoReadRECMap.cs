using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 自动阅片记录信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class EAutoReadRECMap : EntityTypeConfiguration<EAutoReadREC>
    {
      public EAutoReadRECMap()
      {
        //主键
        this.HasKey(t => t.AutoReadID);
        
        //属性
        
        this.Property(t => t.Unit)
            .HasMaxLength(64);
        
        this.Property(t => t.ReportTempletCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("EAutoReadREC");
        this.Property(t => t.AutoReadID).HasColumnName("AutoReadID");
        this.Property(t => t.EyeImageID).HasColumnName("EyeImageID");
        this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        this.Property(t => t.Unit).HasColumnName("Unit");
        this.Property(t => t.ReportTempletCD).HasColumnName("ReportTempletCD");
        this.Property(t => t.SettleStatus).HasColumnName("SettleStatus");
        this.Property(t => t.EyeOffice).HasColumnName("EyeOffice");
        
         //外键关系
        this.HasOptional(t => t.EyeImageID_FK)
            .WithMany(t => t.EAutoReadREC_EyeImageIDList)
            .HasForeignKey(d => d.EyeImageID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.EAutoReadREC_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.EAutoReadREC_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.Unit_FK)
            .WithMany(t => t.EAutoReadREC_UnitList)
            .HasForeignKey(d => d.Unit);
        this.HasOptional(t => t.ReportTempletCD_FK)
            .WithMany(t => t.EAutoReadREC_ReportTempletCDList)
            .HasForeignKey(d => d.ReportTempletCD);
      }
    }
}
