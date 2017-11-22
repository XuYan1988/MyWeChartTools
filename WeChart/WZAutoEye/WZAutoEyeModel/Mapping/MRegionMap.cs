using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 销售区域表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年08月17日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MRegionMap : EntityTypeConfiguration<MRegion>
    {
      public MRegionMap()
      {
        //主键
        this.HasKey(t => t.RegionCD);
        
        //属性
        
        this.Property(t => t.RegionNM)
            .HasMaxLength(100);
        
        this.Property(t => t.PRegionCD)
            .HasMaxLength(64);
        
        //表与列的对应
        this.ToTable("MRegion");
        this.Property(t => t.RegionCD).HasColumnName("RegionCD");
        this.Property(t => t.SalesmanID).HasColumnName("SalesmanID");
        this.Property(t => t.RegionNM).HasColumnName("RegionNM");
        this.Property(t => t.PRegionCD).HasColumnName("PRegionCD");
        this.Property(t => t.Remark).HasColumnName("Remark");
        this.Property(t => t.UpdTime).HasColumnName("UpdTime");
        this.Property(t => t.UpdUserID).HasColumnName("UpdUserID");
        this.Property(t => t.InsTime).HasColumnName("InsTime");
        this.Property(t => t.InsUserID).HasColumnName("InsUserID");
        
         //外键关系
        this.HasOptional(t => t.SalesmanID_FK)
            .WithMany(t => t.MRegion_SalesmanIDList)
            .HasForeignKey(d => d.SalesmanID);
        this.HasOptional(t => t.InsUserID_FK)
            .WithMany(t => t.MRegion_InsUserIDList)
            .HasForeignKey(d => d.InsUserID);
        this.HasOptional(t => t.UpdUserID_FK)
            .WithMany(t => t.MRegion_UpdUserIDList)
            .HasForeignKey(d => d.UpdUserID);
      }
    }
}
