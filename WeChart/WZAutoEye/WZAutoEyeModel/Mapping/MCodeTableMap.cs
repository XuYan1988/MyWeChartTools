using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace WZAutoEye.WZAutoEyeMVC.Model.Mapping
{
    /// <summary>
    /// 文件说明: 码表信息实体映射
    /// 作    者: 袁恩龙
    /// 生成日期: 2017年10月23日
    /// 生成模板: CTSR.Template.Model.MVC_Model_01 版
    /// 修改说明：
    /// </summary>
    public class MCodeTableMap : EntityTypeConfiguration<MCodeTable>
    {
      public MCodeTableMap()
      {
        //主键
        this.HasKey(t => t.CodeTableCD);
        
        //属性
        
        this.Property(t => t.CodeCD)
            .HasMaxLength(64);
        
        this.Property(t => t.CodeType)
            .HasMaxLength(64);
        
        this.Property(t => t.CodeDesc)
            .HasMaxLength(500);
        
        this.Property(t => t.CodeDesc_EN)
            .HasMaxLength(500);
        
        this.Property(t => t.Remark)
            .HasMaxLength(500);
        
        //表与列的对应
        this.ToTable("MCodeTable");
        this.Property(t => t.CodeTableCD).HasColumnName("CodeTableCD");
        this.Property(t => t.CodeCD).HasColumnName("CodeCD");
        this.Property(t => t.CodeType).HasColumnName("CodeType");
        this.Property(t => t.CodeDesc).HasColumnName("CodeDesc");
        this.Property(t => t.CodeDesc_EN).HasColumnName("CodeDesc_EN");
        this.Property(t => t.OrderNum).HasColumnName("OrderNum");
        this.Property(t => t.Remark).HasColumnName("Remark");
        
      }
    }
}
